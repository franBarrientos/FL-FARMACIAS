using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using FL_FARMACIAS.Presentacion.Admin;
using FL_FARMACIAS.Presentacion.Farmaceutico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Farmaceutico
{
    public partial class PedidossSubMenu : Form
    {
        private AltaProveedor AltaProveedor = null;
        private pedidosAproveedor altaPedido = null;
        public ProveedorAplicacion proveedorApp;
        public PedidosAplicacion pedidosApp;


        public PedidossSubMenu()
        {
            this.proveedorApp = new ProveedorAplicacion();
            this.pedidosApp = new PedidosAplicacion();
            InitializeComponent();
            fullPedidos();
            fullProveedores();

        }

        public void fullPedidos()
        {
            List<pedidoDominio> pedidos = this.pedidosApp.ObtenerTodos();
            this.dataGridView1.Rows.Clear();
            foreach(var p in pedidos)
            {
                this.dataGridView1.Rows.Add(p.Idpedido, p.Fechapedido.ToString("yyyy-MM-dd"), p.proveedor.nombre, p.proveedor.cuit, p.farmaceutico.nombre + ' '+ p.farmaceutico.apellido, p.farmaceutico.dni, p.Estado, "VER DETALLE");
            }
        }

        public void fullProveedores()
        {
            List<ProveedorDominio> proveedors = this.proveedorApp.ObtenerTodos();
            this.dataGridView2.Rows.Clear();
            foreach(var p in proveedors)
            {
                this.dataGridView2.Rows.Add(p.id, p.nombre, p.cuit, p.telefono, p.correo, p.direccion, p.localidad, p.provincia, p.activo ? "ACTIVO" : "INACTIVO", "MODIFICAR", "ELIMINAR");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var dataGridView = sender as DataGridView;

                if (dataGridView.Columns[e.ColumnIndex].Name == "DETALLE")
                {
                    int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    var pedido = this.pedidosApp.BuscarPedidos(id)[0];


                    DataTable detallesVenta = new DataTable();
                    detallesVenta.Columns.Add("Cod Producto", typeof(string));
                    detallesVenta.Columns.Add("Nombre Producto", typeof(string));
                    detallesVenta.Columns.Add("Categoria", typeof(string));
                    detallesVenta.Columns.Add("Marca", typeof(string));
                    detallesVenta.Columns.Add("Laboratorio", typeof(string));
                    detallesVenta.Columns.Add("Cantidad", typeof(int));

                    foreach (var d in pedido.detalle)
                    {
                        detallesVenta.Rows.Add(d.producto.codProducto, d.producto.nombre, d.producto.categoria.descripcion, d.producto.marca.nombre, (d.producto.laboratorio != null ? d.producto.laboratorio.nombre : "Ninguno"), d.cantidadPedido);
                    }

                    DetalleVentaForm detalleVentaForm = new DetalleVentaForm();
                    detalleVentaForm.CargarDetalles(detallesVenta); // Llenar el DataGridView con el DataTable
                    detalleVentaForm.ShowDialog(); // Mostrar el fo
                }
            }

        }



      
   
  

        private void ShowAltaproveedor()
        {
            if (AltaProveedor == null || AltaProveedor.IsDisposed)
            {
                //AltaProveedor = new AltaProveedor(this);
                AltaProveedor.Show();
            }
            else
            {
                AltaProveedor.BringToFront(); // Trae el formulario existente al frente
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ShowAltaproveedor();
            //new AltaProveedor().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.placeholderTextBox1.Text = "";
            this.placeholderTextBox1.ForeColor = Color.Black;
            this.fullProveedores();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.placeholderTextBox2.Text = "";
            this.placeholderTextBox2.ForeColor = Color.Black;

            this.dateTimePicker1.Value = new DateTime(1970, 1, 1);
            this.dateTimePicker2.Value = DateTime.Now;
 
            this.fullPedidos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int? cod_pedido = null;
            if(this.placeholderTextBox2.Text != "" && this.placeholderTextBox2.Text != "INGRESE ID PEDIDO")
            {
                cod_pedido = int.Parse(this.placeholderTextBox2.Text);
            }

            var matcheds = this.pedidosApp.BuscarPedidos(cod_pedido, this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            this.dataGridView1.Rows.Clear();
            foreach(var p in matcheds)
            {
                this.dataGridView1.Rows.Add(p.Idpedido, p.Fechapedido.ToString("yyyy-MM-dd"), p.proveedor.nombre, p.proveedor.cuit, p.farmaceutico.nombre + ' ' + p.farmaceutico.apellido, p.farmaceutico.dni, p.Estado, "VER DETALLE");

            }
        }

        private void button3w_Click_1(object sender, EventArgs e)
        {
            if (altaPedido == null || altaPedido.IsDisposed)
            {
                altaPedido = new pedidosAproveedor(null, this);
                altaPedido.Show();
            }
            else
            {
                altaPedido.BringToFront(); // Trae el formulario existente al frente
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Verificar si el valor de la celda es "INACTIVO"
            var estado = dataGridView1.Rows[e.RowIndex].Cells["ESTADOP"].Value?.ToString();
            if (estado == "RECIBIDO")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;  // Fondo rojo suave
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;       // Texto negro
            }
            else if (estado == "REALIZADO")
            {
                // Color de fondo y texto para filas activas
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;  // Fondo verde suave
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;       // Texto negro
            }
            else if(estado == "CANCELADO")
            {
                // Color de fondo y texto para filas activas
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;  // Fondo verde suave
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;       // Texto negro
            }
            else if( estado == "ESPERA DE APROBACION")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;  // Fondo rojo suave
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;       // Texto negro
            }
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (placeholderTextBox1.Text == "" || placeholderTextBox1.Text == null || placeholderTextBox1.Text == "INGRESE NOMBRE O CUIT")
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dni = null;
            string nombre = null;

            if (placeholderTextBox1.Text.All(char.IsDigit))
            {
                dni = placeholderTextBox1.Text;
            }
            else
            {
                nombre = placeholderTextBox1.Text;
            }
            var matched = this.proveedorApp.BuscarProveedor(dni, nombre);

            this.dataGridView2.Rows.Clear();
            foreach (var p in matched)
            {
                this.dataGridView2.Rows.Add(p.id, p.nombre, p.cuit, p.telefono, p.correo, p.direccion, p.localidad, p.provincia, p.activo == true ? "ACTIVO" : "INACTIVO", "MODIFICAR", "ELIMINAR");
            }
        }
    }
}
