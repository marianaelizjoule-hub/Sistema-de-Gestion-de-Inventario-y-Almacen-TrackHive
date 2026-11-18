using System;

namespace TrackHive.Entidades
{
    public class FilaHistorial
    {
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public string Detalle { get; set; }
    }
}
