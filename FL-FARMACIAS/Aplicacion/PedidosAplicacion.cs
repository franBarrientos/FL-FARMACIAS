using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FL_FARMACIAS.Aplicacion
{
    public class PedidosAplicacion
    {
        public void RegistrarPedido(int proveedorId, int empleadoId, List<PedidosDetalleDominio> productosSeleccionados,string estado)
        {
            using (var context = new DBConnect())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Crear la venta
                        var nuevaPedido = new pedidoDominio
                        {
                            idproveedor = proveedorId,
                            idfarmaceutico = empleadoId,
                            Fechapedido = DateTime.Now,
                            Estado = estado,
                        };

                        context.Pedidos.Add(nuevaPedido);
                        context.SaveChanges();

                        var detallesPedido = new List<PedidosDetalleDominio>();
                        foreach (var item in productosSeleccionados)
                        {
                            var detalle = new PedidosDetalleDominio
                            {
                                Idpedido = nuevaPedido.Idpedido,
                                Idproducto = item.Idproducto,
                                cantidadPedido = item.cantidadPedido,
                            };
                            detallesPedido.Add(detalle);
                        }

                        context.PedidoDetalle.AddRange(detallesPedido);
                        context.SaveChanges();
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

        public void ModificarPedido(int proveedorId, int pedidoId, List<PedidosDetalleDominio> productosActualizados)
        {
            using (var context = new DBConnect())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Buscar el pedido existente
                        var pedidoExistente = context.Pedidos
                            .Include(p => p.detalle)
                            .FirstOrDefault(p => p.Idpedido == pedidoId);


                        // Actualizar los campos del pedido
                        pedidoExistente.idproveedor = proveedorId;

                        var cloneDetalles = pedidoExistente.detalle.ToList();

                        // Actualizar los detalles del pedido
                        foreach (var detalleExistente in cloneDetalles)
                        {
                            // Buscar si el detalle existente está en la lista de productos actualizados
                            var productoActualizado = productosActualizados.FirstOrDefault(p => p.Idproducto == detalleExistente.Idproducto);

                            if (productoActualizado != null)
                            {
                                // Si existe en la lista, actualizar la cantidad
                                detalleExistente.cantidadPedido = productoActualizado.cantidadPedido;

                                // Remover el producto actualizado de la lista para evitar procesarlo nuevamente
                                productosActualizados.Remove(productoActualizado);
                            }
                            else
                            {
                                // Si no está en la lista, significa que el producto se ha eliminado del pedido
                                context.PedidoDetalle.Remove(detalleExistente);
                            }
                        }

                        // Agregar nuevos productos que no estaban en el pedido original
                        foreach (var nuevoProducto in productosActualizados)
                        {
                            var nuevoDetalle = new PedidosDetalleDominio
                            {
                                Idpedido = pedidoExistente.Idpedido,
                                Idproducto = nuevoProducto.Idproducto,
                                cantidadPedido = nuevoProducto.cantidadPedido,
                            };
                            context.PedidoDetalle.Add(nuevoDetalle);
                        }

                        context.SaveChanges();
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



        public void ActualizarEstado(int id, string estado)
        {
            using (var db = new DBConnect())
            {
                var pedidoExistente = db.Pedidos.FirstOrDefault(x => x.Idpedido == id);
                if (pedidoExistente != null)
                {
                    pedidoExistente.Estado = estado;
                    db.SaveChanges();
                }
            }
        }

        public List<pedidoDominio> BuscarPedidos(int? cod_pedido = null, DateTime? desde = null, DateTime? hasta = null)
        {
            using (var db = new DBConnect())
            {
                return db.Pedidos
                    .Include(x => x.proveedor)
                     .Include(x => x.detalle.Select(d => d.producto.marca))        // Incluye la marca del producto
                    .Include(x => x.detalle.Select(d => d.producto.categoria))        // Incluye la marca del producto
                    .Include(x => x.detalle.Select(d => d.producto.laboratorio))  // Incluye el laboratorio del producto
                    .Include(x => x.detalle.Select(d => d.producto))
                    .Include(x => x.detalle)
                    .Include(x => x.farmaceutico)
                    .Where(x => (!cod_pedido.HasValue || x.Idpedido == cod_pedido) && (desde == null || x.Fechapedido >= desde) && (hasta == null || x.Fechapedido <= hasta))
                    .ToList();
            }
        }



        public List<pedidoDominio> ObtenerTodos()
        {
            using (var db = new DBConnect())
            {
                return db.Pedidos.Include(x => x.proveedor).Include(x => x.detalle).Include(x => x.farmaceutico).ToList();
            }
        }
    }
}
