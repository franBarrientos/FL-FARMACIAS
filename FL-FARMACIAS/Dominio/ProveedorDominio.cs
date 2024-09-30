using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Dominio
{
    internal class ProveedorDominio
    {
        public int id { set; get; }
        public string nombre { set; get; }
        public string cuit { set; get; }
        public string provincia { set; get; }
        public string localidad { set; get; }
        public string direccion { set; get; }
        public string correo { set; get; }
        public string telefono { set; get; }

        public ProveedorDominio(int id, string nombre, string cuit, string provincia, string localidad, string direccion, string correo, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.cuit = cuit;
            this.provincia = provincia;
            this.localidad = localidad;
            this.direccion = direccion;
            this.correo = correo;
            this.telefono = telefono;
        }
    }
}

