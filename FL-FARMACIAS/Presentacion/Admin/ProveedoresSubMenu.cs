using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using FL_FARMACIAS.Presentacion.Farmaceutico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class ProveedoresSubMenu : Form
    {
        private AltaProveedor AltaProveedor = null;
        private pedidosAproveedor pedidosproveedor = null;
        public ProductoAplicacion productoApp;
        public ProveedorAplicacion proveedorApp { get; set; }
        public PedidosAplicacion pedidosApp;


        public ProveedoresSubMenu()
        {
            InitializeComponent();
            this.proveedorApp = new ProveedorAplicacion();
            this.pedidosApp = new PedidosAplicacion();
            this.productoApp = new ProductoAplicacion();
            fullPedidos();
            fullProvedores();

        }

        public void fullPedidos()
        {
            List<pedidoDominio> pedidos = this.pedidosApp.ObtenerTodos();
            this.dataGridView1.Rows.Clear();
            foreach (var p in pedidos)
            {
                this.dataGridView1.Rows.Add(p.Idpedido, p.Fechapedido.ToString("yyyy-MM-dd"), p.proveedor.nombre, p.proveedor.cuit, p.farmaceutico.nombre + ' ' + p.farmaceutico.apellido, p.farmaceutico.dni, p.Estado, "VER DETALLE", "APROBAR", "RECIBIR", "CANCELAR", "MODIFICAR");
            }
        }



        public void fullProvedores()
        {
            List<ProveedorDominio> matcheds = this.proveedorApp.ObtenerTodos();
            this.dataGridView2.Rows.Clear();
            foreach (var e in matcheds)
            {
                this.dataGridView2.Rows.Add(e.id, e.nombre, e.cuit, e.telefono, e.correo, e.direccion, e.localidad, e.provincia, e.activo == true ? "ACTIVO" : "INACTIVO", "MODIFICAR", "ELIMINAR");
            }
        }
        private void dataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Verificar si el valor de la celda es "INACTIVO"
            var estado = dataGridView2.Rows[e.RowIndex].Cells["ESTADO"].Value?.ToString();
            if (estado != "ACTIVO")
            {
                dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;  // Fondo rojo suave
                dataGridView2.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;       // Texto negro
            }
            else
            {
                // Color de fondo y texto para filas activas
                dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;  // Fondo verde suave
                dataGridView2.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;       // Texto negro
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var dataGridView = sender as DataGridView;

                var id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["IDP"].Value);
                var prov = this.proveedorApp.BuscarProveedorId(id);

                if (dataGridView.Columns[e.ColumnIndex].Name == "ELIMINARP")
                {
                    if (!prov.activo)
                    {
                        MessageBox.Show("No se puede eliminar un proveedor NO activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                  
                    DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el proveedor "  + prov.nombre + " ?",
                                                              "Confirmar eliminación",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        this.proveedorApp.EliminarProveedor(prov.id);
                        this.fullProvedores();
                        MessageBox.Show("Proveedor eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                // Verifica si la columna clicada es "Modificar"
                else if (dataGridView.Columns[e.ColumnIndex].Name == "MODIFICARP")
                {

                    new ModificarProveedor(this,prov).Show();
                }
            
            }

        }


        private void ShowAltaproveedor()
        {
            if (AltaProveedor == null || AltaProveedor.IsDisposed)
            {
                AltaProveedor = new AltaProveedor(this);
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
            this.placeholderTextBox2.Text = "";
            this.placeholderTextBox2.ForeColor = Color.Black;
            fullProvedores();
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
            if (this.placeholderTextBox1.Text != "" && this.placeholderTextBox1.Text != "INGRESE ID PEDIDO")
            {
                cod_pedido = int.Parse(this.placeholderTextBox1.Text);
            }

            var matcheds = this.pedidosApp.BuscarPedidos(cod_pedido, this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            this.dataGridView1.Rows.Clear();
            foreach (var p in matcheds)
            {
                this.dataGridView1.Rows.Add(p.Idpedido, p.Fechapedido.ToString("yyyy-MM-dd"), p.proveedor.nombre, p.proveedor.cuit, p.farmaceutico.nombre + ' ' + p.farmaceutico.apellido, p.farmaceutico.dni, p.Estado, "VER DETALLE");

            }


        }

        private void ShowpedidosAproveedor()
        {
            if (pedidosproveedor == null || pedidosproveedor.IsDisposed)
            {
                pedidosproveedor = new pedidosAproveedor(this, null);
                pedidosproveedor.Show();
            }
            else
            {
                pedidosproveedor.BringToFront(); // Trae el formulario existente al frente
            }
        }
        private void button3w_Click_1(object sender, EventArgs e)
        {
            ShowpedidosAproveedor();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var dataGridView = sender as DataGridView;
               
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                if (dataGridView.Columns[e.ColumnIndex].Name == "DETALLE")
                {
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
                else if (dataGridView.Columns[e.ColumnIndex].Name == "APROBAR")
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["ESTADOP"].Value.ToString() != "ESPERA DE APROBACION")
                    {

                        MessageBox.Show("No es posible aprobar un pedido que no esta en estado ESPERA DE APROBACION", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult resultado = MessageBox.Show("¿Seguro que desea aprobar el pedido " + id.ToString() + "?",
                                                            "Confirmar aprobación",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        this.pedidosApp.ActualizarEstado(id, "REALIZADO");
                        this.fullPedidos();
                        MessageBox.Show("Pedido aprobado exitosamente, se quedara en estado REALIZADO.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (dataGridView.Columns[e.ColumnIndex].Name == "CANCELAR")
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["ESTADOP"].Value.ToString() != "ESPERA DE APROBACION")
                    {
                        MessageBox.Show("No es posible cancelar un pedido que no esta en estado ESPERA DE APROBACION", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar el pedido " + id.ToString() + "?",
                                                          "Confirmar cancelación",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        this.pedidosApp.ActualizarEstado(id, "CANCELADO");
                        this.fullPedidos();
                        MessageBox.Show("Pedido cancelado exitosamente, se quedara en estado CANCELADO.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (dataGridView.Columns[e.ColumnIndex].Name == "RECIBIR")
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["ESTADOP"].Value.ToString() != "REALIZADO")
                    {
                        MessageBox.Show("No es posible recibir un pedido que no esta en estado REALIZADO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult resultado = MessageBox.Show("¿Seguro que desea recibir el pedido " + id.ToString() + "?. El stock se actualizara automaticamente.",
                                                          "Confirmar recepción",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        var pedido = this.pedidosApp.BuscarPedidos(id)[0];
                        foreach(var d in pedido.detalle)
                        {
                            this.productoApp.IncrementarStock(d.Idproducto, d.cantidadPedido);
                        }
                        this.pedidosApp.ActualizarEstado(id, "RECIBIDO");
                        this.fullPedidos();
                        MessageBox.Show("Pedido recibido exitosamente, se quedara en estado RECIBIDO.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }else if(dataGridView.Columns[e.ColumnIndex].Name == "MODIFICAR")
                {

                    if (dataGridView1.Rows[e.RowIndex].Cells["ESTADOP"].Value.ToString() != "ESPERA DE APROBACION")
                    {
                        MessageBox.Show("No es posible modificar un pedido que no esta en estado ESPERA DE APROBACION", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var pedido = this.pedidosApp.BuscarPedidos(id)[0];

                    new pedidosAproveedorModificar(this, null, pedido).ShowDialog();


                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (placeholderTextBox2.Text == "" || placeholderTextBox2.Text == null || placeholderTextBox2.Text == "INGRESE NOMBRE O CUIT")
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dni = null;
            string nombre = null;

            if (placeholderTextBox2.Text.All(char.IsDigit))
            {
                dni = placeholderTextBox2.Text;
            }
            else
            {
                nombre = placeholderTextBox2.Text;
            }
            var matched = this.proveedorApp.BuscarProveedor(dni, nombre);

            this.dataGridView2.Rows.Clear();
            foreach (var p in matched)
            {
                this.dataGridView2.Rows.Add(p.id, p.nombre, p.cuit, p.telefono, p.correo, p.direccion, p.localidad, p.provincia, p.activo == true ? "ACTIVO" : "INACTIVO", "MODIFICAR", "ELIMINAR");
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
            else if (estado == "CANCELADO")
            {
                // Color de fondo y texto para filas activas
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;  // Fondo verde suave
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;       // Texto negro
            }
            else if (estado == "ESPERA DE APROBACION")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;  // Fondo rojo suave
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;       // Texto negro
            }
        }
    }


}
