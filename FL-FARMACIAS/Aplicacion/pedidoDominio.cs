using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Aplicacion
{
    public class pedidoDominio
    {

        public int Idpedido { get; set; }

        public date Fechapedido { get; set; }

        public bool Estado { get; set; }

        public int idfarmaceutico { get; set; } // clave foranea

        public Empleadodominio farmaceutico { get; set; } // objeto farmaceutico

        public int idadmin { get; set; } //clave foranea

        public Empleadodominio administrador { get; set; } //objeto admin

        public list<PedidosDetalleDominio> detalle { get; set; }// asocial el frame los detalles a pedido

    }
}
