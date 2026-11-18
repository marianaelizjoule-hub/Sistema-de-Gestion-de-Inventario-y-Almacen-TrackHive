using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackHive.BL;
using TrackHive.Entidades;

namespace TrackHive.Interfaz
{
    public partial class FrmConsultarProducto : Form
    {
        private readonly StockControl _stock = new StockControl();
        private readonly ProductoControl _productos = new ProductoControl();
        private bool _cargando;

        public FrmConsultarProducto()
        {
            InitializeComponent();
        }

        private void FrmConsultarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                _cargando = true;
                Utilidades.LlenarMarcas(cboMarca, "Seleccione");
                Utilidades.LlenarCategorias(cboCategoria, 0, "Todas las Categorías");
                Utilidades.LlenarProductos(cboProducto, 0, null, "Todos los Productos");
                _cargando = false;
            }
            catch (Exception ex)
            {
                _cargando = false;
                Mensajes.Mostrar(this, ex);
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargando) return;
            try
            {
                _cargando = true;
                int idMarca = Utilidades.IdMarca(cboMarca);
                Utilidades.LlenarCategorias(cboCategoria, idMarca, "Todas las Categorías");
                Utilidades.LlenarProductos(cboProducto, idMarca, null, "Todos los Productos");
            }
            catch (Exception ex) { Mensajes.Mostrar(this, ex); }
            finally { _cargando = false; }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargando) return;
            try
            {
                _cargando = true;
                Utilidades.LlenarProductos(cboProducto, Utilidades.IdMarca(cboMarca), Utilidades.IdCategoria(cboCategoria), "Todos los Productos");
            }
            catch (Exception ex) { Mensajes.Mostrar(this, ex); }
            finally { _cargando = false; }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                int idMarca = Utilidades.IdMarca(cboMarca);
                if (idMarca <= 0)
                {
                    Mensajes.Aviso(this, "Debe seleccionar una marca.");
                    return;
                }
                List<FilaStock> filas = _stock.Consultar(idMarca, Utilidades.IdCategoria(cboCategoria));

                Producto p = cboProducto.SelectedItem as Producto;
                if (p != null && p.IdProducto > 0)
                    filas = filas.FindAll(f => string.Equals(f.Producto, p.Nombre, StringComparison.OrdinalIgnoreCase));

                dgvStock.DataSource = filas;
                if (filas.Count == 0) Mensajes.Info(this, "No hay productos registrados para ese filtro.");
            }
            catch (Exception ex)
            {
                Mensajes.Mostrar(this, ex);
            }
        }
    }
}
