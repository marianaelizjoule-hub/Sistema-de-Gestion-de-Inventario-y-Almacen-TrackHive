using TrackHive.Entidades;

namespace TrackHive.BL
{
    public static class Sesion
    {
        public static Usuario Actual { get; set; }

        public static bool EsResponsable
        {
            get { return Actual != null && Actual.Rol == Roles.Responsable; }
        }

        public static void Cerrar()
        {
            Actual = null;
        }
    }
}
