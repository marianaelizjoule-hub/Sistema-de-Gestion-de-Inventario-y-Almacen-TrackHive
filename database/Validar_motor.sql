SELECT @@VERSION AS version_completa;

SELECT
    SERVERPROPERTY('Edition')                  AS edicion,
    SERVERPROPERTY('ProductVersion')           AS version_producto,
    SERVERPROPERTY('InstanceName')             AS instancia,
    SERVERPROPERTY('IsIntegratedSecurityOnly') AS solo_autenticacion_windows;

SELECT local_net_address AS direccion_servidor,
       local_tcp_port    AS puerto,
       net_transport     AS protocolo
FROM sys.dm_exec_connections
WHERE session_id = @@SPID;

SELECT name AS base_de_datos FROM sys.databases;
