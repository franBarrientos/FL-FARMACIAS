using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Aplicacion
{
    public class DescuentoAplicacion
    {

        public DescuentoAplicacion()
        {
        }

        public List<DescuentoDominio> ObtenerDescuentos()
        {   
            using (var db = new DBConnect()) { 
                return db.Descuento.ToList();
            }
        }

        //save new 
        public void AgregarDescuento(DescuentoDominio d)
        {
            using (var db = new DBConnect())
            {
                db.Descuento.Add(d);
                db.SaveChanges();
            }
        }


        public List<DescuentoDominio> BuscarDescuentos(int? id = null,
                                                         string descripcion = null,
                                                         bool? estado = null)
        {
            //haz un log
            Console.WriteLine("ID: " + id + ", Descripción: " + descripcion + ", Estado: " + estado);
            using (var db = new DBConnect())
            {
                return db.Descuento.Where(d =>
                (!id.HasValue || d.id == id) &&
                (string.IsNullOrEmpty(descripcion) || d.descripcion.Contains(descripcion)) &&  // Aquí está la corrección
                (!estado.HasValue || d.estado == estado))
                .ToList();
            }
        }
    }
}
