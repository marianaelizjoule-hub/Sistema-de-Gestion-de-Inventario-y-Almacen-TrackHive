using System.Collections.Generic;
using System.Data.SqlClient;
using TrackHive.DAC;
using TrackHive.Entidades;

namespace TrackHive.BL
{
    public class ProductoControl
    {
        private readonly ProductoRepositorio _productos = new ProductoRepositorio();
        private readonly CategoriaRepositorio _categorias = new CategoriaRepositorio();

        public List<Categoria> ListarTodasLasCategorias()
        {
            return _categorias.ObtenerTodas();
        }

        public List<Categoria> ListarCategoriasDeMarca(int idMarca)
        {
            return _categorias.ObtenerPorMarca(idMarca);
        }

        public List<Producto> ListarProductos(int idMarca, int? idCategoria)
        {
            return _productos.ObtenerPorMarca(idMarca, idCategoria);
        }

        public int Registrar(string nombre, int idMarca, int idCategoria)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ValidacionException("Debe ingresar el nombre del producto.");
            if (idMarca <= 0) throw new ValidacionException("Debe seleccionar una marca.");
            if (idCategoria <= 0) throw new ValidacionException("Debe seleccionar una categoría.");

            var producto = new Producto
            {
                Nombre = nombre.Trim().ToUpperInvariant(),
                IdMarca = idMarca,
                IdCategoria = idCategoria
            };
            try
            {
                return _productos.Insertar(producto);
            }
            catch (SqlException ex)
            {
                if (ex.Number >= 50010 && ex.Number <= 50013) throw new ValidacionException(ex.Message);
                throw;
            }
        }
    }
}
