using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Dominio
{
    public class MetodoPagoDominio
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public MetodoPagoDominio()
        {
        }
    }

    //agregado para los graficos
   

    public class VentaDetalleDominio
    {
        public int id_venta { get; set; }
        public VentaDominioDominio venta { get; set; }

        public int id_producto { get; set; }
        
        public ProductoDominio producto { get; set; }
        public decimal precio_unitario { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal => cantidad * precio_unitario; 

    }

    public class VentaDominioDominio
    {
        public int id_venta { get; set; }  // Clave primaria
        public DateTime fecha { get; set; }  // Fecha de la venta
        public decimal total { get; set; }  // Total de la venta

        public int id_cliente { get; set; }  // Clave Foranea
        public ClienteDominio cliente { get; set; }

        public int id_empleado { get; set; }  // Clave Foranea
        public Empleadodominio empleado { get; set; }

        public int id_metodo_pago { get; set; }  // Clave Foranea
        public MetodoPagoDominio metodoPago { get; set; }

        public int? id_descuento { get; set; }  // Clave Foranea
        public DescuentoDominio  descuento { get; set; } 

        public decimal porcentaje_descuento { get; set; }
        public List<VentaDetalleDominio> detalles { get; set; }

        public VentaDominioDominio()
        {
        }
    }
}
