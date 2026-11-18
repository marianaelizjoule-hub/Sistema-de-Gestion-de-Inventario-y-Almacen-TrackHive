using System.Collections.Generic;
using TrackHive.DAC;
using TrackHive.Entidades;

namespace TrackHive.BL
{
    public class MarcaControl
    {
        private readonly MarcaRepositorio _repositorio = new MarcaRepositorio();

        public List<Marca> ListarMarcas()
        {
            return _repositorio.ObtenerTodas();
        }
    }
}
