using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TrackHive.Entidades;

namespace TrackHive.DAC
{
    public class ProductoRepositorio
    {
        public List<Producto> ObtenerPorMarca(int idMarca, int? idCategoria)
        {
            var lista = new List<Producto>();
            using (SqlConnection cn = Conexion.Crear())
            using (SqlCommand cmd = Conexion.Procedimiento(cn, "sp_Producto_ListarPorMarca"))
            {
                cmd.Parameters.AddWithValue("@id_marca", idMarca);
                cmd.Parameters.Add("@id_categoria", SqlDbType.Int).Value = idCategoria.HasValue ? (object)idCategoria.Value : DBNull.Value;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        lista.Add(new Producto
                        {
                            IdProducto = rd.GetInt32(0),
                            Nombre = rd.GetString(1),
                            IdMarca = rd.GetInt32(2),
                            IdCategoria = rd.GetInt32(3),
                            Categoria = rd.GetString(4)
                        });
                    }
                }
            }
            return lista;
        }

        public int Insertar(Producto producto)
        {
            using (SqlConnection cn = Conexion.Crear())
            using (SqlCommand cmd = Conexion.Procedimiento(cn, "sp_Producto_Insertar"))
            {
                cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@id_marca", producto.IdMarca);
                cmd.Parameters.AddWithValue("@id_categoria", producto.IdCategoria);
                SqlParameter salida = cmd.Parameters.Add("@id_producto", SqlDbType.Int);
                salida.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(salida.Value);
            }
        }
    }
}
