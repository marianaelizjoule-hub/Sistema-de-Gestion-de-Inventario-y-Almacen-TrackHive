using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TrackHive.BL;
using TrackHive.Entidades;

namespace TrackHive.Interfaz
{
    internal static class Utilidades
    {
        public static void LlenarMarcas(ComboBox cbo, string primero)
        {
            List<Marca> lista = new MarcaControl().ListarMarcas();
            lista.Insert(0, new Marca { IdMarca = 0, NombreMarca = primero });
            cbo.DisplayMember = "NombreMarca";
            cbo.DataSource = lista;
        }

        public static void LlenarTodasLasCategorias(ComboBox cbo, string primero)
        {
            List<Categoria> lista = new ProductoControl().ListarTodasLasCategorias();
            lista.Insert(0, new Categoria { IdCategoria = 0, NombreCategoria = primero });
            cbo.DisplayMember = "NombreCategoria";
            cbo.DataSource = lista;
        }

        public static void LlenarCategorias(ComboBox cbo, int idMarca, string primero)
        {
            var lista = new List<Categoria>();
            if (idMarca > 0) lista = new ProductoControl().ListarCategoriasDeMarca(idMarca);
            lista.Insert(0, new Categoria { IdCategoria = 0, NombreCategoria = primero });
            cbo.DisplayMember = "NombreCategoria";
            cbo.DataSource = lista;
        }

        public static void LlenarProductos(ComboBox cbo, int idMarca, int? idCategoria, string primero)
        {
            var lista = new List<Producto>();
            if (idMarca > 0) lista = new ProductoControl().ListarProductos(idMarca, idCategoria);
            lista.Insert(0, new Producto { IdProducto = 0, Nombre = primero });
            cbo.DisplayMember = "Nombre";
            cbo.DataSource = lista;
        }

        public static int IdMarca(ComboBox cbo)
        {
            Marca m = cbo.SelectedItem as Marca;
            return m == null ? 0 : m.IdMarca;
        }

        public static int? IdCategoria(ComboBox cbo)
        {
            Categoria c = cbo.SelectedItem as Categoria;
            return (c == null || c.IdCategoria <= 0) ? (int?)null : c.IdCategoria;
        }

        public static void DibujarAvatar(Graphics g, int ancho, int alto)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var fondo = new SolidBrush(Color.FromArgb(168, 172, 182)))
            using (var figura = new SolidBrush(Color.FromArgb(88, 96, 122)))
            {
                g.FillEllipse(fondo, 0, 0, ancho - 1, alto - 1);
                g.FillEllipse(figura, ancho / 2 - 10, 11, 20, 20);
                g.SetClip(new Rectangle(0, 0, ancho, alto));
                g.FillEllipse(figura, ancho / 2 - 18, 34, 36, 36);
            }
        }
    }
}
