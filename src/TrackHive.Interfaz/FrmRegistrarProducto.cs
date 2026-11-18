using System;
using System.Windows.Forms;
using TrackHive.BL;
using TrackHive.Entidades;

namespace TrackHive.Interfaz
{
    public partial class FrmRegistrarProducto : Form
    {
        private readonly ProductoControl _productos = new ProductoControl();
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                Utilidades.LlenarMarcas(cboMarca, "Seleccione");
                Utilidades.LlenarTodasLasCategorias(cboCategoria, "Seleccione");
            }
            catch (Exception ex)
            {
                Mensajes.Mostrar(this, ex);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cboMarca.SelectedIndex = 0;
            cboCategoria.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria cat = cboCategoria.SelectedItem as Categoria;
                _productos.Registrar(txtNombre.Text, Utilidades.IdMarca(cboMarca), cat == null ? 0 : cat.IdCategoria);
                Mensajes.Info(this, "El producto se registró correctamente.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Mensajes.Mostrar(this, ex);
            }
        }
    }
}
