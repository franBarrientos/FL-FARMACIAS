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
    }
}
