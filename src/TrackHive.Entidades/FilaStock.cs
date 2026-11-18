using System;

namespace TrackHive.Entidades
{
    public class FilaStock
    {
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Producto { get; set; }
        public int Stock { get; set; }
        public DateTime? UltimoMovimiento { get; set; }
    }
}
