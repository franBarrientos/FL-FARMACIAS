﻿using System;
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
         public UsuarioDominio() { }
        public int id { set; get; }
        public UsuarioDominio(int id, string usuario, string clave,  Rol rol)
        {
            this.id = id;
            this.usuario = usuario;
            this.clave = clave;
            this.rol = rol;
            this.rolId = rol.id;
        }

    }
}
