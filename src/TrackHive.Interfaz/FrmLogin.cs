using System;
using System.Windows.Forms;
using TrackHive.BL;

namespace TrackHive.Interfaz
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            try
            {
                var control = new AutenticacionControl();
                if (control.IniciarSesion(txtUsuario.Text, txtClave.Text) == null)
                {
                    lblError.Text = "Usuario o contraseña incorrectos.";
                    txtClave.Clear();
                    txtClave.Focus();
                    return;
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                lblError.Text = "No se pudo conectar con la base de datos: " + ex.Message;
            }
        }
    }
}
