using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FL_FARMACIAS.Aplicacion
{
    public class PedidosAplicacion
    {

        public List<pedidoDominio> ObtenerTodos()
        {
            using (var db = new DBConnect())
            {
                return db.Pedidos.Include(x => x.proveedor).Include(x => x.detalle).Include(x => x.farmaceutico).ToList();
            }
        }
    }
}
