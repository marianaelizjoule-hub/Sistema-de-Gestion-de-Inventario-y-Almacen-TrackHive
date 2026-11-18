using System.Collections.Generic;
using System.Data.SqlClient;
using TrackHive.Entidades;

namespace TrackHive.DAC
{
    public class MonitorRepositorio
    {
        public List<FilaMonitor> ObtenerIngresos()
        {
            var lista = new List<FilaMonitor>();
            using (SqlConnection cn = Conexion.Crear())
            using (SqlCommand cmd = Conexion.Procedimiento(cn, "sp_Monitor_Ingresos"))
            {
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        lista.Add(new FilaMonitor
                        {
                            IdMovimiento = rd.GetInt32(0),
                            IdProducto = rd.GetInt32(1),
                            Fecha = rd.GetDateTime(2),
                            Marca = rd.GetString(3),
                            Producto = rd.GetString(4),
                            Cantidad = rd.GetInt32(5),
                            Categoria = rd.GetString(6),
                            GuiaRemision = rd.IsDBNull(7) ? "-" : rd.GetString(7),
                            Remito = rd.IsDBNull(8) ? "-" : rd.GetString(8)
                        });
                    }
                }
            }
            return lista;
        }

        public List<FilaHistorial> ObtenerSalidas(int idProducto)
        {
            var lista = new List<FilaHistorial>();
            using (SqlConnection cn = Conexion.Crear())
            using (SqlCommand cmd = Conexion.Procedimiento(cn, "sp_Monitor_Salidas"))
            {
                cmd.Parameters.AddWithValue("@id_producto", idProducto);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        lista.Add(new FilaHistorial
                        {
                            Fecha = rd.GetDateTime(0),
                            Tipo = rd.GetString(1),
                            Cantidad = rd.GetInt32(2),
                            Detalle = rd.GetString(3)
                        });
                    }
                }
            }
            return lista;
        }
    }
}
