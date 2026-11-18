using System.Collections.Generic;
using System.Data.SqlClient;
using TrackHive.Entidades;

namespace TrackHive.DAC
{
    public class CategoriaRepositorio
    {
        public List<Categoria> ObtenerTodas()
        {
            return Leer("sp_Categoria_Listar", null);
        }

        public List<Categoria> ObtenerPorMarca(int idMarca)
        {
            return Leer("sp_Categoria_ListarPorMarca", idMarca);
        }

        private static List<Categoria> Leer(string procedimiento, int? idMarca)
        {
            var lista = new List<Categoria>();
            using (SqlConnection cn = Conexion.Crear())
            using (SqlCommand cmd = Conexion.Procedimiento(cn, procedimiento))
            {
                if (idMarca.HasValue) cmd.Parameters.AddWithValue("@id_marca", idMarca.Value);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                        lista.Add(new Categoria { IdCategoria = rd.GetInt32(0), NombreCategoria = rd.GetString(1) });
                }
            }
            return lista;
        }
    }
}
