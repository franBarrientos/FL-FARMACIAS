using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Dominio
{
    public enum Rol
    {
        Supervisor,
        Farmaceutico,
        Admin
    }

    internal class UsuarioDominio
    {
        public string usuario { set; get; }
        public string clave { set; get; }
        public bool activo { set; get; }
        public Rol rol { set; get; }


        public UsuarioDominio(string usuario, string clave,  Rol rol)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.rol = rol;
        }

    }
}
