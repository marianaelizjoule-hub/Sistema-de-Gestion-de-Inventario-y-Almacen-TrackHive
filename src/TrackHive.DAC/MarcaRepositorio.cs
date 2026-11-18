using System.Collections.Generic;
using System.Data.SqlClient;
using TrackHive.Entidades;

namespace TrackHive.DAC
{
    public class MarcaRepositorio
    {
        public List<Marca> ObtenerTodas()
        {
            var lista = new List<Marca>();
            using (SqlConnection cn = Conexion.Crear())
            using (SqlCommand cmd = Conexion.Procedimiento(cn, "sp_Marca_Listar"))
            {
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        lista.Add(new Marca
                        {
                            IdMarca = rd.GetInt32(0),
                            NombreMarca = rd.GetString(1),
                            LimitePosiciones = rd.GetInt32(2),
                            PosicionesOcupadas = rd.GetInt32(3),
                            FechaActualizacion = rd.GetDateTime(4)
                        });
                    }
                }
            }
            return lista;
        }
    }
}
