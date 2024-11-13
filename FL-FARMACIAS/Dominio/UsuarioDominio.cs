using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Dominio
{
    public class Rol
    {
      public int id { set; get; }
     public String descripcion { set; get; }

        public Rol() { }
        public Rol(int id , string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }
    }

    public class UsuarioDominio
    {
       
        public string usuario { set; get; }
        public string clave { set; get; }
        public bool activo { set; get; }
        public Rol rol { set; get; }

        public int rolId { set; get; }
        public int id { set; get; }

        public Empleadodominio empleado { set; get; }
        public UsuarioDominio() { }

        public UsuarioDominio(string usuario, string clave, Rol rol)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.rol = rol;
            this.rolId = rol.id;
            this.activo = true;
        }
        public UsuarioDominio(int id, string usuario, string clave,  Rol rol)
        {
            this.id = id;
            this.usuario = usuario;
            this.clave = clave;
            this.rol = rol;
            this.rolId = rol.id;
        }
        public override string ToString()
        {
            return $"Usuario: {usuario}, Clave: {clave}, Activo: {activo}" + (rol != null ? $"rol ID: {rol.id}" : "No hay rol") + ", ID: {id}" +
                   (empleado != null ? $", Empleado ID: {empleado.id}" : ", No hay empleado asociado.");
        }

    }
}
