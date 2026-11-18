using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrackHive.BL;
using TrackHive.Entidades;

namespace TrackHive.Interfaz
{
    public partial class UcMonitorInventario : UserControl
    {
        private enum Orden { Id, AZ, Reciente }

        private readonly InventarioControl _inventario = new InventarioControl();
        private List<FilaMonitor> _todas = new List<FilaMonitor>();
        private Orden _orden = Orden.Id;

        public UcMonitorInventario()
        {
            InitializeComponent();
        }

        public string TituloFicha
        {
            get { return lblFicha.Text; }
            set { lblFicha.Text = value; }
        }

        public void Recargar()
        {
            try
            {
                _todas = _inventario.ObtenerMonitor();
                Mostrar();
            }
            catch (Exception ex)
            {
                Mensajes.Mostrar(this, ex);
            }
        }

        private void Mostrar()
        {
            string t = (txtBuscar.Text ?? string.Empty).Trim().ToLowerInvariant();
            IEnumerable<FilaMonitor> q = _todas.Where(f => t.Length == 0 || f.Producto.ToLowerInvariant().Contains(t));
            switch (_orden)
            {
                case Orden.Id: q = q.OrderBy(f => f.IdMovimiento); break;
                case Orden.AZ: q = q.OrderBy(f => f.Producto); break;
                default: q = q.OrderByDescending(f => f.Fecha).ThenByDescending(f => f.IdMovimiento); break;
            }
            dgvMonitor.DataSource = q.ToList();
            MostrarFicha();
        }

        private void MostrarFicha()
        {
            FilaMonitor f = dgvMonitor.CurrentRow == null ? null : dgvMonitor.CurrentRow.DataBoundItem as FilaMonitor;
            if (f == null)
            {
                txtFicha.Text = "Seleccione un movimiento para ver su ficha técnica.";
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine("-- FICHA TECNICA --");
            sb.AppendLine("FECHA: " + f.Fecha.ToString("dd/MM/yyyy") + " |  MARCA: " + f.Marca.ToUpperInvariant() +
                          " |  NOMBRE PRODUCTO: " + f.Producto.ToUpperInvariant() + " |  CANTIDAD: " + f.Cantidad +
                          " |  CATEGORIA: " + f.Categoria.ToUpperInvariant() + " |  GUIA REMISION: " + f.GuiaRemision + " |  REMITO: " + f.Remito);
            sb.AppendLine();
            sb.AppendLine("-- HISTORIAL --");
            try
            {
                List<FilaHistorial> salidas = _inventario.ObtenerHistorial(f.IdProducto);
                if (salidas.Count == 0) sb.AppendLine("SIN MOVIMIENTOS REGISTRADOS");
                foreach (FilaHistorial h in salidas)
                    sb.AppendLine(h.Fecha.ToString("dd/MM/yyyy") + " - " + h.Tipo.ToUpperInvariant() + " - " + h.Cantidad + " UNIDADES - " + h.Detalle);
            }
            catch (Exception ex)
            {
                sb.AppendLine("No se pudo cargar el historial: " + ex.Message);
            }
            txtFicha.Text = sb.ToString();
        }

        private void dgvMonitor_SelectionChanged(object sender, EventArgs e)
        {
            MostrarFicha();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnOrdenId_Click(object sender, EventArgs e)
        {
            _orden = Orden.Id;
            Mostrar();
        }

        private void btnOrdenAZ_Click(object sender, EventArgs e)
        {
            _orden = Orden.AZ;
            Mostrar();
        }

        private void btnOrdenReciente_Click(object sender, EventArgs e)
        {
            _orden = Orden.Reciente;
            Mostrar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Recargar();
        }
    }
}
