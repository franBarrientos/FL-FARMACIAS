using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Dominio
{
    public class ProductoDominio
    {
        public int Id { get; set; }
        public string CodProducto { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public CategoriaDominio Categoria { get; set; }
        public bool Estado { get; set; }

        public ProductoDominio(int id, string codProducto, string nombre, double precio, int stock, CategoriaDominio categoria, bool estado)
        {
            Id = id;
            CodProducto = codProducto;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Categoria = categoria;
            Estado = estado;
        }
    }

}
