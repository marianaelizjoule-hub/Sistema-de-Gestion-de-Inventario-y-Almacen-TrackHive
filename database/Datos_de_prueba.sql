USE TrackHive;
GO

INSERT INTO Producto (nombre, id_marca, id_categoria)
SELECT v.producto, m.id_marca, c.id_categoria
FROM (VALUES ('TABLETS',   'HONOR',    'Activos'),
             ('PARLANTES', 'OPPO',     'Material BTL'),
             ('POLOS',     'COCACOLA', 'Textiles'),
             ('RULETAS',   'TAKIS',    'Material BTL'),
             ('CELULARES', 'SAMSUNG',  'Activos')) AS v (producto, marca, categoria)
JOIN Marca     m ON m.nombre_marca = v.marca
JOIN Categoria c ON c.nombre       = v.categoria;

DECLARE @encargado INT = (SELECT id_usuario FROM Usuario WHERE nombre_usuario = 'mgomez');

INSERT INTO Movimiento (id_marca, id_usuario, tipo_movimiento, fecha, posiciones_requeridas)
SELECT m.id_marca, @encargado, 'Ingreso', v.fecha, v.posiciones
FROM (VALUES ('HONOR',    CAST('2026-09-23' AS DATE), 5),
             ('OPPO',     CAST('2026-09-24' AS DATE), 20),
             ('COCACOLA', CAST('2026-09-24' AS DATE), 5),
             ('TAKIS',    CAST('2026-09-25' AS DATE), 5),
             ('SAMSUNG',  CAST('2026-09-25' AS DATE), 5)) AS v (marca, fecha, posiciones)
JOIN Marca m ON m.nombre_marca = v.marca;

INSERT INTO DetalleMovimiento (id_movimiento, id_producto, cantidad)
SELECT mo.id_movimiento, p.id_producto, v.cantidad
FROM (VALUES ('HONOR',    'TABLETS',   20),
             ('OPPO',     'PARLANTES', 10),
             ('COCACOLA', 'POLOS',     30),
             ('TAKIS',    'RULETAS',    5),
             ('SAMSUNG',  'CELULARES', 15)) AS v (marca, producto, cantidad)
JOIN Marca      ma ON ma.nombre_marca = v.marca
JOIN Producto   p  ON p.id_marca = ma.id_marca AND p.nombre = v.producto
JOIN Movimiento mo ON mo.id_marca = ma.id_marca AND mo.tipo_movimiento = 'Ingreso';

INSERT INTO DocumentoSustento (id_movimiento, tipo_documento, numero, nombre_archivo, ruta_archivo_pdf)
SELECT mo.id_movimiento, v.tipo, v.numero, v.numero + '.pdf',
       '\\SRV-AQP\TrackHive_PDF\confirmados\' + v.numero + '.pdf'
FROM (VALUES ('HONOR',    'Guía de remisión', 'TT1-00002155'),
             ('OPPO',     'Guía de remisión', 'TTT1-025903'),
             ('COCACOLA', 'Remito',           '163889-5'),
             ('TAKIS',    'Remito',           '163837-2'),
             ('SAMSUNG',  'Guía de remisión', 'EG07-00000019')) AS v (marca, tipo, numero)
JOIN Marca      ma ON ma.nombre_marca = v.marca
JOIN Movimiento mo ON mo.id_marca = ma.id_marca AND mo.tipo_movimiento = 'Ingreso';

DECLARE @oppo      INT = (SELECT id_marca FROM Marca WHERE nombre_marca = 'OPPO');
DECLARE @parlantes INT = (SELECT id_producto FROM Producto WHERE nombre = 'PARLANTES' AND id_marca = @oppo);
DECLARE @enc2      INT = (SELECT id_usuario FROM Usuario WHERE nombre_usuario = 'mgomez');
DECLARE @mov       INT;

INSERT INTO Movimiento (id_marca, id_usuario, tipo_movimiento, fecha, dni_retira)
VALUES (@oppo, @enc2, 'Salida por entrega', '2026-09-26', '29806734');
SET @mov = SCOPE_IDENTITY();
INSERT INTO DetalleMovimiento (id_movimiento, id_producto, cantidad) VALUES (@mov, @parlantes, 4);
INSERT INTO DocumentoSustento (id_movimiento, tipo_documento, numero, nombre_archivo, ruta_archivo_pdf)
VALUES (@mov, 'Cargo de Entrega', 'CE-0001', 'CE-0001.pdf', '\\SRV-AQP\TrackHive_PDF\confirmados\CE-0001.pdf');

INSERT INTO Movimiento (id_marca, id_usuario, tipo_movimiento, fecha, motivo, persona_autoriza, dni_autoriza)
VALUES (@oppo, @enc2, 'Salida por desecho', '2026-09-27', 'Producto dañado', 'Camilo Salas Garcia', '29806734');
SET @mov = SCOPE_IDENTITY();
INSERT INTO DetalleMovimiento (id_movimiento, id_producto, cantidad) VALUES (@mov, @parlantes, 1);
GO

SELECT marca, categoria, producto, stock
FROM vw_StockProducto
ORDER BY marca, producto;
GO

SELECT * FROM vw_MovimientosSinDocumento;
GO
