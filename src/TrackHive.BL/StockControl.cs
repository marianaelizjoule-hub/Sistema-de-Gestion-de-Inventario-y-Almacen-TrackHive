using System.Collections.Generic;
using TrackHive.DAC;
using TrackHive.Entidades;

namespace TrackHive.BL
{
    public class StockControl
    {
        private readonly StockRepositorio _stock = new StockRepositorio();

        public List<FilaStock> Consultar(int? idMarca, int? idCategoria)
        {
            return _stock.Consultar(idMarca, idCategoria);
        }
    }
}
