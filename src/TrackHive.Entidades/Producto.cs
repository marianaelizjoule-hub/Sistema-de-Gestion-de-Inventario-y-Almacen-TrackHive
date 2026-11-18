namespace TrackHive.Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
