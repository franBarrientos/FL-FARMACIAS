using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using FL_FARMACIAS.Presentacion.Farmaceutico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class ProveedoresSubMenu : Form
    {
        private AltaProveedor AltaProveedor = null;
        private pedidosAproveedor pedidosproveedor = null;
        public ProveedorAplicacion proveedorApp { get; set; }

        private object[][] orgEmployess = new object[][]
                {
        new object[] { "1", "2024-02-04", "proveedor1", "farmaceutico1", "PRODUCTOS PEDIDOS", "activo", "APROBAR", "Eliminar", "Modificar" },
         new object[] { "2", "2024-02-13", "proveedor3", "farmaceutico4", "PRODUCTOS PEDIDOS", "activo", "APROBAR", "Eliminar", "Modificar" },
          new object[] { "3", "2024-03-24", "proveedor4", "farmaceutico3", "PRODUCTOS PEDIDOS", "activo", "APROBAR", "Eliminar", "Modificar" },
           new object[] { "4", "2024-11-14", "proveedor2", "farmaceutico3", "PRODUCTOS PEDIDOS", "activo", "APROBAR", "Eliminar", "Modificar" },
            new object[] { "5", "2024-06-20", "proveedor12", "farmaceutico2", "PRODUCTOS PEDIDOS", "activo", "APROBAR", "Eliminar", "Modificar" },
             new object[] { "6", "2024-04-22", "proveedor3", "farmaceutico12", "PRODUCTOS PEDIDOS", "activo", "APROBAR", "Eliminar", "Modificar" },
              new object[] { "7", "2024-12-27", "proveedor2", "farmaceutico13", "PRODUCTOS PEDIDOS", "activo", "APROBAR", "Eliminar", "Modificar" },
               new object[] { "8", "2024-01-03", "proveedor1", "farmaceutico2", "PRODUCTOS PEDIDOS", "activo", "APROBAR", "Eliminar", "Modificar" },
                new object[] { "9", "2024-02-04", "proveedor6", "farmaceutico0", "PRODUCTOS PEDIDOS", "activo", "APROBAR", "Eliminar", "Modificar" },
                 new object[] { "10", "2024-02-04", "proveedor4", "farmaceutico10", "PRODUCTOS PEDIDOS", "activo", "APROBAR", "Eliminar", "Modificar" }

                };

        public ProveedoresSubMenu()
        {
            InitializeComponent();
            this.proveedorApp = new ProveedorAplicacion();

            fullProvedores();

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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
   

        }

        private void ShowpedidosAproveedor()
        {
            if (pedidosproveedor == null || pedidosproveedor.IsDisposed)
            {
                pedidosproveedor = new pedidosAproveedor();
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
    }
}
