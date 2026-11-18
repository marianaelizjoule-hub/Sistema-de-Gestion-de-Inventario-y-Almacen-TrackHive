using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TrackHive.DAC
{
    public static class Conexion
    {
        public static SqlConnection Crear()
        {
            ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings["TrackHive"];
            if (cs == null)
                throw new InvalidOperationException("Falta la cadena de conexión 'TrackHive' en App.config.");
            return new SqlConnection(cs.ConnectionString);
        }

        public static SqlCommand Procedimiento(SqlConnection cn, string nombre)
        {
            return new SqlCommand(nombre, cn) { CommandType = CommandType.StoredProcedure };
        }
    }
}
