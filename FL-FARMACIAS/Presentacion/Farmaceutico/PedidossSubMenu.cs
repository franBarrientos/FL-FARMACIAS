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


        public PedidossSubMenu()
        {
            this.proveedorApp = new ProveedorAplicacion();
            InitializeComponent();
            fullProveedores();

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

                if (dataGridView.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    // Aquí colocas el código que se ejecuta al hacer clic en el botón "Eliminar"
                    MessageBox.Show($"Eliminar fila {e.RowIndex}");
                    // Ejemplo: eliminar la fila
                    dataGridView.Rows.RemoveAt(e.RowIndex);
                }
                // Verifica si la columna clicada es "Modificar"
                else if (dataGridView.Columns[e.ColumnIndex].Name == "MODIFICAR")
                {
                    // Aquí colocas el código que se ejecuta al hacer clic en el botón "Modificar"
                    MessageBox.Show($"Modificar fila {e.RowIndex}");
                    // Ejemplo: mostrar detalles para modificar
                    var nombre = dataGridView.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                    var apellido = dataGridView.Rows[e.RowIndex].Cells["APELLIDO"].Value.ToString();
                    // Aquí podrías abrir un formulario de edición con estos datos, por ejemplo.
                }
                else if (dataGridView.Columns[e.ColumnIndex].Name == "USUARIO")
                {
                    //new CrearCuentaModal().Show();

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

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3w_Click_1(object sender, EventArgs e)
        {
            if (altaPedido == null || altaPedido.IsDisposed)
            {
                altaPedido = new pedidosAproveedor();
                altaPedido.Show();
            }
            else
            {
                altaPedido.BringToFront(); // Trae el formulario existente al frente
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
