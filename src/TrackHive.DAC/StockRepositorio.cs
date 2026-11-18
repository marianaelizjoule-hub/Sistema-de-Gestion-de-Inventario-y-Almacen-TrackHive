using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TrackHive.Entidades;

namespace TrackHive.DAC
{
    public class StockRepositorio
    {
        public List<FilaStock> Consultar(int? idMarca, int? idCategoria)
        {
            var lista = new List<FilaStock>();
            using (SqlConnection cn = Conexion.Crear())
            using (SqlCommand cmd = Conexion.Procedimiento(cn, "sp_Stock_Consultar"))
            {
                cmd.Parameters.Add("@id_marca", SqlDbType.Int).Value = idMarca.HasValue ? (object)idMarca.Value : DBNull.Value;
                cmd.Parameters.Add("@id_categoria", SqlDbType.Int).Value = idCategoria.HasValue ? (object)idCategoria.Value : DBNull.Value;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        lista.Add(new FilaStock
                        {
                            Marca = rd.GetString(0),
                            Categoria = rd.GetString(1),
                            Producto = rd.GetString(2),
                            Stock = Convert.ToInt32(rd.GetValue(3)),
                            UltimoMovimiento = rd.IsDBNull(4) ? (DateTime?)null : rd.GetDateTime(4)
                        });
                    }
                }
            }
            return lista;
        }
    }
}
