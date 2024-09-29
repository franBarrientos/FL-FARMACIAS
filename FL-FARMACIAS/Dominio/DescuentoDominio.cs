using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Dominio
{
    public class DescuentoDominio
    {
        public int? id { get; set; }
        public string descripcion { get; set; }
        public double porcentajeDescuento { get; set; }
        public bool estado { get; set; }

        public DescuentoDominio() { }


        public DescuentoDominio(int id, string descp, double porcentajeDescuento, bool estado)
        {
            this.id = id;
            this.descripcion = descp;
            this.porcentajeDescuento = porcentajeDescuento;
            this.estado = estado;
        }

        public DescuentoDominio(string descp, double porcentajeDescuento, bool estado)
        {
            this.descripcion = descp;
            this.porcentajeDescuento = porcentajeDescuento;
            this.estado = estado;
        }
    }
}
