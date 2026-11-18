using System.Data.SqlClient;
using TrackHive.Entidades;

namespace TrackHive.DAC
{
    public class UsuarioRepositorio
    {
        public Usuario ObtenerPorNombre(string nombreUsuario)
        {
            using (SqlConnection cn = Conexion.Crear())
            using (SqlCommand cmd = Conexion.Procedimiento(cn, "sp_Usuario_ObtenerPorNombre"))
            {
                cmd.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (!rd.Read()) return null;
                    return new Usuario
                    {
                        IdUsuario = rd.GetInt32(0),
                        NombreUsuario = rd.GetString(1),
                        NombreCompleto = rd.GetString(2),
                        Contrasena = rd.GetString(3),
                        Rol = rd.GetString(4)
                    };
                }
            }
        }

        public void ActualizarContrasena(int idUsuario, string nuevoHash)
        {
            using (SqlConnection cn = Conexion.Crear())
            using (SqlCommand cmd = Conexion.Procedimiento(cn, "sp_Usuario_ActualizarContrasena"))
            {
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                cmd.Parameters.AddWithValue("@contrasena", nuevoHash);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
