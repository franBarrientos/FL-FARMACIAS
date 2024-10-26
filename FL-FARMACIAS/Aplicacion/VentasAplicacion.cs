using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FL_FARMACIAS.Aplicacion
{
    public class VentasAplicacion
    {

        public List<MetodoPagoDominio> ObtenerMetodosPagos()
        {

            using (var db = new DBConnect())
            {
                return db.MetodoPago.ToList();
            }
        }

        public List<VentaDominioDominio> ObtenerVentasPorEmpleado(int id)
        {   
            using (var db = new DBConnect()) {
                return db.Ventas.Include(x => x.detalles).Include(x => x.metodoPago).Include(x => x.descuento).Include(x => x.cliente).Where(x => x.id_empleado == id).ToList();
            }

        }

        public List<VentaDominioDominio> ObtenerVentasPorEmpleadoAndFiltros(int? id, string dni, int? cod_factura, DateTime? desde, DateTime? hasta)
        {
            using (var db = new DBConnect()) {
                return db.Ventas
                    .Include(x => x.detalles) // Incluyendo detalles y sus productos
                    .Include(x => x.metodoPago).Include(x => x.descuento).Include(x => x.cliente)
                    .Where(x =>
                    (id == null || x.id_empleado == id) &&
                    (string.IsNullOrEmpty(dni) || x.cliente.dni == dni) &&
                    (cod_factura == null || x.id_venta == cod_factura) &&
                    (desde == null || x.fecha >= desde) &&
                    (hasta == null || x.fecha <= hasta)
                    )
                .ToList();
            }
        }
        public int ObtenerMetodoPagoId(string nombre)
        {

            using (var db = new DBConnect())
            {
                return db.MetodoPago.First(m => m.descripcion == nombre).id;
            }
        }
        public void RegistrarVenta(int clienteId, int empleadoId, int metodoPagoId,
            int? descuentoId, double porcentaje_descuento, List<VentaDetalleDominio> productosSeleccionados)
        {
            using (var context = new DBConnect())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Crear la venta
                        var nuevaVenta = new VentaDominioDominio
                        {
                            id_cliente = clienteId,
                            id_empleado = empleadoId,
                            id_metodo_pago = metodoPagoId,
                            id_descuento = descuentoId,
                            porcentaje_descuento = (decimal)porcentaje_descuento,
                            fecha = DateTime.Now,
                            total = 0
                        };

                        context.Ventas.Add(nuevaVenta);
                        context.SaveChanges(); 

                        var detallesVenta = new List<VentaDetalleDominio>();
                        foreach (var item in productosSeleccionados)
                        {
                            var detalle = new VentaDetalleDominio
                            {
                                id_venta = nuevaVenta.id_venta,
                                id_producto = item.id_producto,
                                cantidad = item.cantidad,
                                precio_unitario = item.precio_unitario,
                            };
                            detallesVenta.Add(detalle);
                        }

                        context.VentasDetalles.AddRange(detallesVenta);

                        // Actualizar el total de la venta
                        nuevaVenta.total = detallesVenta.Sum(d => d.precio_unitario * d.cantidad);
                        context.SaveChanges();

                        // Commit transaction
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }



        public VentaDominioDominio ObtenerVentaPorId(int id)
        {
            using (var db = new DBConnect()) {
                return db.Ventas
                    .Include(x => x.detalles.Select(d => d.producto.marca))        // Incluye la marca del producto
                    .Include(x => x.detalles.Select(d => d.producto.categoria))        // Incluye la marca del producto
                    .Include(x => x.detalles.Select(d => d.producto.laboratorio))  // Incluye el laboratorio del producto
                    .Include(x => x.detalles.Select(d => d.producto))
                    .Include(x => x.metodoPago).Include(x => x.descuento).Include(x => x.cliente).FirstOrDefault(x => x.id_venta == id);
            }
        }


    }
}
