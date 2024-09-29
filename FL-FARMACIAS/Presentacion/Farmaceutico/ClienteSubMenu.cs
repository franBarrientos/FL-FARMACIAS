using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Presentacion.Admin;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Farmaceutico
{
    public partial class ClienteSubMenu : Form
    {

        private AltaCliente altaCliente;
        public ClienteAplicacion clienteApp;
        public DescuentoAplicacion descuentoApp;

        private object[][] orgEmployess = new object[][]
                {
        new object[] { "30", "Silvia", "Campos", "F", "88990011", "27-88990011-9", "555-3459", "Supervisor", "37500", "20/04/24" ,"Usuario", "Eliminar", "Modificar" }
                };

        public ClienteSubMenu()
        {
            InitializeComponent();
            this.clienteApp = new ClienteAplicacion();
            this.descuentoApp = new DescuentoAplicacion();

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
                   // new CrearCuentaModal().Show();

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

      

        private void BFalta_ingresarcli_Click(object sender, EventArgs e)
        {
            if (altaCliente == null || altaCliente.IsDisposed)
            {
                altaCliente = new AltaCliente(this);
                altaCliente.Show();
            }
            else
            {
                altaCliente.BringToFront(); // Trae el formulario existente al frente
            }
        }
    }
}
