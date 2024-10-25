using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Globalization;
using FL_FARMACIAS.Presentacion.Login;


namespace FL_FARMACIAS.Presentacion.Farmaceutico
{

    public partial class VentasSubMenu : Form
    {
        private Timer searchTimer;
        private Timer productTimer;
        public ClienteAplicacion clienteApp;
        public ProductoAplicacion productoApp;
        public VentasAplicacion ventasApp;
        public ClienteDominio clienteSeleccionado;


        public VentasSubMenu()
        {
            this.clienteApp = new ClienteAplicacion();
            this.productoApp = new ProductoAplicacion();
            this.ventasApp = new VentasAplicacion();

            InitializeComponent();
            fullDataGridAllClients();
            fullDataGridAllProducts();
            fullMetodosPago();
            //cliente
            searchTimer = new Timer();
            searchTimer.Interval = 500; // Intervalo de 500 ms
            searchTimer.Tick += new EventHandler(OnSearchTimerTick);
            //product
            productTimer = new Timer();
            productTimer.Interval = 500;
            productTimer.Tick += new EventHandler(OnProductTimerTick);

            fullVentas();

        }

        public void fullVentas()
        {
            List<VentaDominioDominio> matcheds = this.ventasApp.ObtenerVentasPorEmpleado(LoginForm.user.empleado.id);
            this.dataGridView1.Rows.Clear();
            foreach (var d in matcheds)
            {
                this.dataGridView1.Rows.Add(d.id_venta, d.fecha, d.total, d.cliente.nombre, d.cliente.dni, d.porcentaje_descuento, (d.descuento != null ? d.descuento.descripcion : "NINGUNA"), d.metodoPago.descripcion, "VER DETALLE", "IMPRIMIR");
            }

        }


        //ventas
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            var venta = this.ventasApp.ObtenerVentaPorId(id);
            // Verificar que el clic fue en la columna de botones
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DETALLE")
            {
                // Crear un DataTable y definir las columnas
                DataTable detallesVenta = new DataTable();
                detallesVenta.Columns.Add("Nombre Producto", typeof(string));
                detallesVenta.Columns.Add("Cantidad", typeof(int));
                detallesVenta.Columns.Add("Precio Venta", typeof(decimal));
                detallesVenta.Columns.Add("Subtotal", typeof(decimal));

                foreach (var d in venta.detalles)
                {
                    detallesVenta.Rows.Add(d.producto.nombre, d.cantidad, d.producto.precio, d.producto.precio * d.cantidad);
                }

                DetalleVentaForm detalleVentaForm = new DetalleVentaForm();
                detalleVentaForm.CargarDetalles(detallesVenta); // Llenar el DataGridView con el DataTable
                detalleVentaForm.ShowDialog(); // Mostrar el fo
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "CLIENTE") { 
                MessageBox.Show("DNI: " + venta.cliente.dni + ", NOMBRES: " + venta.cliente.nombre + ", APELLIDOS: " + venta.cliente.apellido);
                
            }
        }


        public void fullMetodosPago()
        {
            List<MetodoPagoDominio> matcheds = this.ventasApp.ObtenerMetodosPagos();
            this.comboBox2.Items.Clear();
            foreach (var d in matcheds)
            {
                this.comboBox2.Items.Add(d.descripcion);
            }
        }

        private void fullDataGridAllProducts()
        {
            //dataGridView3.Rows.Clear();
           //foreach (var p in StaticBD.productos) { dataGridView3.Rows.Add(p.codProducto, p.nombre, p.precio, p.stock, "ESCOJER"); }
            var products = this.productoApp.ObtenerTodosActivo();
            dataGridView3.Rows.Clear();
            foreach (var p in products)
            {
                this.dataGridView3.Rows.Add(p.id, p.codProducto, p.nombre, p.precio, p.stock, "ESCOJER");
            }
        }

        private void OnProductTimerTick(object sender, EventArgs e)
        {
            
            // Parar el timer y realizar la búsqueda    
            productTimer.Stop();

            // Realizar la búsqueda

            if (placeholderTextBox2.Text.Length >= 1 && placeholderTextBox2.Text != "INGRESE COD PRODUCTO O DESCRIPCION")
            {
                buscarProduct(placeholderTextBox2.Text);
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            // Reiniciar el Timer cuando el texto cambie
            productTimer.Stop();
            productTimer.Start();
        }

        private void buscarProduct(string s)
        {
            dataGridView3.Rows.Clear();
            foreach (var p in StaticBD.productos)
            {
                if (p.codProducto.StartsWith(s, StringComparison.OrdinalIgnoreCase) || p.nombre.ToLower().Contains(s.ToLower()))
                {
                    dataGridView3.Rows.Add(p.id, p.codProducto, p.nombre, p.precio, p.stock, "ESCOJER");
                }
            }

            
        }

        private void fullDataGridAllClients()
        {

            List<ClienteDominio> matcheds = this.clienteApp.BuscarCliente(null, null, true, null);
            this.dataGridView2.Rows.Clear();

            foreach (var c in matcheds)
            {
                this.dataGridView2.Rows.Add(c.apellido, c.nombre, c.dni, (c.desc != null ? c.desc.descripcion : "NINGUNA"),(c.desc != null ? c.desc.porcentajeDescuento : 0) , "ESCOJER");
                
            }
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            // Reiniciar el Timer cuando el texto cambie
            searchTimer.Stop();
            searchTimer.Start();
        }
        private void OnSearchTimerTick(object sender, EventArgs e)
        {
            // Parar el timer y realizar la búsqueda
            searchTimer.Stop();
            Debug.WriteLine("Buscando clientes...");

            if (placeholderTextBox1.Text.Length >= 1 && placeholderTextBox1.Text != "INGRESE DNI O APELLIDO")
            {
                buscarClientes(placeholderTextBox1.Text);
            }else
            {
                fullDataGridAllClients();
            }
        }


        private void buscarClientes(string s)
        {
            var apellido = s;
            var dni = s;
            if (s.Trim().All(char.IsDigit))
            {
                apellido = null;
            }else
            {
                dni = null;
            }

            var matcheds = this.clienteApp.BuscarCliente(dni, apellido, true, null);
            dataGridView2.Rows.Clear();
            foreach (var c in matcheds)
            {        
                this.dataGridView2.Rows.Add(c.apellido, c.nombre, c.dni, c.desc.descripcion, c.desc.porcentajeDescuento, "ESCOJER");

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic fue en la columna de botones
            if (dataGridView2.Columns[e.ColumnIndex].Name == "ESCOJER")
            {
                // Obtener el valor de la fila seleccionada, por ejemplo, el nombre
                string apellido = dataGridView2.Rows[e.RowIndex].Cells["APELLIDO_V"].Value.ToString();
                string dni = dataGridView2.Rows[e.RowIndex].Cells["DNIV"].Value.ToString();
                string obraSocial = dataGridView2.Rows[e.RowIndex].Cells["OBRASOCIALV"].Value.ToString();

                // Mostrar un mensaje con la información del cliente seleccionado
                //MessageBox.Show($"Cliente escogido: {apellido}, DNI: {dni}", "Cliente Escogido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label7.Text = "DNI: " + dni;
                label11.Text = "DNI: " + dni;

                label5.Text = "APELLIDO: " + " " + apellido;
                label13.Text = "APELLIDO: " + " " + apellido;

                label16.Text = "NOMBRE: " + dataGridView2.Rows[e.RowIndex].Cells["NOMBREC"].Value.ToString();

                label6.Text = "OBRA SOCIAL: " + obraSocial;
                label12.Text = "OBRA SOCIAL: " + obraSocial;
                label17.Text = "% DESCUENTO: " + dataGridView2.Rows[e.RowIndex].Cells["DESCPORCENTAJE"].Value.ToString() + "%";

                this.clienteSeleccionado = this.clienteApp.BuscarCliente(dni, null, true, null)[0];

                if (label14.Text != "TOTAL:")
                {
                    var total = calcularTotal();
                    label14.Text = "TOTAL: " + total.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                    double pdesc;
                    if (!Double.TryParse(label17.Text.Split(':')[1].Replace("%", "").Trim(), out pdesc))
                    {
                        pdesc = 0; // Si la conversión falla, asigna 0
                    }
                    var totalDesc = Math.Round(total * pdesc / 100, 2);
                    label20.Text = "DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));

                    totalDesc = Math.Round(total - totalDesc, 2);
                    label19.Text = "TOTAL C\\DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                }
            }
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Suponiendo que la columna 1 (index 0) es la columna de precios
            if (dataGridView3.Columns[e.ColumnIndex].Name == "PRECIOP" && e.Value != null)
            {
                double precio;
                // Intentamos convertir el valor a double
                if (Double.TryParse(e.Value.ToString(), out precio))
                {
                    // Mostramos el precio con el símbolo de moneda, sin modificar el valor real
                    e.Value = precio.ToString("C", CultureInfo.GetCultureInfo("es-AR")); // o tu formato de moneda preferido
                    e.FormattingApplied = true;
                }

            }
        }
        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        { 

            if (dataGridView4.Columns[e.ColumnIndex].Name == "PRECIO" && e.Value != null)
            {
                double precio;
                // Intentamos convertir el valor a double
                if (Double.TryParse(e.Value.ToString(), out precio))
                {
                    // Mostramos el precio con el símbolo de moneda, sin modificar el valor real
                    e.Value = precio.ToString("C", CultureInfo.GetCultureInfo("es-AR")); // o tu formato de moneda preferido
                    e.FormattingApplied = true;
                }
            }

            if (dataGridView4.Columns[e.ColumnIndex].Name == "SUBTOTAL" && e.Value != null)
            {
                double precio;
                // Intentamos convertir el valor a double
                if (Double.TryParse(e.Value.ToString(), out precio))
                {
                    // Mostramos el precio con el símbolo de moneda, sin modificar el valor real
                    e.Value = precio.ToString("C", CultureInfo.GetCultureInfo("es-AR")); // o tu formato de moneda preferido
                    e.FormattingApplied = true;
                }
            }

        }


        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic fue en la columna de botones
            if (dataGridView3.Columns[e.ColumnIndex].Name == "ESCOJERP")
            {
                // Obtener el valor de la fila seleccionada, por ejemplo, el nombre
                string codP = dataGridView3.Rows[e.RowIndex].Cells["CODP"].Value.ToString();
                string descp = dataGridView3.Rows[e.RowIndex].Cells["DESCPP"].Value.ToString();
                string id = dataGridView3.Rows[e.RowIndex].Cells["IDPROD"].Value.ToString();
                this.label22.Text = id;

              

                // Mostrar un mensaje con la información del cliente seleccionado
               // MessageBox.Show($"Producto escogido: {codP}, DESCRIPCION: {descp}", "Producto Escogido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label8.Text = "CODIGO: " + codP;
                label9.Text = "DESCRIPCION: " + descp;
                preciolb.Text = "PRECIO: " + dataGridView3.Rows[e.RowIndex].Cells["PRECIOP"].Value.ToString();
                label18.Text = "STOCK: " + dataGridView3.Rows[e.RowIndex].Cells["STOCKP"].Value.ToString();
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.Columns[e.ColumnIndex].Name == "QUITAR")
            {
                dataGridView4.Rows.RemoveAt(e.RowIndex);
                var total = calcularTotal();
                label14.Text = "TOTAL: " + total.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                double pdesc;
                if (!Double.TryParse(label17.Text.Split(':')[1].Replace("%", "").Trim(), out pdesc))
                {
                    pdesc = 0; // Si la conversión falla, asigna 0
                }
                var totalDesc = Math.Round(total * pdesc / 100, 2);
                label20.Text = "DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));

                totalDesc = Math.Round(total - totalDesc, 2);
                label19.Text = "TOTAL C\\DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));

            }
        }

        private double calcularTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                total += Convert.ToDouble(row.Cells["SUBTOTAL"].Value);
            }
            return total;
        }


       
        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "APELLIDO: Consumidor Final";
            label6.Text = "OBRA SOCIAL: Ninguna";
            label7.Text = "DNI: Ninguno";


            label11.Text = "DNI: Ninguno";

            label13.Text = "APELLIDO: Consumidor Final";

            label16.Text = "NOMBRE: Ninguno";

            label12.Text = "OBRA SOCIAL: Ninguna";
            label17.Text = "% DESCUENTO: Ninguno";

            this.clienteSeleccionado = this.clienteApp.ObtenerClienteConsumidorFinal();

            if (label14.Text != "TOTAL:")
            {
                var total = calcularTotal();
                label14.Text = "TOTAL: " + total.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                double pdesc;
                if (!Double.TryParse(label17.Text.Split(':')[1].Replace("%", "").Trim(), out pdesc))
                {
                    pdesc = 0; // Si la conversión falla, asigna 0
                }
                var totalDesc = Math.Round(total * pdesc / 100, 2);
                label20.Text = "DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));

                totalDesc = Math.Round(total - totalDesc, 2);
                label19.Text = "TOTAL C\\DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label8.Text == "COD PRODUCTO:" || label9.Text == "DESCRIPCION:")
            {
                MessageBox.Show("Por favor, seleccione un producto");
                return;
            }

            var stockAv = label18.Text.Split(':')[1].Trim();
            if (stockAv == "" || stockAv.All(char.IsDigit) == false)
            {
                MessageBox.Show("Por favor, seleccione un stock disponible");
                return;
            }

            var nuevoStockSeleccionado = Convert.ToInt32(numericUpDown1.Value);
            var stockDisponible = Convert.ToInt32(stockAv);

            if (nuevoStockSeleccionado > stockDisponible)
            {
                MessageBox.Show("Por favor, seleccione un stock disponible");
                return;
            }

            var cod = label8.Text.Split(':')[1];
            var price = preciolb.Text.Split(':');
            var desc = label9.Text.Split(':')[1];
            var idP = label22.Text;
            double sub = Math.Round(Convert.ToDouble(price[1]) * nuevoStockSeleccionado, 2);

            bool productoExistente = false;
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                if (row.Cells["CODC"].Value.ToString() == cod) // Asegúrate de que "Codigo" sea el nombre correcto de la columna
                {
                    int cantidadExistente = Convert.ToInt32(row.Cells["CANTIDADC"].Value); // Asegúrate de que "Cantidad" sea el nombre correcto de la columna

                    // Verificar si la suma no supera el stock disponible
                    if (cantidadExistente + nuevoStockSeleccionado > stockDisponible)
                    {
                        MessageBox.Show("La cantidad total supera el stock disponible.");
                        return;
                    }

                    // Si el producto ya existe, actualizar la cantidad
                    row.Cells["CANTIDADC"].Value = cantidadExistente + nuevoStockSeleccionado; // Actualiza la cantidad
                    row.Cells["SUBTOTAL"].Value = Math.Round(Convert.ToDouble(row.Cells["PRECIO"].Value) * (cantidadExistente + nuevoStockSeleccionado), 2); // Actualiza el subtotal
                    productoExistente = true;
                    break; // Salir del bucle ya que encontramos el producto
                }
            }

            // Si el producto no existe, añadir una nueva fila
            if (!productoExistente)
            {
                this.dataGridView4.Rows.Add(idP, cod, desc, nuevoStockSeleccionado.ToString(), price[1], sub, "QUITAR");
            }

            //this.dataGridView4.Rows.Add(cod, desc, numericUpDown1.Value.ToString(), price[1], sub, "QUITAR");

            var total = calcularTotal();
            label14.Text = "TOTAL: " + total.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
            double pdesc;
            if (!Double.TryParse(label17.Text.Split(':')[1].Replace("%", "").Trim(), out pdesc))
            {
                pdesc = 0; // Si la conversión falla, asigna 0
            }
            var totalDesc  = Math.Round(total * pdesc / 100, 2);
            label20.Text = "DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));

            totalDesc = Math.Round(total - totalDesc, 2);
            label19.Text = "TOTAL C\\DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label15.Text = "MEDIO DE PAGO: " + comboBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            placeholderTextBox3.Text = "";
            placeholderTextBox3.ForeColor = Color.Black;

            placeholderTextBox4.Text = "";
            placeholderTextBox4.ForeColor = Color.Black;

            this.fullVentas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = null;
            int? cod_factura = null;

            if (!string.IsNullOrEmpty(placeholderTextBox3.Text) && placeholderTextBox3.Text != "INGRESE COD FACTURA"
                && placeholderTextBox3.Text.All(char.IsDigit))
            {
                cod_factura = int.Parse(placeholderTextBox3.Text);
            }

            if (!string.IsNullOrEmpty(placeholderTextBox4.Text) && placeholderTextBox4.Text != "INGRESE DNI CLIENTE"
               && placeholderTextBox4.Text.All(char.IsDigit))
            {
                dni = placeholderTextBox4.Text;
            }

            var matcheds = this.ventasApp.ObtenerVentasPorEmpleadoAndFiltros(LoginForm.user.empleado.id, dni, cod_factura, dateTimePicker1.Value, dateTimePicker2.Value);
            this.dataGridView1.Rows.Clear();
            foreach (var d in matcheds)
            {
//                this.dataGridView1.Rows.Add(d.id_venta, d.fecha, d.total, "VER DETALLE DE " + d.detalles.Count + (d.detalles.Count > 1 ? " PRODUCTOS" : " PRODUCTO"), "VER INFORMACION DEL CLIENTE CON DNI: " + d.cliente.dni, d.porcentaje_descuento, d.metodoPago.descripcion);
                this.dataGridView1.Rows.Add(d.id_venta, d.fecha, d.total, d.cliente.nombre, d.cliente.dni, d.porcentaje_descuento, (d.descuento != null ? d.descuento.descripcion : "NINGUNA"), d.metodoPago.descripcion, "VER DETALLE", "IMPRIMIR");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Bagregar_categoria_Click(object sender, EventArgs e)
        
            //  public void RegistrarVenta(int clienteId, int empleadoId, int metodoPagoId,
         //   int? descuentoId, float porcentaje_descuento, List< VentaDetalleDominio > productosSeleccionados)
        {
            if(dataGridView4.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto");
                return;
            }

            if(this.clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente o consumidor final");
                return; 
            }

            if(this.comboBox2.Text == "")
            {
                MessageBox.Show("Debe seleccionar un medio de pago");
                return;
            }


            int metodoPagoId = this.ventasApp.ObtenerMetodoPagoId(this.comboBox2.Text);

            int? descuentoId = null;
            double porcentaje_descuento = 0;
            if (this.clienteSeleccionado.desc != null)
            {
                descuentoId = this.clienteSeleccionado.desc.id;
                porcentaje_descuento = this.clienteSeleccionado.desc.porcentajeDescuento;
            }

            var productosSeleccionados = new List<VentaDetalleDominio>();

            foreach (DataGridViewRow row in this.dataGridView4.Rows)
            {
                // Verificar que las celdas no sean nulas o vacías
                if (row.Cells["IDC"].Value != null &&
                    !string.IsNullOrWhiteSpace(row.Cells["IDC"].Value.ToString()) &&
                    row.Cells["CANTIDADC"].Value != null &&
                    !string.IsNullOrWhiteSpace(row.Cells["CANTIDADC"].Value.ToString()) &&
                    row.Cells["PRECIO"].Value != null &&
                    !string.IsNullOrWhiteSpace(row.Cells["PRECIO"].Value.ToString()))
                {
                    try
                    {
                        var cod = row.Cells["IDC"].Value.ToString();
                        var cantidad = row.Cells["CANTIDADC"].Value.ToString();

                        // Aquí usamos row.Cells["PRECIO"].Value, que es el valor original sin formateo
                        var precio = Convert.ToDecimal(row.Cells["PRECIO"].Value);

                        productosSeleccionados.Add(new VentaDetalleDominio
                        {
                            id_producto = Convert.ToInt32(cod),
                            cantidad = Convert.ToInt32(cantidad),
                            precio_unitario = precio
                        });
                    }
                    catch (FormatException ex)
                    {
                        // Mostrar el valor que causó el problema para depurar
                        MessageBox.Show("Error al convertir valores. Revisa los datos en la fila: " +
                                        row.Index + "\n" +
                                        "CODC: " + row.Cells["CODC"].Value.ToString() + "\n" +
                                        "CANTIDADC: " + row.Cells["CANTIDADC"].Value.ToString() + "\n" +
                                        "PRECIO: " + row.Cells["PRECIO"].Value.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Una de las celdas está vacía o contiene un valor nulo en la fila: " + row.Index);
                }
            }


            this.ventasApp.RegistrarVenta(this.clienteSeleccionado.id, LoginForm.user.empleado.id, metodoPagoId, descuentoId, porcentaje_descuento, productosSeleccionados);
            MessageBox.Show("VENTA REGISTRADA");
            this.fullVentas();
            
        }
    }
}
