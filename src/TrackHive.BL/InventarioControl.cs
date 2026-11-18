using System.Collections.Generic;
using TrackHive.DAC;
using TrackHive.Entidades;

namespace TrackHive.BL
{
    public class InventarioControl
    {
        private readonly MonitorRepositorio _monitor = new MonitorRepositorio();

        public List<FilaMonitor> ObtenerMonitor()
        {
            return _monitor.ObtenerIngresos();
        }

        public List<FilaHistorial> ObtenerHistorial(int idProducto)
        {
            return _monitor.ObtenerSalidas(idProducto);
        }
    }
}
