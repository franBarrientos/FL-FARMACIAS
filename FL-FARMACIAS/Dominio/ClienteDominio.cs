using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Dominio
{

    public class ClienteDominio
    {

        public int id { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public string dni { set; get; }
        public string telefono { set; get; }
        public bool activo { set; get; }
        public DescuentoDominio desc { set; get; }
        public int? idDescuento { set; get; }


        public ClienteDominio() { }
        public ClienteDominio(string nombre, string apellido, string dni, string telefono, bool activo, DescuentoDominio desc)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
            this.desc = desc;
            this.activo = activo;
            this.idDescuento = desc.id;
        }

        public ClienteDominio(int id, string nombre, string apellido, string dni, string telefono, bool activo, DescuentoDominio desc)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
            this.desc = desc;
            this.activo = activo;
            this.idDescuento = desc.id;
        }
    }
}
