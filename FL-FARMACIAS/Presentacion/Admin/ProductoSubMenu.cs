using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class productoSubMenu : Form
    {
        private List<object[]> orgProducts = new List<object[]>
        {
            new object[] { 1, "P001", "Producto 1", 10.5, 100, "Perfumeria" , true,},
            new object[] { 2, "P002", "Producto 2", 20.0, 50, "Medicamentos" , false,},
            new object[] { 3, "P003", "Producto 3", 15.0, 200, "Medicamentos" , true,},
            new object[] { 4, "P004", "Producto 4", 25.75, 150, "Medicamentos" , true,},
            new object[] { 5, "P005", "Producto 5", 5.0, 300, "Medicamentos" , false,}
        };

        private List<object[]> orgCategories = new List<object[]>
        {
            new object[]{ 1, "Permuferia", true },
            new object[]{ 1, "Medicamentos", true }
        };

        public void insertProduct(object[] p)
        {
            this.dataGridView1.Rows.Add(p);
            this.orgProducts.Add(p);
        }
        public productoSubMenu()
        {
            InitializeComponent();
          
                 foreach (var row in this.orgProducts)
                 {
                     this.dataGridView1.Rows.Add(row);

                 }

                foreach (var row in this.orgCategories)
                {
                    this.dataGridView2.Rows.Add(row);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "INGRESE ID O DESCRIPCION")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void converTextBlack2(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text != "INGRESE ID O DESCRIPCION")
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "INGRESE ID O DESCRIPCION";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             object[][] matched;
            if (textBox1.Text == "INGRESE NOMBRE O COD PRODUCTO" && comboBox1.Text == "Todos")
            {
                matched = this.orgProducts
                           .ToArray(); // Convertir a un array de object[][]
            }
            else if (textBox1.Text == "INGRESE NOMBRE O COD PRODUCTO" && comboBox1.Text != "Todos")
            {
                matched = this.orgProducts
                           .Where(x => x[5].ToString() == comboBox1.Text)
                           .ToArray(); // Convertir a un array de object[][]
            }
            else if ((comboBox1.Text == "Todos") && (textBox1.Text != "INGRESE NOMBRE O COD PRODUCTO"))
            {
                matched = this.orgProducts
                       .Where(x => x[0].ToString().Contains(textBox1.Text) ||
                                   x[1].ToString().Contains(textBox1.Text) ||
                                   x[2].ToString().Contains(textBox1.Text) ||
                                   x[4].ToString().Contains(textBox1.Text))
                           .ToArray(); // Convertir a un array de object[][]
            }
            else if ((comboBox1.Text != "Todos") && (textBox1.Text != "INGRESE NOMBRE O COD PRODUCTO"))
            {
                matched = this.orgProducts
                       .Where(x => x[0].ToString().Contains(textBox1.Text) ||
                                   x[1].ToString().Contains(textBox1.Text) ||
                                   x[2].ToString().Contains(textBox1.Text) ||
                                   x[4].ToString().Contains(textBox1.Text) &&
                                    x[5].ToString() == comboBox1.Text)
                           .ToArray(); // Convertir a un array de object[][]
            }
            else
            {
                matched = this.orgProducts
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
           this.dataGridView1.Rows.Clear ();
           
            foreach (var row in this.orgProducts)
            {
                this.dataGridView1.Rows.Add(row);
            }
        }

        private void button3w_Click(object sender, EventArgs e)
        {
            new AgrerarProductoAdmi(this).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            object[][] matched;
            if (textBox2.Text != "INGRESE ID O DESCRIPCION")
            {
                matched = this.orgCategories
                    .Where(x => x[0].ToString().Contains(textBox2.Text)
                    || x[1].ToString().Contains(textBox2.Text))
                           .ToArray(); // Convertir a un array de object[][]
            }
            else
            {
                matched = this.orgCategories
                       .ToArray(); // Convertir a un array de object[][]
            }


            this.dataGridView2.Rows.Clear();

            foreach (var row in matched)
            {
                this.dataGridView2.Rows.Add(row);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CategoriaAdmi().Show();
        }
    }
}
