using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Farmaceutico
{

    public partial class VentasSubMenu : Form
    {
        private Timer searchTimer;
        private Timer productTimer;

        private object[][] orgEmployess = new object[][]
                {
        new object[] { "1", "Juan", "Pérez", "M", "12345678", "20-12345678-9", "555-1234", "Farmaceutico", "30000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
                };

        public VentasSubMenu()
        {
            InitializeComponent();
            fullDataGridAllClients();
            fullDataGridAllProducts();
            //cliente
            searchTimer = new Timer();
            searchTimer.Interval = 500; // Intervalo de 500 ms
            searchTimer.Tick += new EventHandler(OnSearchTimerTick);
            //product
            productTimer = new Timer();
            productTimer.Interval = 500;
            productTimer.Tick += new EventHandler(OnProductTimerTick);

        }

        private void fullDataGridAllProducts()
        {
            dataGridView3.Rows.Clear();
           foreach (var p in StaticBD.productos) { dataGridView3.Rows.Add(p.codProducto, p.nombre, p.precio, p.stock, "ESCOJER"); }
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
                    dataGridView3.Rows.Add(p.codProducto, p.nombre, p.precio, p.stock, "ESCOJER");
                }
            }

            
        }

        private void fullDataGridAllClients()
        {
            dataGridView2.Rows.Clear();
            foreach (var c in StaticBD.clientes)
            {

                dataGridView2.Rows.Add(c.apellido, c.dni, c.desc.descripcion, "ESCOJER");
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
            dataGridView2.Rows.Clear();
            foreach (var c in StaticBD.clientes)
            {
                if (c.dni.StartsWith(s, StringComparison.OrdinalIgnoreCase) ||
                c.apellido.StartsWith(s, StringComparison.OrdinalIgnoreCase) )
                {
                    dataGridView2.Rows.Add(c.apellido, c.dni, c.desc.descripcion, "ESCOJER");
                }

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
                label5.Text = "APELLIDO: " + " " + apellido;
                label6.Text = "OBRA SOCIAL: " + obraSocial;
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
              

                // Mostrar un mensaje con la información del cliente seleccionado
               // MessageBox.Show($"Producto escogido: {codP}, DESCRIPCION: {descp}", "Producto Escogido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label8.Text = "CODIGO: " + codP;
                label9.Text = "DESCRIPCION: " + descp;
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "APELLIDO: Consumidor Final";
            label6.Text = "OBRA SOCIAL: Ninguna";
            label7.Text = "DNI: Ninguno";
        }
    }
}
