using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Aplicacion
{
    public  class ClienteAplicacion
    {
        private  DBConnect db;


        public ClienteAplicacion()
        {
            db = new DBConnect();
        }

        public List<ClienteDominio> ObtenerTodos()
        {
            return db.Cliente.ToList();
        }

    }
}
