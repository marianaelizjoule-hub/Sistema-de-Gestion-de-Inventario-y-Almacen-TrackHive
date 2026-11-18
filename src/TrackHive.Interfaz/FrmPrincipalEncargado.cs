using System;
using System.Windows.Forms;
using TrackHive.BL;

namespace TrackHive.Interfaz
{
    public partial class FrmPrincipalEncargado : Form
    {
        public FrmPrincipalEncargado()
        {
            InitializeComponent();
        }

        private void FrmPrincipalEncargado_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Sesion.Actual.NombreCompleto;
            lblRol.Text = Sesion.Actual.Rol;
            ucMonitor.TituloFicha = "Ficha Técnica e Historial";
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
                if (formulario.ShowDialog(this) == DialogResult.OK) ucMonitor.Recargar();
            }
        }

        private void Pendiente()
        {
            Mensajes.Info(this, "Esta función se implementará en el primer incremento funcional.");
        }

        private void btnRegistrarIngreso_Click(object sender, EventArgs e)
        {
            Pendiente();
        }

        private void btnSalidaEntrega_Click(object sender, EventArgs e)
        {
            Pendiente();
        }

        private void btnSalidaDesecho_Click(object sender, EventArgs e)
        {
            Pendiente();
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            Abrir(new FrmRegistrarProducto());
        }

        private void btnConsultarStock_Click(object sender, EventArgs e)
        {
            Abrir(new FrmConsultarProducto());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Program.VolverAlLogin = true;
            Sesion.Cerrar();
            Close();
        }
    }
}
