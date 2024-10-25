using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Aplicacion
{
    public class PedidosDetalleDominio
    {
        public int Idpedido { get; set; }

        public pedidoDominio Pedido{ get; set; }

        public int Idproducto { get; set; }
        public ProductoDominio producto{ get; set; }
        public int cantidadPedido { get; set; }
}
    }
