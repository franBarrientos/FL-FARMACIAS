using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Dominio
{
    public class CategoriaDominio
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }

        public CategoriaDominio(int id, string descp, bool estado)
        {
            this.id = id;
            this.descripcion = descp;
            this.estado = estado;
        }
    }
}
