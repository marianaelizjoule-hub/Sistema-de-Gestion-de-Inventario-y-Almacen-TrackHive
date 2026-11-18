using System;

namespace TrackHive.Entidades
{
    public class FilaMonitor
    {
        public int IdMovimiento { get; set; }
        public int IdProducto { get; set; }
        public DateTime Fecha { get; set; }
        public string Marca { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public string Categoria { get; set; }
        public string GuiaRemision { get; set; }
        public string Remito { get; set; }
    }
}
