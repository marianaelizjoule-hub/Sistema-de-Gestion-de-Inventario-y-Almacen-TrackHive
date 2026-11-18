using TrackHive.DAC;
using TrackHive.Entidades;

namespace TrackHive.BL
{
    public class AutenticacionControl
    {
        private readonly UsuarioRepositorio _repositorio = new UsuarioRepositorio();

        public Usuario IniciarSesion(string nombreUsuario, string password)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrEmpty(password)) return null;
            Usuario u = _repositorio.ObtenerPorNombre(nombreUsuario.Trim());
            if (u == null || !PasswordHasher.Verificar(password, u.Contrasena)) return null;

            if (PasswordHasher.EsProvisional(u.Contrasena))
            {
                u.Contrasena = PasswordHasher.Crear(password);
                _repositorio.ActualizarContrasena(u.IdUsuario, u.Contrasena);
            }

            Sesion.Actual = u;
            return u;
        }
    }
}
