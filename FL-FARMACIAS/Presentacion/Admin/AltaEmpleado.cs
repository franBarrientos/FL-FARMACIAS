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
    public partial class AltaEmpleado : Form
    {
        public AltaEmpleado()
        {
            InitializeComponent();
        }

        private void Bagregar_empleado_Click(object sender, EventArgs e)
        {
            String nombre = Tnombre_emple.Text.Trim();
            String apellido = Tapellido_emple.Text.Trim();
            String dni = Tdni_emple.Text.Trim();
            String cuil = Tcuil_emple.Text.Trim();
            String telefono = Ttelefono_empleado.Text.Trim();
            String puesto = Cpuesto_empleado.Text.Trim();
            String salario = Tsalario_empleado.Text.Trim();


            float numerosalario;
            bool preciopositivo = float.TryParse(salario, out numerosalario) && numerosalario > 0;

            if (nombre == " " || apellido == " " || dni == " " || cuil == " " || telefono == "" || puesto == " " || salario == " " || (Cmasculino.Checked == false && Cmujer.Checked == false))
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!nombre.All(char.IsLetter))
            {
                MessageBox.Show("Por favor, ingrese solo letras el campo de Nombre.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!apellido.All(char.IsLetter))
            {
                MessageBox.Show("Por favor, ingrese solo letras el campo de Apellido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!dni.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo DNI.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dni.Length != 8)
            {
                MessageBox.Show("Por favor, ingrese un DNI de 8 digitos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!cuil.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo cuil en el campo DNI.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cuil.Length != 11)
            {
                MessageBox.Show("Por favor, ingrese un numero de cuil de 10 digitos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!telefono.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo DNI.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (telefono.Length != 10)
            {
                MessageBox.Show("Por favor, ingrese un numero de telefono de 10 digitos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!preciopositivo)
            {
                MessageBox.Show("Por favor, ingrese solo números positivos en el campo salario .", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          

        }

        private void agregarimagenempleado_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccione su imagen para almacenar";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName; //obtener el nombre de la imagen
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
                fotoempleado.Image = Image.FromFile(FileName);// lo que va en el picturebox

            }
        }

        private void Lsexo_farmaceutico_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si hay una imagen en el PictureBox
            if (fotoempleado.Image != null)
            {
                // Vaciar el PictureBox
                fotoempleado.Image = null;
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen para vaciar.");
            }
        }

        private void Vaciar_campos_nuevo_farmaceutico_Click(object sender, EventArgs e)
        {
            String nombre = Tnombre_emple.Text.Trim();
            String apellido = Tapellido_emple.Text.Trim();
            String dni = Tdni_emple.Text.Trim();
            String cuil = Tcuil_emple.Text.Trim();
            String telefono = Ttelefono_empleado.Text.Trim();
            String puesto = Cpuesto_empleado.Text.Trim();
            String salario = Tsalario_empleado.Text.Trim();

            if (nombre != " " || apellido != " " || dni != " " || cuil != " " || telefono != "" || salario != " " )
            {
                Tnombre_emple.Clear();
                Tapellido_emple.Clear();
                Tdni_emple.Clear();
                Tcuil_emple.Clear();
                Ttelefono_empleado.Clear();
                Tsalario_empleado.Clear();
                Cmasculino.Checked = false;
                Cmujer.Checked = false;
                Cpuesto_empleado.Text = "Ninguno";

            }
            else
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que vaciar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void Cmujer_CheckedChanged(object sender, EventArgs e)
        {
            if (Cmasculino.Checked)
            {
                Cmasculino.Checked = false;
            }
        }

        private void Cmasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (Cmujer.Checked)
            {
                Cmujer.Checked = false;
            }
        }
    }
}
