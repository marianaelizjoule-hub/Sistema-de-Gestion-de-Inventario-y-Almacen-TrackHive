USE master;
GO
IF DB_ID(N'TrackHive') IS NULL
    CREATE DATABASE TrackHive;
GO
USE TrackHive;
GO

CREATE TABLE Categoria (
    id_categoria INT IDENTITY(1,1) NOT NULL,
    nombre       VARCHAR(50)       NOT NULL,
    CONSTRAINT PK_Categoria        PRIMARY KEY (id_categoria),
    CONSTRAINT UQ_Categoria_nombre UNIQUE (nombre)
);

CREATE TABLE Usuario (
    id_usuario      INT IDENTITY(1,1) NOT NULL,
    nombre_usuario  VARCHAR(50)       NOT NULL,
    contrasena      VARCHAR(255)      NOT NULL,
    nombre_completo VARCHAR(100)      NOT NULL,
    rol             VARCHAR(30)       NOT NULL,
    activo          BIT               NOT NULL CONSTRAINT DF_Usuario_activo DEFAULT 1,
    CONSTRAINT PK_Usuario        PRIMARY KEY (id_usuario),
    CONSTRAINT UQ_Usuario_nombre UNIQUE (nombre_usuario),
    CONSTRAINT CK_Usuario_rol    CHECK (rol IN ('Encargado de almacén', 'Responsable de logística'))
);

CREATE TABLE Marca (
    id_marca            INT IDENTITY(1,1) NOT NULL,
    nombre_marca        VARCHAR(100)      NOT NULL,
    limite_posiciones   INT               NOT NULL,
    posiciones_ocupadas INT               NOT NULL CONSTRAINT DF_Marca_ocupadas DEFAULT 0,
    fecha_actualizacion DATE              NOT NULL CONSTRAINT DF_Marca_fecha DEFAULT (CAST(GETDATE() AS DATE)),
    CONSTRAINT PK_Marca          PRIMARY KEY (id_marca),
    CONSTRAINT UQ_Marca_nombre   UNIQUE (nombre_marca),
    CONSTRAINT CK_Marca_limite   CHECK (limite_posiciones > 0),
    CONSTRAINT CK_Marca_ocupadas CHECK (posiciones_ocupadas >= 0)
);

CREATE TABLE MarcaCategoria (
    id_marca     INT NOT NULL,
    id_categoria INT NOT NULL,
    CONSTRAINT PK_MarcaCategoria           PRIMARY KEY (id_marca, id_categoria),
    CONSTRAINT FK_MarcaCategoria_Marca     FOREIGN KEY (id_marca)     REFERENCES Marca (id_marca),
    CONSTRAINT FK_MarcaCategoria_Categoria FOREIGN KEY (id_categoria) REFERENCES Categoria (id_categoria)
);

CREATE TABLE Producto (
    id_producto  INT IDENTITY(1,1) NOT NULL,
    nombre       VARCHAR(100)      NOT NULL,
    descripcion  VARCHAR(255)      NULL,
    id_marca     INT               NOT NULL,
    id_categoria INT               NOT NULL,
    CONSTRAINT PK_Producto              PRIMARY KEY (id_producto),
    CONSTRAINT UQ_Producto_marca_nombre UNIQUE (id_marca, nombre),

    CONSTRAINT FK_Producto_MarcaCategoria FOREIGN KEY (id_marca, id_categoria)
        REFERENCES MarcaCategoria (id_marca, id_categoria)
);

CREATE TABLE Movimiento (
    id_movimiento         INT IDENTITY(1,1) NOT NULL,
    id_marca              INT               NOT NULL,
    id_usuario            INT               NOT NULL,
    tipo_movimiento       VARCHAR(30)       NOT NULL,
    fecha                 DATE              NOT NULL CONSTRAINT DF_Movimiento_fecha DEFAULT (CAST(GETDATE() AS DATE)),
    dni_retira            VARCHAR(8)        NULL,
    motivo                VARCHAR(255)      NULL,
    persona_autoriza      VARCHAR(100)      NULL,
    dni_autoriza          VARCHAR(8)        NULL,
    posiciones_requeridas INT               NULL,
    observaciones         VARCHAR(255)      NULL,
    CONSTRAINT PK_Movimiento         PRIMARY KEY (id_movimiento),
    CONSTRAINT FK_Movimiento_Marca   FOREIGN KEY (id_marca)   REFERENCES Marca (id_marca),
    CONSTRAINT FK_Movimiento_Usuario FOREIGN KEY (id_usuario) REFERENCES Usuario (id_usuario),
    CONSTRAINT CK_Movimiento_tipo    CHECK (tipo_movimiento IN ('Ingreso', 'Salida por entrega', 'Salida por desecho')),
    CONSTRAINT CK_Movimiento_dni_retira   CHECK (dni_retira   IS NULL OR dni_retira   LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    CONSTRAINT CK_Movimiento_dni_autoriza CHECK (dni_autoriza IS NULL OR dni_autoriza LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    CONSTRAINT CK_Movimiento_posiciones   CHECK (posiciones_requeridas IS NULL OR posiciones_requeridas >= 0),

    CONSTRAINT CK_Movimiento_campos_por_tipo CHECK (
           (tipo_movimiento = 'Ingreso'
              AND posiciones_requeridas IS NOT NULL
              AND dni_retira IS NULL AND motivo IS NULL AND persona_autoriza IS NULL AND dni_autoriza IS NULL)
        OR (tipo_movimiento = 'Salida por entrega'
              AND dni_retira IS NOT NULL
              AND posiciones_requeridas IS NULL AND motivo IS NULL AND persona_autoriza IS NULL AND dni_autoriza IS NULL)
        OR (tipo_movimiento = 'Salida por desecho'
              AND motivo IS NOT NULL AND LEN(LTRIM(RTRIM(motivo))) > 0
              AND dni_autoriza IS NOT NULL
              AND dni_retira IS NULL AND posiciones_requeridas IS NULL)
    )
);

CREATE TABLE DetalleMovimiento (
    id_detalle    INT IDENTITY(1,1) NOT NULL,
    id_movimiento INT               NOT NULL,
    id_producto   INT               NOT NULL,
    cantidad      INT               NOT NULL,
    CONSTRAINT PK_DetalleMovimiento  PRIMARY KEY (id_detalle),
    CONSTRAINT FK_Detalle_Movimiento FOREIGN KEY (id_movimiento) REFERENCES Movimiento (id_movimiento),
    CONSTRAINT FK_Detalle_Producto   FOREIGN KEY (id_producto)   REFERENCES Producto (id_producto),
    CONSTRAINT UQ_Detalle_mov_prod   UNIQUE (id_movimiento, id_producto),
    CONSTRAINT CK_Detalle_cantidad   CHECK (cantidad > 0)
);

CREATE TABLE DocumentoSustento (
    id_documento     INT IDENTITY(1,1) NOT NULL,
    id_movimiento    INT               NOT NULL,
    tipo_documento   VARCHAR(30)       NOT NULL,
    numero           VARCHAR(30)       NOT NULL,
    nombre_archivo   VARCHAR(150)      NOT NULL,
    ruta_archivo_pdf VARCHAR(255)      NOT NULL,
    CONSTRAINT PK_DocumentoSustento    PRIMARY KEY (id_documento),
    CONSTRAINT FK_Documento_Movimiento FOREIGN KEY (id_movimiento) REFERENCES Movimiento (id_movimiento),
    CONSTRAINT UQ_Documento_movimiento UNIQUE (id_movimiento),
    CONSTRAINT UQ_Documento_archivo    UNIQUE (nombre_archivo),
    CONSTRAINT CK_Documento_tipo       CHECK (tipo_documento IN ('Guía de remisión', 'Remito', 'Cargo de Entrega')),
    CONSTRAINT CK_Documento_numero     CHECK (LEN(LTRIM(RTRIM(numero))) > 0),
    CONSTRAINT CK_Documento_pdf        CHECK (LOWER(nombre_archivo) LIKE '%.pdf')
);
GO

CREATE TRIGGER TR_Movimiento_tipo_inmutable ON Movimiento
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1
               FROM inserted i
               JOIN deleted d ON d.id_movimiento = i.id_movimiento
               WHERE i.tipo_movimiento <> d.tipo_movimiento)
    BEGIN
        RAISERROR('El tipo de movimiento no se puede cambiar después de guardarlo.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

CREATE TRIGGER TR_Detalle_marca_producto ON DetalleMovimiento
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1
               FROM inserted i
               JOIN Movimiento m ON m.id_movimiento = i.id_movimiento
               JOIN Producto   p ON p.id_producto   = i.id_producto
               WHERE p.id_marca <> m.id_marca)
    BEGIN
        RAISERROR('Todos los productos de un movimiento deben pertenecer a la marca del movimiento.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

CREATE TRIGGER TR_Documento_tipo_movimiento ON DocumentoSustento
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1
               FROM inserted i
               JOIN Movimiento m ON m.id_movimiento = i.id_movimiento
               WHERE NOT (   (m.tipo_movimiento = 'Ingreso'            AND i.tipo_documento IN ('Guía de remisión', 'Remito'))
                          OR (m.tipo_movimiento = 'Salida por entrega' AND i.tipo_documento = 'Cargo de Entrega')))
    BEGIN
        RAISERROR('El tipo de documento no corresponde al tipo de movimiento. Las salidas por desecho no llevan documento.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

CREATE INDEX IX_Movimiento_marca_tipo    ON Movimiento (id_marca, tipo_movimiento) INCLUDE (fecha);
CREATE INDEX IX_Detalle_producto         ON DetalleMovimiento (id_producto) INCLUDE (id_movimiento, cantidad);
CREATE INDEX IX_Producto_categoria_marca ON Producto (id_categoria, id_marca);
GO

CREATE VIEW vw_StockProducto AS
SELECT p.id_producto,
       m.id_marca,
       m.nombre_marca AS marca,
       c.id_categoria,
       c.nombre       AS categoria,
       p.nombre       AS producto,
       ISNULL(SUM(CASE WHEN mo.tipo_movimiento = 'Ingreso' THEN d.cantidad ELSE -d.cantidad END), 0) AS stock
FROM Producto p
JOIN Marca     m ON m.id_marca     = p.id_marca
JOIN Categoria c ON c.id_categoria = p.id_categoria
LEFT JOIN DetalleMovimiento d  ON d.id_producto    = p.id_producto
LEFT JOIN Movimiento        mo ON mo.id_movimiento = d.id_movimiento
GROUP BY p.id_producto, m.id_marca, m.nombre_marca, c.id_categoria, c.nombre, p.nombre;
GO

CREATE TYPE TipoDetalleMovimiento AS TABLE (
    id_producto INT NOT NULL PRIMARY KEY,
    cantidad    INT NOT NULL CHECK (cantidad > 0)
);
GO

CREATE PROCEDURE sp_RegistrarIngreso
    @id_marca              INT,
    @id_usuario            INT,
    @posiciones_requeridas INT,
    @tipo_documento        VARCHAR(30),
    @numero_documento      VARCHAR(30),
    @nombre_archivo        VARCHAR(150),
    @ruta_archivo_pdf      VARCHAR(255),
    @observaciones         VARCHAR(255) = NULL,
    @fecha                 DATE = NULL,
    @detalle               TipoDetalleMovimiento READONLY,
    @id_movimiento         INT OUTPUT,
    @supera_limite         BIT = 0 OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM @detalle)
            THROW 50001, 'Debe indicar al menos un producto.', 1;
        IF @posiciones_requeridas IS NULL OR @posiciones_requeridas < 0
            THROW 50006, 'Debe indicar las posiciones requeridas (cero o más).', 1;
        IF @tipo_documento NOT IN ('Guía de remisión', 'Remito')
            THROW 50002, 'El ingreso solo admite Guía de remisión o Remito.', 1;
        IF @numero_documento IS NULL OR LEN(LTRIM(RTRIM(@numero_documento))) = 0
            THROW 50003, 'Debe ingresar el número de la guía de remisión o del remito.', 1;

        BEGIN TRANSACTION;

        INSERT INTO Movimiento (id_marca, id_usuario, tipo_movimiento, fecha, posiciones_requeridas, observaciones)
        VALUES (@id_marca, @id_usuario, 'Ingreso', ISNULL(@fecha, CAST(GETDATE() AS DATE)), @posiciones_requeridas, @observaciones);
        SET @id_movimiento = SCOPE_IDENTITY();

        INSERT INTO DetalleMovimiento (id_movimiento, id_producto, cantidad)
        SELECT @id_movimiento, id_producto, cantidad FROM @detalle;

        INSERT INTO DocumentoSustento (id_movimiento, tipo_documento, numero, nombre_archivo, ruta_archivo_pdf)
        VALUES (@id_movimiento, @tipo_documento, LTRIM(RTRIM(@numero_documento)), @nombre_archivo, @ruta_archivo_pdf);

        SELECT @supera_limite = CASE WHEN posiciones_ocupadas + @posiciones_requeridas > limite_posiciones THEN 1 ELSE 0 END
          FROM Marca
         WHERE id_marca = @id_marca;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE sp_RegistrarSalidaEntrega
    @id_marca         INT,
    @id_usuario       INT,
    @dni_retira       VARCHAR(8),
    @numero_cargo     VARCHAR(30),
    @nombre_archivo   VARCHAR(150),
    @ruta_archivo_pdf VARCHAR(255),
    @observaciones    VARCHAR(255) = NULL,
    @fecha            DATE = NULL,
    @detalle          TipoDetalleMovimiento READONLY,
    @id_movimiento    INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM @detalle)
            THROW 50001, 'Debe indicar al menos un producto.', 1;
        IF @numero_cargo IS NULL OR LEN(LTRIM(RTRIM(@numero_cargo))) = 0
            THROW 50003, 'Debe ingresar el número del Cargo de Entrega.', 1;

        BEGIN TRANSACTION;

        IF EXISTS (SELECT 1
                   FROM @detalle d
                   JOIN vw_StockProducto s ON s.id_producto = d.id_producto
                   WHERE d.cantidad > s.stock)
            THROW 50005, 'La cantidad solicitada supera el stock disponible de un producto.', 1;

        INSERT INTO Movimiento (id_marca, id_usuario, tipo_movimiento, fecha, dni_retira, observaciones)
        VALUES (@id_marca, @id_usuario, 'Salida por entrega', ISNULL(@fecha, CAST(GETDATE() AS DATE)), @dni_retira, @observaciones);
        SET @id_movimiento = SCOPE_IDENTITY();

        INSERT INTO DetalleMovimiento (id_movimiento, id_producto, cantidad)
        SELECT @id_movimiento, id_producto, cantidad FROM @detalle;

        INSERT INTO DocumentoSustento (id_movimiento, tipo_documento, numero, nombre_archivo, ruta_archivo_pdf)
        VALUES (@id_movimiento, 'Cargo de Entrega', LTRIM(RTRIM(@numero_cargo)), @nombre_archivo, @ruta_archivo_pdf);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE sp_RegistrarSalidaDesecho
    @id_marca         INT,
    @id_usuario       INT,
    @motivo           VARCHAR(255),
    @dni_autoriza     VARCHAR(8),
    @persona_autoriza VARCHAR(100) = NULL,
    @observaciones    VARCHAR(255) = NULL,
    @fecha            DATE = NULL,
    @detalle          TipoDetalleMovimiento READONLY,
    @id_movimiento    INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM @detalle)
            THROW 50001, 'Debe indicar al menos un producto.', 1;
        IF @dni_autoriza IS NULL OR @dni_autoriza NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
            THROW 50007, 'El DNI de quien autoriza debe tener 8 dígitos.', 1;

        BEGIN TRANSACTION;

        IF EXISTS (SELECT 1
                   FROM @detalle d
                   JOIN vw_StockProducto s ON s.id_producto = d.id_producto
                   WHERE d.cantidad > s.stock)
            THROW 50005, 'La cantidad solicitada supera el stock disponible de un producto.', 1;

        INSERT INTO Movimiento (id_marca, id_usuario, tipo_movimiento, fecha, motivo, persona_autoriza, dni_autoriza, observaciones)
        VALUES (@id_marca, @id_usuario, 'Salida por desecho', ISNULL(@fecha, CAST(GETDATE() AS DATE)), @motivo, @persona_autoriza, @dni_autoriza, @observaciones);
        SET @id_movimiento = SCOPE_IDENTITY();

        INSERT INTO DetalleMovimiento (id_movimiento, id_producto, cantidad)
        SELECT @id_movimiento, id_producto, cantidad FROM @detalle;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE VIEW vw_MovimientosSinDocumento AS
SELECT mo.id_movimiento, mo.tipo_movimiento, mo.fecha, mo.id_marca
FROM Movimiento mo
LEFT JOIN DocumentoSustento ds ON ds.id_movimiento = mo.id_movimiento
WHERE mo.tipo_movimiento IN ('Ingreso', 'Salida por entrega')
  AND ds.id_documento IS NULL;
GO

INSERT INTO Categoria (nombre) VALUES
    ('Textiles'), ('EPP'), ('Merchandising'), ('Material POP'), ('Material BTL'), ('Activos');

INSERT INTO Marca (nombre_marca, limite_posiciones, posiciones_ocupadas, fecha_actualizacion) VALUES
    ('HONOR', 10, 0, CAST(GETDATE() AS DATE)),
    ('OPPO', 50, 40, '2026-09-20'),
    ('COCACOLA', 10, 0, CAST(GETDATE() AS DATE)),
    ('TAKIS', 10, 0, CAST(GETDATE() AS DATE)),
    ('SAMSUNG', 10, 0, CAST(GETDATE() AS DATE)),
    ('GLORIA', 10, 0, CAST(GETDATE() AS DATE)),
    ('LA IBÉRICA', 10, 0, CAST(GETDATE() AS DATE)),
    ('KUNA', 10, 0, CAST(GETDATE() AS DATE)),
    ('CERVEZA AREQUIPEÑA', 10, 0, CAST(GETDATE() AS DATE)),
    ('KOLA ESCOCESA', 10, 0, CAST(GETDATE() AS DATE)),
    ('YURA', 10, 0, CAST(GETDATE() AS DATE)),
    ('CAJA AREQUIPA', 10, 0, CAST(GETDATE() AS DATE)),
    ('ACEROS AREQUIPA', 10, 0, CAST(GETDATE() AS DATE)),
    ('MICHELL & CÍA', 10, 0, CAST(GETDATE() AS DATE)),
    ('CAPRICCIO', 10, 0, CAST(GETDATE() AS DATE)),
    ('ANÍS NÁJAR', 10, 0, CAST(GETDATE() AS DATE)),
    ('RICO POLLO', 10, 0, CAST(GETDATE() AS DATE)),
    ('SOCOSANI', 10, 0, CAST(GETDATE() AS DATE)),
    ('INCA KOLA', 10, 0, CAST(GETDATE() AS DATE)),
    ('BIG COLA', 10, 0, CAST(GETDATE() AS DATE)),
    ('ALICORP', 10, 0, CAST(GETDATE() AS DATE)),
    ('CERVEZA CUSQUEÑA', 10, 0, CAST(GETDATE() AS DATE)),
    ('BCP', 10, 0, CAST(GETDATE() AS DATE)),
    ('INTERBANK', 10, 0, CAST(GETDATE() AS DATE)),
    ('D''ONOFRIO', 10, 0, CAST(GETDATE() AS DATE)),
    ('BELCORP', 10, 0, CAST(GETDATE() AS DATE)),
    ('TOPITOP', 10, 0, CAST(GETDATE() AS DATE)),
    ('SAPOLIO', 10, 0, CAST(GETDATE() AS DATE)),
    ('APPLE', 10, 0, CAST(GETDATE() AS DATE)),
    ('NIKE', 10, 0, CAST(GETDATE() AS DATE)),
    ('ADIDAS', 10, 0, CAST(GETDATE() AS DATE)),
    ('TOYOTA', 10, 0, CAST(GETDATE() AS DATE)),
    ('NESTLÉ', 10, 0, CAST(GETDATE() AS DATE)),
    ('MCDONALD''S', 10, 0, CAST(GETDATE() AS DATE)),
    ('STARBUCKS', 10, 0, CAST(GETDATE() AS DATE));

INSERT INTO MarcaCategoria (id_marca, id_categoria)
SELECT m.id_marca, c.id_categoria
FROM (VALUES ('HONOR', 'Activos'),
             ('OPPO', 'Material BTL'),
             ('COCACOLA', 'Textiles'),
             ('TAKIS', 'Material BTL'),
             ('SAMSUNG', 'Activos')) AS v (marca, categoria)
JOIN Marca     m ON m.nombre_marca = v.marca
JOIN Categoria c ON c.nombre       = v.categoria;

INSERT INTO MarcaCategoria (id_marca, id_categoria)
SELECT m.id_marca, c.id_categoria
FROM Marca m
CROSS JOIN Categoria c
WHERE m.nombre_marca LIKE 'MARCAS DE AQUÍ [0-9][0-9]';

INSERT INTO Usuario (nombre_usuario, contrasena, nombre_completo, rol) VALUES
    ('mgomez', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Prueba#2026'), 2), 'Marcos Gomez Fuentes', 'Encargado de almacén'),
    ('csalas', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'Prueba#2026'), 2), 'Camilo Salas Garcia',  'Responsable de logística');
GO

SELECT (SELECT COUNT(*) FROM Categoria)      AS categorias,
       (SELECT COUNT(*) FROM Marca)          AS marcas,
       (SELECT COUNT(*) FROM MarcaCategoria) AS marca_categoria,
       (SELECT COUNT(*) FROM Usuario)        AS usuarios;
GO

CREATE OR ALTER PROCEDURE sp_Usuario_ObtenerPorNombre
    @nombre_usuario VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT id_usuario, nombre_usuario, nombre_completo, contrasena, rol
    FROM Usuario
    WHERE nombre_usuario = @nombre_usuario AND activo = 1;
END
GO

CREATE OR ALTER PROCEDURE sp_Usuario_ActualizarContrasena
    @id_usuario INT,
    @contrasena VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Usuario SET contrasena = @contrasena WHERE id_usuario = @id_usuario;
END
GO

CREATE OR ALTER PROCEDURE sp_Marca_Listar
AS
BEGIN
    SET NOCOUNT ON;
    SELECT id_marca, nombre_marca, limite_posiciones, posiciones_ocupadas, fecha_actualizacion
    FROM Marca
    ORDER BY nombre_marca;
END
GO

CREATE OR ALTER PROCEDURE sp_Categoria_Listar
AS
BEGIN
    SET NOCOUNT ON;
    SELECT id_categoria, nombre FROM Categoria ORDER BY nombre;
END
GO

CREATE OR ALTER PROCEDURE sp_Categoria_ListarPorMarca
    @id_marca INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT c.id_categoria, c.nombre
    FROM MarcaCategoria mc
    JOIN Categoria c ON c.id_categoria = mc.id_categoria
    WHERE mc.id_marca = @id_marca
    ORDER BY c.nombre;
END
GO

CREATE OR ALTER PROCEDURE sp_Producto_ListarPorMarca
    @id_marca     INT,
    @id_categoria INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT p.id_producto, p.nombre, p.id_marca, p.id_categoria, c.nombre AS categoria
    FROM Producto p
    JOIN Categoria c ON c.id_categoria = p.id_categoria
    WHERE p.id_marca = @id_marca
      AND (@id_categoria IS NULL OR p.id_categoria = @id_categoria)
    ORDER BY p.nombre;
END
GO

CREATE OR ALTER PROCEDURE sp_Producto_Insertar
    @nombre       VARCHAR(100),
    @id_marca     INT,
    @id_categoria INT,
    @id_producto  INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    BEGIN TRY
        IF @nombre IS NULL OR LEN(LTRIM(RTRIM(@nombre))) = 0
            THROW 50010, 'Debe ingresar el nombre del producto.', 1;
        IF NOT EXISTS (SELECT 1 FROM Marca WHERE id_marca = @id_marca)
            THROW 50012, 'La marca seleccionada no existe.', 1;
        IF NOT EXISTS (SELECT 1 FROM Categoria WHERE id_categoria = @id_categoria)
            THROW 50013, 'La categoría seleccionada no existe.', 1;
        IF EXISTS (SELECT 1 FROM Producto WHERE id_marca = @id_marca AND nombre = LTRIM(RTRIM(@nombre)))
            THROW 50011, 'Ya existe un producto con ese nombre en la marca seleccionada.', 1;

        BEGIN TRANSACTION;

        IF NOT EXISTS (SELECT 1 FROM MarcaCategoria WHERE id_marca = @id_marca AND id_categoria = @id_categoria)
            INSERT INTO MarcaCategoria (id_marca, id_categoria) VALUES (@id_marca, @id_categoria);

        INSERT INTO Producto (nombre, id_marca, id_categoria)
        VALUES (LTRIM(RTRIM(@nombre)), @id_marca, @id_categoria);
        SET @id_producto = SCOPE_IDENTITY();

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE sp_Stock_Consultar
    @id_marca     INT = NULL,
    @id_categoria INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT s.marca, s.categoria, s.producto, s.stock,
           (SELECT MAX(mo.fecha)
              FROM DetalleMovimiento d
              JOIN Movimiento mo ON mo.id_movimiento = d.id_movimiento
             WHERE d.id_producto = s.id_producto) AS ultimo_movimiento
    FROM vw_StockProducto s
    WHERE (@id_marca IS NULL OR s.id_marca = @id_marca)
      AND (@id_categoria IS NULL OR s.id_categoria = @id_categoria)
    ORDER BY s.marca, s.producto;
END
GO

CREATE OR ALTER PROCEDURE sp_Monitor_Ingresos
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @guia NVARCHAR(30) = N'Gu' + NCHAR(237) + N'a de remisi' + NCHAR(243) + N'n';
    SELECT mo.id_movimiento, p.id_producto, mo.fecha, m.nombre_marca, p.nombre, d.cantidad, UPPER(c.nombre) AS categoria,
           CASE WHEN ds.tipo_documento = @guia   THEN ds.numero END AS guia_remision,
           CASE WHEN ds.tipo_documento = 'Remito' THEN ds.numero END AS remito
    FROM Movimiento mo
    JOIN DetalleMovimiento d ON d.id_movimiento = mo.id_movimiento
    JOIN Producto p          ON p.id_producto   = d.id_producto
    JOIN Marca m             ON m.id_marca      = mo.id_marca
    JOIN Categoria c         ON c.id_categoria  = p.id_categoria
    LEFT JOIN DocumentoSustento ds ON ds.id_movimiento = mo.id_movimiento
    WHERE mo.tipo_movimiento = 'Ingreso'
    ORDER BY mo.fecha DESC, mo.id_movimiento DESC;
END
GO

CREATE OR ALTER PROCEDURE sp_Monitor_Salidas
    @id_producto INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT mo.fecha, mo.tipo_movimiento, d.cantidad,
           CASE WHEN mo.tipo_movimiento = 'Salida por entrega'
                THEN 'DNI de quien retira: ' + ISNULL(mo.dni_retira, '-')
                ELSE 'Motivo: ' + ISNULL(mo.motivo, '-') + ' | DNI de quien autoriza: ' + ISNULL(mo.dni_autoriza, '-') END AS detalle
    FROM DetalleMovimiento d
    JOIN Movimiento mo ON mo.id_movimiento = d.id_movimiento
    WHERE d.id_producto = @id_producto AND mo.tipo_movimiento <> 'Ingreso'
    ORDER BY mo.fecha DESC, mo.id_movimiento DESC;
END
GO

SELECT name AS procedimiento FROM sys.procedures WHERE name LIKE 'sp[_]%' ORDER BY name;
GO
