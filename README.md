# TrackHive – Sistema de Control de Inventario y Movimientos de Almacén

Aplicación de escritorio (C# WinForms, .NET Framework 4.8.1, ADO.NET) para el almacén de Grupo Almacenera Integral S.A.C., sede Arequipa.

**Estado: línea base de construcción (Semana 10).** Estructura de la solución por capas, base de datos implementada y primera ejecución técnica. Las funciones de registro llegan en el primer incremento funcional.

## Estructura de la solución

| Proyecto | Capa | Depende de |
|---|---|---|
| `TrackHive.Interfaz` | Presentación (formularios WinForms) | BL, Entidades |
| `TrackHive.BL` | Lógica de negocio (controladores, seguridad, sesión) | DAC, Entidades |
| `TrackHive.DAC` | Acceso a datos (repositorios ADO.NET) | Entidades |
| `TrackHive.Entidades` | Clases de dominio | — |

## Separación de responsabilidades
`Interfaz → BL → DAC → procedimiento almacenado → tabla`
- **Interfaz** (formularios): solo captura datos y muestra resultados. No conoce DAC ni la base de datos.
- **BL**: valida reglas (por ejemplo, nombre obligatorio) y traduce los errores de la base en mensajes.
- **DAC**: no escribe SQL; ejecuta procedimientos almacenados (`sp_...`) con parámetros.
- **Base de datos**: los procedimientos hacen los `SELECT`, `INSERT` y `UPDATE`. Así la aplicación no modifica las tablas directamente.

Caso de prueba de la línea base: *Registrar producto* (`FrmRegistrarProducto` → `ProductoControl.Registrar` → `ProductoRepositorio.Insertar` → `sp_Producto_Insertar`).

## Qué incluye esta línea base
- Inicio de sesión con contraseña con hash (PBKDF2) y pantalla principal distinta según el rol (Encargado de almacén / Administrador).
- Monitor de Inventario y consulta de stock leyendo la base de datos (comprueba la conexión aplicación–BD).
- Registrar producto como caso de prueba de un INSERT a través de las capas (equivalente al "insertar usuario" del ejemplo del profesor).
- Botones de las demás funciones visibles según los prototipos; muestran un aviso de que se implementarán en el primer incremento.
- Todos los formularios tienen `.Designer.cs` y se editan arrastrando controles en Visual Studio.

## Base de datos
Los scripts están en `database/` y se ejecutan en SQL Server Management Studio en este orden:
0. `00_Reiniciar_BD.sql` (opcional: BORRA la base para empezar de cero; solo para pruebas).
1. `Validar_motor.sql` (comprueba el motor).
2. `Creacion_BD.sql` (tablas, claves, restricciones, triggers, vista de stock, datos iniciales y todos los procedimientos almacenados: los de movimientos y los que usa la capa DAC para login, listas, stock, monitor y registro de producto).
3. `Datos_de_prueba.sql` (productos y movimientos de ejemplo).
4. `Respaldo_inicial.sql` (copia de respaldo).

Si su instancia es SQL Server Express, cambiar `Server=.` por `Server=.\SQLEXPRESS` en la cadena de conexión de `src/TrackHive.Interfaz/App.config`.
Usuarios de prueba (contraseña `Prueba#2026`): `mgomez` (Encargado de almacén) y `csalas` (Administrador / Responsable de logística).

## Cómo ejecutarlo
1. Abrir `TrackHive.slnx` en Visual Studio 2022 (17.13 o superior) o 2026.
2. Establecer `TrackHive.Interfaz` como proyecto de inicio y ejecutar con F5.

## Control de versiones
- Ramas: `main` (estable), `develop` (integración) y `feature/nombre-tema` (trabajo individual).
- Commits con prefijo: `feat:`, `fix:`, `db:`, `docs:`.
- Nadie modifica `main` directamente; todo entra por Pull Request a `develop`, revisado por otro integrante.
- Se versionan `src/` y `database/`. Se excluyen `bin/`, `obj/`, `.vs/`, `packages/`, `*.user`, `*.suo` y `*.bak` (ver `.gitignore`).
