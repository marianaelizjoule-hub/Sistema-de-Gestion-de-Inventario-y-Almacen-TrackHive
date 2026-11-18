using System;
using System.Windows.Forms;
using TrackHive.BL;

namespace TrackHive.Interfaz
{
    public partial class FrmPrincipalAdministrador : Form
    {
        public FrmPrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void FrmPrincipalAdministrador_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Sesion.Actual.NombreCompleto;
            lblRol.Text = "Administrador / " + Sesion.Actual.Rol;
            ucMonitor.TituloFicha = "Ficha Técnica y Detalle de Movimiento";
            ucMonitor.Recargar();
        }

        private void pnlAvatar_Paint(object sender, PaintEventArgs e)
        {
            Utilidades.DibujarAvatar(e.Graphics, pnlAvatar.Width, pnlAvatar.Height);
        }

        private void Abrir(Form formulario)
        {
            using (formulario)
            {
                formulario.ShowDialog(this);
            }
            ucMonitor.Recargar();
        }

        private void Pendiente()
        {
            Mensajes.Info(this, "Esta función se implementará en el primer incremento funcional.");
        }

        private void btnPosiciones_Click(object sender, EventArgs e)
        {
            Pendiente();
        }

        private void btnConsultarStock_Click(object sender, EventArgs e)
        {
            Abrir(new FrmConsultarProducto());
        }

        private void btnCentroReportes_Click(object sender, EventArgs e)
        {
            Pendiente();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Program.VolverAlLogin = true;
            Sesion.Cerrar();
            Close();
        }
    }
}
