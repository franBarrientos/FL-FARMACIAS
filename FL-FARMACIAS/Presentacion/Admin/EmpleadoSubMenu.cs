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
    public partial class EmpleadoSubMenu : Form
    {
        private object[][] orgEmployess = new object[][]
                {
        new object[] { "1", "Juan", "Pérez", "M", "12345678", "20-12345678-9", "555-1234", "Farmaceutico", "30000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "2", "Ana", "Gómez", "F", "87654321", "27-87654321-5", "555-5678", "Farmaceutico", "32000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "3", "Carlos", "Martínez", "M", "11223344", "20-11223344-0", "555-6789", "Farmaceutico", "50000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "4", "Laura", "Rodríguez", "F", "22334455", "27-22334455-8", "555-7890", "Farmaceutico", "45000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "5", "Miguel", "López", "M", "33445566", "20-33445566-1", "555-8901", "Farmaceutico", "31000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "6", "Lucía", "Hernández", "F", "44556677", "27-44556677-3", "555-9012", "Farmaceutico", "29000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "7", "Roberto", "González", "M", "55667788", "20-55667788-5", "555-0123", "Farmaceutico", "38000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "8", "Sofía", "Fernández", "F", "66778899", "27-66778899-7", "555-1235", "Farmaceutico", "27000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "9", "Pedro", "Ramírez", "M", "77889900", "20-77889900-9", "555-2346", "Farmaceutico", "47000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "10", "Marta", "Sánchez", "F", "88990011", "27-88990011-1", "555-3457", "Farmaceutico", "36000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "11", "Diego", "Torres", "M", "99001122", "20-99001122-3", "555-4568", "Farmaceutico", "31000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "12", "María", "Cruz", "F", "00112233", "27-00112233-5", "555-5679", "Farmaceutico", "29000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "13", "Luis", "Flores", "M", "11223344", "20-11223344-6", "555-6780", "Gerente", "52000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "14", "Elena", "Morales", "F", "22334455", "27-22334455-8", "555-7891", "Farmaceutico", "28000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "15", "Javier", "Díaz", "M", "33445566", "20-33445566-0", "555-8902", "Supervisor", "39000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "16", "Carla", "Suárez", "F", "44556677", "27-44556677-2", "555-9013", "Supervisor", "29500", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "17", "Alberto", "Pérez", "M", "55667788", "20-55667788-4", "555-0124", "Supervisor", "48000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "18", "Patricia", "Ramos", "F", "66778899", "27-66778899-6", "555-1236", "Supervisor", "46000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "19", "Fernando", "Herrera", "M", "77889900", "20-77889900-8", "555-2347", "Supervisor", "31500", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "20", "Sandra", "Gutiérrez", "F", "88990011", "27-88990011-0", "555-3458", "Supervisor", "37000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "21", "Esteban", "Jiménez", "M", "99001122", "20-99001122-2", "555-4569", "Supervisor", "31000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "22", "Julia", "Navarro", "F", "00112233", "27-00112233-4", "555-5680", "Supervisor", "30000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "23", "Manuel", "Mendoza", "M", "11223344", "20-11223344-5", "555-6791", "Supervisor", "53000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "24", "Verónica", "Ortiz", "F", "22334455", "27-22334455-7", "555-7892", "Supervisor", "30000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "25", "Raúl", "Castro", "M", "33445566", "20-33445566-9", "555-8903", "Supervisor", "40000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "26", "Alicia", "Blanco", "F", "44556677", "27-44556677-1", "555-9014", "Supervisor", "46500", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "27", "Ignacio", "Pardo", "M", "55667788", "20-55667788-3", "555-0125", "Supervisor", "49000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "28", "Rosa", "Gil", "F", "66778899", "27-66778899-5", "555-1237", "Supervisor", "27500", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "29", "Tomás", "Velázquez", "M", "77889900", "20-77889900-7", "555-2348", "Supervisor", "32000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "30", "Silvia", "Campos", "F", "88990011", "27-88990011-9", "555-3459", "Supervisor", "37500", "20/04/24" ,"Usuario", "Eliminar", "Modificar" }
                };

        public EmpleadoSubMenu()
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
           this.dataGridView1.Rows.Clear ();
           
            foreach (var row in this.orgEmployess)
            {
                this.dataGridView1.Rows.Add(row);
            }
        }
    }
}
