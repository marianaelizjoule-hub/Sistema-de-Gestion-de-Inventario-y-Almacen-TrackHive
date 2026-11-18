using System;
using System.Windows.Forms;
using TrackHive.BL;

namespace TrackHive.Interfaz
{
    internal static class Mensajes
    {
        private const string Titulo = "TrackHive";

        public static void Info(IWin32Window owner, string texto)
        {
            MessageBox.Show(owner, texto, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Aviso(IWin32Window owner, string texto)
        {
            MessageBox.Show(owner, texto, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Mostrar(IWin32Window owner, Exception ex)
        {
            if (ex is ValidacionException)
            {
                Aviso(owner, ex.Message);
                return;
            }
            MessageBox.Show(owner, "Ocurrió un error: " + ex.Message, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
