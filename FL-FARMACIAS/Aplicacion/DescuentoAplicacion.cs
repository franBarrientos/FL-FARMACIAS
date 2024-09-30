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

        public void ActualizarDescuento(DescuentoDominio d)
        {
            using (var db = new DBConnect())
            {
                // Buscar el descuento existente por su ID
                var descuentoExistente = db.Descuento.FirstOrDefault(x => x.id == d.id);

                if (descuentoExistente != null)
                {
                    // Actualizar los valores de la entidad existente
                    descuentoExistente.descripcion = d.descripcion;
                    descuentoExistente.porcentajeDescuento = d.porcentajeDescuento;
                    descuentoExistente.estado = d.estado;

                    // Guardar los cambios en la base de datos
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Descuento no encontrado.");
                }
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

        public DescuentoDominio ObtenerDescuentoPorDescripcion(string d)
        {
            using (var db = new DBConnect())
            {
                return db.Descuento.FirstOrDefault(x => x.descripcion == d || x.descripcion.Contains(d));
            }
        }
    }
}
