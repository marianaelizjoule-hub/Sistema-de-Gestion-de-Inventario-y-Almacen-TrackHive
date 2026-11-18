USE master;
GO
DECLARE @carpeta NVARCHAR(400) = ISNULL(CAST(SERVERPROPERTY('InstanceDefaultBackupPath') AS NVARCHAR(400)), N'C:\TrackHive\Respaldo');
DECLARE @ruta    NVARCHAR(500) = @carpeta + N'\TrackHive_inicial.bak';

BACKUP DATABASE TrackHive
TO DISK = @ruta
WITH INIT, CHECKSUM, STATS = 10, NAME = N'TrackHive - respaldo inicial';

RESTORE VERIFYONLY FROM DISK = @ruta WITH CHECKSUM;

SELECT @ruta AS archivo_de_respaldo;
GO
