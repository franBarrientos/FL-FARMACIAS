using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Dominio
{
    public class ProductoDominio
    {
        public int id { get; set; }
        public string codProducto { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
        public CategoriaDominio categoria { get; set; }
        public bool estado { get; set; }

        public ProductoDominio(int id, string codProducto, string nombre, double precio, int stock, CategoriaDominio categoria, bool estado)
        {
            this.id = id;
            this.codProducto = codProducto;
            this.nombre = nombre;         
            this.precio = precio;
            this.stock = stock;
            this.categoria = categoria;
            this.estado = estado;
        }
    }

}
