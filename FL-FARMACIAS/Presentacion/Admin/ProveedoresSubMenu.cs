using FL_FARMACIAS.Presentacion.Farmaceutico;
using System;
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

            foreach (var row in this.orgEmployess)
            {
                this.dataGridView1.Rows.Add(row);

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
                    new CrearCuentaModal().Show();

                }
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "INGRESE DNI O APELLIDO")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void converTextBlack(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text != "INGRESE DNI O APELLIDO")
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "INGRESE DNI O APELLIDO";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[][] matched;
            if (textBox1.Text == "INGRESE DNI O APELLIDO" && comboBox1.Text == "Todos")
            {
                matched = this.orgEmployess
                           .ToArray(); // Convertir a un array de object[][]
            }
            else if (textBox1.Text == "INGRESE DNI O APELLIDO" && comboBox1.Text != "Todos")
            {
                matched = this.orgEmployess
                           .Where(x => x[7].ToString() == comboBox1.Text)
                           .ToArray(); // Convertir a un array de object[][]
            }
            else if ((comboBox1.Text == "Todos") && (textBox1.Text != "INGRESE DNI O APELLIDO"))
            {
                matched = this.orgEmployess
                       .Where(x => x[0].ToString().Contains(textBox1.Text) ||
                                   x[1].ToString().Contains(textBox1.Text) ||
                                   x[2].ToString().Contains(textBox1.Text) ||
                                   x[4].ToString().Contains(textBox1.Text))
                           .ToArray(); // Convertir a un array de object[][]
            }
            else if ((comboBox1.Text != "Todos") && (textBox1.Text != "INGRESE DNI O APELLIDO"))
            {
                matched = this.orgEmployess
                       .Where(x => x[0].ToString().Contains(textBox1.Text) ||
                                   x[1].ToString().Contains(textBox1.Text) ||
                                   x[2].ToString().Contains(textBox1.Text) ||
                                   x[4].ToString().Contains(textBox1.Text) &&
                                    x[7].ToString() == comboBox1.Text)
                           .ToArray(); // Convertir a un array de object[][]
            }
            else
            {
                matched = this.orgEmployess
                       .ToArray(); // Convertir a un array de object[][]
            }


            this.dataGridView1.Rows.Clear();

            foreach (var row in matched)
            {
                this.dataGridView1.Rows.Add(row);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();

            foreach (var row in this.orgEmployess)
            {
                this.dataGridView1.Rows.Add(row);
            }
        }

        private void button3w_Click(object sender, EventArgs e)
        {
            
        }

        private void ShowAltaproveedor()
        {
            if (AltaProveedor == null || AltaProveedor.IsDisposed)
            {
                AltaProveedor = new AltaProveedor();
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
    }
}
