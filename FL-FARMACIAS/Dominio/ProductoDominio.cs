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
        public int  idCategoria { get; set; }

        public MarcaDominio marca { get; set; }
        public int idMarca { get; set; }

        public LaboratorioDominio laboratorio { get; set; }
        public int? idLaboratorio { get; set; }

        public bool estado { get; set; }

        public ProductoDominio()
        { 
        }

        public ProductoDominio(string codProducto, string nombre, double precio, int stock, CategoriaDominio categoria, MarcaDominio marca, LaboratorioDominio laboratorio, bool estado)
        {
            this.codProducto = codProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.categoria = categoria; 
            this.idCategoria = categoria.id;
            this.marca = marca;
            this.idMarca = marca.id;
            this.laboratorio = laboratorio;
            if (laboratorio != null)
            {
                this.idLaboratorio = laboratorio.id;
            }
            this.estado = estado;
        }
        public ProductoDominio(int id, string codProducto, string nombre, double precio, int stock, CategoriaDominio categoria, MarcaDominio marca, LaboratorioDominio laboratorio, bool estado)
        {
            this.id = id;
            this.codProducto = codProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.categoria = categoria;
            this.idCategoria = categoria.id;
            this.marca = marca;
            this.idMarca = marca.id;
            this.laboratorio = laboratorio;
            this.idLaboratorio = laboratorio.id;
            this.estado = estado;
}


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

    public class MarcaDominio
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public MarcaDominio()
        {
        }

        public MarcaDominio(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }

    public class LaboratorioDominio
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public LaboratorioDominio()
        { }
        
        public LaboratorioDominio(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }

}
