using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using FL_FARMACIAS.Presentacion.Farmaceutico;
using FL_FARMACIAS.Presentacion.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class pedidosAproveedorModificar : Form
    {
        private Timer proveedorTimer;
        private Timer productTimer;
        public ProveedoresSubMenu proveedorSubMenu;
        public PedidossSubMenu pedidosSubMenu;
        public ProductoAplicacion productoApp;
        public ProveedorDominio provedorSeleccionado;
        public pedidoDominio pedidoD;


        public pedidosAproveedorModificar(ProveedoresSubMenu pm, PedidossSubMenu ps, pedidoDominio pedido)
        {
            InitializeComponent();
            this.pedidoD = pedido;
            this.proveedorSubMenu = pm;
            this.pedidosSubMenu = ps;

            this.productoApp = new ProductoAplicacion();

            fullDataGridAllProveedores();
            fullDataGridAllProducts();

            //cliente
            proveedorTimer = new Timer();
            proveedorTimer.Interval = 500; // Intervalo de 500 ms
            proveedorTimer.Tick += new EventHandler(OnProveedorTimerTick);
            //product
            productTimer = new Timer();
            productTimer.Interval = 500;
            productTimer.Tick += new EventHandler(OnProductTimerTick);
            fullData(pedido);
            this.label1.Text = "FECHA DEL PEDIDO: " + pedido.Fechapedido.ToString("d", CultureInfo.CreateSpecificCulture("es-ES"));
        }

        public void fullData(pedidoDominio pedido)
        {
            label7.Text = "CUIT: " + pedido.proveedor.cuit;
            label11.Text = "CUIT PROVEEDOR: " + pedido.proveedor.cuit;

            label5.Text = "NOMBRE: " + pedido.proveedor.nombre;
            label16.Text = "NOMBRE PROVEEDOR: " + pedido.proveedor.nombre;



            label6.Text = "PROVINCIA: " + pedido.proveedor.provincia;
            this.provedorSeleccionado = pedido.proveedor;

            foreach (var p in pedido.detalle)
            {

                this.dataGridView4.Rows.Add(p.producto.id, p.producto.codProducto, p.producto.nombre, p.cantidadPedido, "QUITAR");
            }
            this.label12.Text = "CANTIDAD PRODUCTOS PEDIDOS: " + dataGridView4.Rows.Count.ToString();


        }

        private void fullDataGridAllProveedores()
        {
            if (this.proveedorSubMenu != null)
            {

                List<ProveedorDominio> matcheds = this.proveedorSubMenu.proveedorApp.ObtenerTodosActivo();
                this.dataGridView2.Rows.Clear();

                foreach (var c in matcheds)
                {
                    this.dataGridView2.Rows.Add(c.nombre, c.cuit, c.provincia, "ESCOJER");
                }
            }
            else
            {
                List<ProveedorDominio> matcheds = this.pedidosSubMenu.proveedorApp.ObtenerTodosActivo();
                this.dataGridView2.Rows.Clear();

                foreach (var c in matcheds)
                {
                    this.dataGridView2.Rows.Add(c.nombre, c.cuit, c.provincia, "ESCOJER");
                }
            }
        }

        private void fullDataGridAllProducts()
        {
           
            var products = this.productoApp.ObtenerTodosActivo();
            dataGridView3.Rows.Clear();
            foreach (var p in products)
            {
                this.dataGridView3.Rows.Add(p.id, p.codProducto, p.nombre, p.marca.nombre, (p.laboratorio == null ? "" : p.laboratorio.nombre), "ESCOJER");
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
            }else if (placeholderTextBox2.Text.Length == 0)
            {
                this.fullDataGridAllProducts();
            }
        }

        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            // Reiniciar el Timer cuando el texto cambie
            proveedorTimer.Stop();
            proveedorTimer.Start();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            // Reiniciar el Timer cuando el texto cambie
            productTimer.Stop();
            productTimer.Start();
        }


        private void OnProveedorTimerTick(object sender, EventArgs e)
        {

            // Parar el timer y realizar la búsqueda    
            proveedorTimer.Stop();

            // Realizar la búsqueda

            if (placeholderTextBox1.Text.Length >= 1 && placeholderTextBox1.Text != "INGRESE CUIT O NOMBRE")
            {
                buscarProovedor(placeholderTextBox1.Text);
            }
            else if (placeholderTextBox1.Text.Length == 0)
            {
                this.fullDataGridAllProveedores();
            
            }
        }

        public void buscarProovedor(string s)
        {
            if (this.proveedorSubMenu != null)
            {
                    string cuit = null;
                    string apellido = null;

                    if (s.All(char.IsDigit))
                    {
                        cuit = s;
                    }
                    else
                    {
                        apellido =s;
                    }
                    List<ProveedorDominio> matcheds = this.proveedorSubMenu.proveedorApp.BuscarProveedor(cuit, apellido);
                    dataGridView2.Rows.Clear();
                    foreach (var c in matcheds)
                    {
                        this.dataGridView2.Rows.Add(c.nombre, c.cuit, c.provincia, "ESCOJER");
                    }

            }
            else
            {

                    string cuit = null;
                    string apellido = null;

                    if (s.All(char.IsDigit))
                    {
                        cuit = s;
                    }
                    else
                    {
                        apellido = s;
                    }
                    List<ProveedorDominio> matcheds = this.pedidosSubMenu.proveedorApp.BuscarProveedor(cuit, apellido);
                    dataGridView2.Rows.Clear();
                    foreach (var c in matcheds)
                    {
                        this.dataGridView2.Rows.Add(c.nombre, c.cuit, c.provincia, "ESCOJER");
                    }
            }
        }

        private void buscarProduct(string s)
        {
            String codigocompara = @"^[A-Za-z]{3}_\d{5}$";
            var matcheds = new List<ProductoDominio>();
            if (!Regex.IsMatch(s, codigocompara)) { 
                matcheds = this.productoApp.BuscarProductos(null, s, null);
            }
            else
            {
                matcheds = this.productoApp.BuscarProductos(s, null , null);

            }
            dataGridView3.Rows.Clear();
            foreach (var p in matcheds)
            {
                    dataGridView3.Rows.Add(p.id, p.codProducto, p.nombre, p.marca.nombre, (p.laboratorio == null ? "" : p.laboratorio.nombre), "ESCOJER");
            }


        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.Columns[e.ColumnIndex].Name == "QUITARC")
            {
                dataGridView4.Rows.RemoveAt(e.RowIndex);
             
            }
            this.label12.Text = "CANTIDAD PRODUCTOS PEDIDOS: " + dataGridView4.Rows.Count.ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic fue en la columna de botones
            if (dataGridView3.Columns[e.ColumnIndex].Name == "ESCOJERP")
            {
                // Obtener el valor de la fila seleccionada, por ejemplo, el nombre
                string codP = dataGridView3.Rows[e.RowIndex].Cells["CODP"].Value.ToString();
                string descp = dataGridView3.Rows[e.RowIndex].Cells["DESCPP"].Value.ToString();
                string id = dataGridView3.Rows[e.RowIndex].Cells["IDP"].Value.ToString();

                label8.Text = "CODIGO: " + codP;
                label9.Text = "DESCRIPCION: " + descp;
                label2.Text = id;
             
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic fue en la columna de botones
            if (dataGridView2.Columns[e.ColumnIndex].Name == "ESCOJER")
            {
                // Obtener el valor de la fila seleccionada, por ejemplo, el nombre
                string nombre = dataGridView2.Rows[e.RowIndex].Cells["nombre_proveedor_DG"].Value.ToString();
                string cuit = dataGridView2.Rows[e.RowIndex].Cells["cuit_prove_DG"].Value.ToString();
                string provincia = dataGridView2.Rows[e.RowIndex].Cells["provincia_prove_DG"].Value.ToString();


               label7.Text = "CUIT: " + cuit;
                label11.Text = "CUIT PROVEEDOR: " + cuit;

                label5.Text = "NOMBRE: " + nombre;
                label16.Text = "NOMBRE PROVEEDOR: " + nombre;



                label6.Text = "PROVINCIA: " + provincia;
                if(this.pedidosSubMenu != null)
                {
                    this.provedorSeleccionado = this.pedidosSubMenu.proveedorApp.BuscarProveedor(cuit, null)[0];
                }
                else
                {
                    this.provedorSeleccionado = this.proveedorSubMenu.proveedorApp.BuscarProveedor(cuit, null)[0];
                }


            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void pedidosAproveedor_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label8.Text == "COD PRODUCTO:" || label9.Text == "DESCRIPCION:")
            {
                MessageBox.Show("Por favor, seleccione un producto");
                return;
            }

            var nuevoStockSeleccionado = Convert.ToInt32(numericUpDown1.Value);
           
            var cod = label8.Text.Split(':')[1];
            var desc = label9.Text.Split(':')[1];
            var idPc = label2.Text;

            bool productoExistente = false;
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                if (row.Cells["IDPC"].Value.ToString() == idPc.Trim()) // Asegúrate de que "Codigo" sea el nombre correcto de la columna
                {
                    int cantidadExistente = Convert.ToInt32(row.Cells["CANTIDADC"].Value); // Asegúrate de que "Cantidad" sea el nombre correcto de la columna
                    row.Cells["CANTIDADC"].Value = cantidadExistente + nuevoStockSeleccionado; // Actualiza la cantidad
                    productoExistente = true;
                    break; // Salir del bucle ya que encontramos el producto
                }
            }

            // Si el producto no existe, añadir una nueva fila
            if (!productoExistente)
            {
                this.dataGridView4.Rows.Add(idPc, cod, desc, nuevoStockSeleccionado.ToString(), "QUITAR");
                this.label12.Text = "CANTIDAD PRODUCTOS PEDIDOS: " + dataGridView4.Rows.Count.ToString();
            }
        }

      

        private void Bagregar_categoria_Click(object sender, EventArgs e)
        {
            if (dataGridView4.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto");
                return;
            }

            if (this.provedorSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return;
            }

            var productosSeleccionados = new List<PedidosDetalleDominio>();

            foreach (DataGridViewRow row in this.dataGridView4.Rows)
            {
                  var cod = row.Cells["IDPC"].Value.ToString();
                  var cantidad = row.Cells["CANTIDADC"].Value.ToString();

                  productosSeleccionados.Add(new PedidosDetalleDominio
                  {
                      Idproducto = Convert.ToInt32(cod),
                      cantidadPedido = Convert.ToInt32(cantidad),
                  });
                    Console.WriteLine("AXA     ID Prod: " + cod + " CANT: " + cantidad);
            }


            if(this.proveedorSubMenu != null)
            {

                this.proveedorSubMenu.pedidosApp.ModificarPedido(this.provedorSeleccionado.id, pedidoD.Idpedido, productosSeleccionados);
                MessageBox.Show("PEDIDO MODIFICADO");
                this.proveedorSubMenu.fullPedidos();
                this.Close();
            }
            else 
            {
                Console.WriteLine(provedorSeleccionado.nombre);
                this.pedidosSubMenu.pedidosApp.RegistrarPedido(this.provedorSeleccionado.id, LoginForm.user.empleado.id, productosSeleccionados, "ESPERA DE APROBACION");
                MessageBox.Show("PEDIDO REGISTRADO");
                this.pedidosSubMenu.fullPedidos();
                this.Close();
            }


        }
    }
}
