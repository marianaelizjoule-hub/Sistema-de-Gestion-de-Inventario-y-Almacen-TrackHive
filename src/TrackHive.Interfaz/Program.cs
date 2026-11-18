using System;
using System.Windows.Forms;
using TrackHive.BL;

namespace TrackHive.Interfaz
{
    internal static class Program
    {
        internal static bool VolverAlLogin;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                VolverAlLogin = false;
                using (var login = new FrmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK) break;
                }

                Form principal = Sesion.EsResponsable
                    ? (Form)new FrmPrincipalAdministrador()
                    : new FrmPrincipalEncargado();
                Application.Run(principal);

                if (!VolverAlLogin) break;
            }
        }
    }
}
