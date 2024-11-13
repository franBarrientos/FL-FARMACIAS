using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Documents;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.Globalization;

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
                        var totalWoD = detallesVenta.Sum(d => d.precio_unitario * d.cantidad);
                        var totalWD = totalWoD - (totalWoD * nuevaVenta.porcentaje_descuento / 100);
                        nuevaVenta.total = totalWD;
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

        public void GenerarFacturaPDF(VentaDominioDominio venta)
        {
            var detallesVenta = venta.detalles;
            // Usar SaveFileDialog para seleccionar ubicación y nombre del archivo
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar Factura";
                saveFileDialog.FileName = $"Factura_{venta.id_venta}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta seleccionada por el usuario
                    string filePath = saveFileDialog.FileName;

                    // Crear el documento PDF
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                    doc.Open();

                    Font fontEncabezado = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
                    iTextSharp.text.Paragraph encabezado = new iTextSharp.text.Paragraph("FL RED FARMACEUTICA", fontEncabezado)
                    {
                        Alignment = Element.ALIGN_CENTER // Centrar el encabezado
                    };
                    doc.Add(encabezado);

                    // Agregar un salto de línea debajo del encabezado
                    doc.Add(new iTextSharp.text.Paragraph("\n"));

                    // Definir fuentes para diferentes secciones
                    Font fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.BLACK);
                    Font fontSeccion = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);
                    Font fontContenido = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);

                    // Título centrado
                    doc.Add(new iTextSharp.text.Paragraph("Factura", fontTitulo) { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new iTextSharp.text.Paragraph("\n")); // Salto de línea

                    // Recuadro para Datos del Cliente
                    PdfPTable clienteTable = new PdfPTable(1);
                    clienteTable.WidthPercentage = 100;
                    PdfPCell clienteCell = new PdfPCell(new Phrase("Datos del Cliente", fontSeccion))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY,
                        Padding = 5,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    clienteTable.AddCell(clienteCell);

                    clienteTable.AddCell(new PdfPCell(new Phrase($"Cliente ID: {venta.id_cliente}", fontContenido)) { Border = 0 });
                    clienteTable.AddCell(new PdfPCell(new Phrase($"Nombre Cliente: {venta.cliente.apellido} {venta.cliente.nombre}", fontContenido)) { Border = 0 });
                    clienteTable.AddCell(new PdfPCell(new Phrase($"Dni Cliente: {(venta.cliente.id != 4 ? venta.cliente.dni : "Ninguno")}", fontContenido)) { Border = 0 });
                    clienteTable.SpacingAfter = 10f; // Espacio debajo del recuadro
                    doc.Add(clienteTable);

                    // Recuadro para Datos del Farmacéutico
                    PdfPTable farmaceuticoTable = new PdfPTable(1);
                    farmaceuticoTable.WidthPercentage = 100;
                    PdfPCell farmaceuticoCell = new PdfPCell(new Phrase("Datos del Farmacéutico", fontSeccion))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY,
                        Padding = 5,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    farmaceuticoTable.AddCell(farmaceuticoCell);

                    farmaceuticoTable.AddCell(new PdfPCell(new Phrase($"Farmacéutico ID: {venta.id_empleado}", fontContenido)) { Border = 0 });
                    farmaceuticoTable.AddCell(new PdfPCell(new Phrase($"Nombre Farmacéutico: {venta.empleado.nombre} {venta.empleado.apellido}", fontContenido)) { Border = 0 });
                    farmaceuticoTable.AddCell(new PdfPCell(new Phrase($"Dni Farmacéutico: {venta.empleado.dni}", fontContenido)) { Border = 0 });
                    farmaceuticoTable.SpacingAfter = 10f;
                    doc.Add(farmaceuticoTable);

                    // Recuadro para Detalles de la Venta
                    PdfPTable ventaTable = new PdfPTable(1);
                    ventaTable.WidthPercentage = 100;
                    PdfPCell ventaCell = new PdfPCell(new Phrase("Detalles de la Venta", fontSeccion))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY,
                        Padding = 5,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    ventaTable.AddCell(ventaCell);

                    ventaTable.AddCell(new PdfPCell(new Phrase($"Método de Pago: {venta.metodoPago.descripcion}", fontContenido)) { Border = 0 });
                    ventaTable.AddCell(new PdfPCell(new Phrase($"Descuento ID: {(venta.descuento == null ? "Ninguno" : venta.descuento.id.ToString())}", fontContenido)) { Border = 0 });
                    ventaTable.AddCell(new PdfPCell(new Phrase($"Nombre Descuento: {(venta.descuento == null ? "Ninguno" : venta.descuento.descripcion)}", fontContenido)) { Border = 0 });
                    ventaTable.AddCell(new PdfPCell(new Phrase($"Descuento: {venta.porcentaje_descuento}%", fontContenido)) { Border = 0 });
                    ventaTable.SpacingAfter = 10f;
                    doc.Add(ventaTable);

                    // Tabla para los detalles de la venta
                    PdfPTable table = new PdfPTable(7);
                    float[] widths = new float[] { 15f, 17f, 15f, 17f, 11f, 12.5f, 12.5f };
                    table.WidthPercentage = 95; // Establece el ancho de la tabla al 95% de la página
                    table.SetWidths(widths);

                    table.AddCell("Producto ID");
                    table.AddCell("Descripcion   ");
                    table.AddCell("Marca");
                    table.AddCell("Laboratorio  ");
                    table.AddCell("Cantidad");
                    table.AddCell("Precio Unitario");
                    table.AddCell("Subtotal");

                    foreach (var detalle in detallesVenta)
                    {
                        table.AddCell(detalle.id_producto.ToString());
                        table.AddCell(detalle.producto.nombre);
                        table.AddCell(detalle.producto.marca.nombre);
                        table.AddCell((detalle.producto.laboratorio == null? "Ninguno" : detalle.producto.laboratorio.nombre));
                        table.AddCell(detalle.cantidad.ToString());
                        table.AddCell(detalle.precio_unitario.ToString("C", CultureInfo.GetCultureInfo("es-AR")));
                        table.AddCell((detalle.cantidad * detalle.precio_unitario).ToString("C", CultureInfo.GetCultureInfo("es-AR")));
                    }

                    doc.Add(table);

                    // Total
                    doc.Add(new iTextSharp.text.Paragraph("\n"));
                    doc.Add(new iTextSharp.text.Paragraph($"Total: {venta.total.ToString("C", CultureInfo.GetCultureInfo("es-AR"))}", fontTitulo) { Alignment = Element.ALIGN_CENTER });

                    // Cerrar el documento
                    doc.Close();

                    // Abrir el PDF después de generarlo
                    System.Diagnostics.Process.Start(filePath);
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
                    .Include(x => x.metodoPago)
                    .Include(x => x.descuento)
                    .Include(x => x.cliente)
                    .Include(x => x.empleado)
                    .FirstOrDefault(x => x.id_venta == id);
            }
        }


        //agregado para los graficos
        public List<(string empleadoNombre, int cantidadProductos)> ObtenerCantidadProductosVendidosPorEmpleado(DateTime? desde = null, DateTime? hasta = null)
        {
            using (var db = new DBConnect())
            {

                var query = db.Ventas
                 .Include(v => v.detalles)
                 .Include(v => v.empleado)
                 .AsQueryable();

                if (desde.HasValue)
                {
                    query = query.Where(v => v.fecha >= desde.Value);
                }

                if (hasta.HasValue)
                {
                    query = query.Where(v => v.fecha <= hasta.Value);
                }

                var result = query
                    .GroupBy(v => v.empleado.nombre + " " + v.empleado.apellido)
                    .Select(g => new
                    {
                        empleadoNombre = g.Key,
                        cantidadProductos = g.Sum(v => v.detalles.Sum(d => d.cantidad))
                    })
                    .ToList();


                // Depuración
                if (result.Count == 0)
                {
                    Console.WriteLine("No se encontraron ventas.");
                }
                else
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine($"Empleado: {item.empleadoNombre}, Cantidad: {item.cantidadProductos}");
                    }
                }

                return result.Select(x => (x.empleadoNombre, x.cantidadProductos)).ToList();
            }
        }

        //segundo grafico 
        public Dictionary<string, decimal> ObtenerIngresosPorEmpleado(DateTime desde, DateTime hasta)
        {
            using (var db = new DBConnect())
            {
                var ingresosPorEmpleado = db.Ventas
                    .Include(v => v.empleado)
                    .Where(v => v.fecha >= desde && v.fecha <= hasta)
                    .GroupBy(v => v.empleado.nombre)
                    .Select(g => new
                    {
                        Empleado = g.Key,
                        TotalIngresos = g.Sum(v => v.total)
                    })
                    .ToDictionary(x => x.Empleado, x => x.TotalIngresos);

                return ingresosPorEmpleado;
            }
        }
        // grafico de torta
        public List<(string EmpleadoNombre, decimal TotalVentas)> ObtenerTopEmpleadosPorVentas(int topN, DateTime? desde = null, DateTime? hasta = null)
        {
            using (var db = new DBConnect())
            {

                 var query = db.Ventas
                    .Include(v => v.empleado)
                     .AsQueryable();

                    if (desde.HasValue)
                    {
                        query = query.Where(v => v.fecha >= desde.Value);
                    }

                    if (hasta.HasValue)
                    {
                        query = query.Where(v => v.fecha <= hasta.Value);
                    }

                return query.GroupBy(v => v.empleado.nombre)
                    .Select(g => new
                    {
                        EmpleadoNombre = g.Key,
                        TotalVentas = g.Sum(v => v.total)
                    })
                    .OrderByDescending(x => x.TotalVentas)
                    .Take(topN)
                    .ToList()
                    .Select(x => (x.EmpleadoNombre, x.TotalVentas))
                    .ToList();
            }
        }

        //public Dictionary<string, int> ObtenerCantidadVendidaPorProducto(DateTime? desde = null, DateTime? hasta = null)
        //{
            //using (var db = new DBConnect())
            //{
                //return db.VentasDetalles
                //    .Include(d => d.producto)
              //      .GroupBy(d => d.producto.nombre)
            //        .ToDictionary(g => g.Key, g => g.Sum(d => d.cantidad));
          //  }
        //}
        //graficos del ADMIN
        public Dictionary<string, int> ObtenerCantidadVendidaPorProducto(DateTime? desde = null, DateTime? hasta = null)
        {
            using (var db = new DBConnect())
            {
                // Start building the query with VentasDetalles
                var query = db.VentasDetalles
                    .Include(d => d.producto)
                    .AsQueryable();

                // Apply date filters if provided
                if (desde.HasValue)
                {
                    query = query.Where(d => d.venta.fecha >= desde.Value);
                }

                if (hasta.HasValue)
                {
                    query = query.Where(d => d.venta.fecha <= hasta.Value);
                }

                // Group by product name and calculate the total quantity sold
                var result = query
                    .GroupBy(d => d.producto.nombre)
                    .ToDictionary(g => g.Key, g => g.Sum(d => d.cantidad));

                // Debugging output
                if (!result.Any())
                {
                    Console.WriteLine("No se encontraron ventas.");
                }
                else
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine($"Producto: {item.Key}, Cantidad: {item.Value}");
                    }
                }

                return result;
            }
        }


        // segundo grafico admin
        //public Dictionary<string, decimal> ObtenerIngresosPorProducto(DateTime? desde = null, DateTime? hasta = null)
        //{
        //  using (var db = new DBConnect())
        //{
        //  return db.VentasDetalles
        //    .Include(d => d.producto)
        //  .GroupBy(d => d.producto.nombre)
        //.ToDictionary(g => g.Key, g => g.Sum(d => d.precio_unitario * d.cantidad));
        //}
        //}

        public Dictionary<string, decimal> ObtenerIngresosPorProducto(DateTime? desde = null, DateTime? hasta = null)
        {
            using (var db = new DBConnect())
            {
                // Start building the query with VentasDetalles
                var query = db.VentasDetalles
                    .Include(d => d.producto)
                    .AsQueryable();

                // Apply date filters if provided
                if (desde.HasValue)
                {
                    query = query.Where(d => d.venta.fecha >= desde.Value);
                }

                if (hasta.HasValue)
                {
                    query = query.Where(d => d.venta.fecha <= hasta.Value);
                }

                // Group by product name and calculate total income
                var result = query
                    .GroupBy(d => d.producto.nombre)
                    .ToDictionary(g => g.Key, g => g.Sum(d => d.precio_unitario * d.cantidad));

                // Debugging output
                if (!result.Any())
                {
                    Console.WriteLine("No se encontraron ventas.");
                }
                else
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine($"Producto: {item.Key}, Ingresos: {item.Value:C}"); // Format as currency
                    }
                }

                return result;
            }
        }


        //grafico torta admin
        //  public List<(string NombreProducto, int Cantidad)> ObtenerTopProductosVendidos(int topN, DateTime? desde = null, DateTime? hasta = null)
        //{
        //using (var db = new DBConnect())
        // {
        // return db.VentasDetalles
        // .Include(d => d.producto)
        // .GroupBy(d => d.producto.nombre)
        // .Select(g => new
        //  {
        //       NombreProducto = g.Key,
        //      Cantidad = g.Sum(d => d.cantidad)
        //    })
        // .OrderByDescending(x => x.Cantidad)
        //   .Take(topN)
        //     .AsEnumerable() // Para materializar la consulta antes de convertir a lista
        //       .Select(x => (x.NombreProducto, x.Cantidad))
        //         .ToList();
        //   }
        // }

        public List<(string NombreProducto, int Cantidad)> ObtenerTopProductosVendidos(int topN, DateTime? desde = null, DateTime? hasta = null)
        {
            using (var db = new DBConnect())
            {
                // Start building the query with VentasDetalles
                var query = db.VentasDetalles
                    .Include(d => d.producto)
                    .AsQueryable();

                // Apply date filters if provided
                if (desde.HasValue)
                {
                    query = query.Where(d => d.venta.fecha >= desde.Value);
                }

                if (hasta.HasValue)
                {
                    query = query.Where(d => d.venta.fecha <= hasta.Value);
                }

                // Group by product name, calculate total quantity, and order by quantity
                var result = query
                    .GroupBy(d => d.producto.nombre)
                    .Select(g => new
                    {
                        NombreProducto = g.Key,
                        Cantidad = g.Sum(d => d.cantidad)
                    })
                    .OrderByDescending(x => x.Cantidad)
                    .Take(topN)
                    .AsEnumerable() // Materialize the query
                    .Select(x => (x.NombreProducto, x.Cantidad))
                    .ToList();

                // Debugging output
                if (!result.Any())
                {
                    Console.WriteLine("No se encontraron productos vendidos.");
                }
                else
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine($"Producto: {item.NombreProducto}, Cantidad: {item.Cantidad}");
                    }
                }

                return result;
            }
        }


    }
}
