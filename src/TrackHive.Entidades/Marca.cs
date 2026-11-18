using System;

namespace TrackHive.Entidades
{
    public class Marca
    {
        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }
        public int LimitePosiciones { get; set; }
        public int PosicionesOcupadas { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public int PosicionesDisponibles()
        {
            return LimitePosiciones - PosicionesOcupadas;
        }

        public bool SuperaLimite(int posicionesIngreso)
        {
            return PosicionesOcupadas + posicionesIngreso > LimitePosiciones;
        }

        public override string ToString()
        {
            return NombreMarca;
        }
    }
}
