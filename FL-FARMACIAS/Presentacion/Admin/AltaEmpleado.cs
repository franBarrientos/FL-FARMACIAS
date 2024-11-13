using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using FL_FARMACIAS.Presentacion.Login;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class AltaEmpleado : Form
    {
        public EmpleadoSubMenu empleadoSubMenu;
        public AltaEmpleado(EmpleadoSubMenu e)
        {
            InitializeComponent();
            this.empleadoSubMenu = e;
            fullCargos();
        }

        private void fullCargos()
        {
            List<CargoDominio> matcheds = this.empleadoSubMenu.empleadoApp.ObtenerCargos();
            matcheds.RemoveAll(cargo => cargo.descripcion == "Admin");
            this.Cpuesto_empleado.Items.Clear();
            foreach (var e in matcheds)
            {
                 this.Cpuesto_empleado.Items.Add(e.descripcion);
            }
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

            if (nombre == "" || apellido == "" || dni == "" || cuil == "" || telefono == "" || puesto == "" || salario == "" || (Cmasculino.Checked == false && Cmujer.Checked == false))
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
                MessageBox.Show("Por favor, ingrese solo numeros en el campo cuil.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cuil.Length != 11)
            {
                MessageBox.Show("Por favor, ingrese un numero de cuil de 11 digitos en el campo cuil.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!telefono.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo telefono.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (nombre != "" || apellido != "" || dni != "" || cuil != "" || telefono != "" || salario != "" )
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

        private void Bagregar_empleado_Click_1(object sender, EventArgs e)
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

            if (nombre == "" || apellido == "" || dni == "" || cuil == "" || telefono == "" || puesto == "" || salario == "" || (Cmasculino.Checked == false && Cmujer.Checked == false) || (Cmasculino.Checked == true && Cmujer.Checked == true) || fotoempleado.Image == null)
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nombre) || !nombre.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Por favor, ingrese solo letras el campo de Nombre.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(apellido) || !apellido.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Por favor, ingrese solo letras el campo de Apellido o no deje vacio.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Por favor, ingrese solo numeros en el campo cuil.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cuil.Length != 11)
            {
                MessageBox.Show("Por favor, ingrese un numero de cuil de 11 digitos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!telefono.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo TELEFONO.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


            // Cargar la imagen y convertirla a un byte[]
            byte[] fotoEmpleadoB;
            using (var memoryStream = new MemoryStream())
            {
                using (var image = fotoempleado.Image)
                {
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg); // Guardar como JPEG
                    fotoEmpleadoB = memoryStream.ToArray(); // Convertir a byte[]
                }
            }
            
            CargoDominio cd = this.empleadoSubMenu.empleadoApp.ObtenerCargoPorDescripcion(puesto);
            Empleadodominio em = new Empleadodominio(nombre, apellido, Cmujer.Checked, dni, cuil, telefono, cd, (float)numerosalario, new DateTime(2024, 10, 12), fotoEmpleadoB);
            this.empleadoSubMenu.empleadoApp.AgregarEmpleado(em);
            this.empleadoSubMenu.fullDefault();

            if (nombre != "" && apellido != "" && dni != "" && cuil != "" && puesto != "" && fotoempleado.Image != null && telefono != "" && salario != "")
            {
                MessageBox.Show("El empleado " + nombre + ","+ apellido + "D.N.I:" + dni + "CUIL: " +cuil  +"PUESTO:"+ puesto+" ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.Close();

        }

        private void Vaciar_campos_nuevo_farmaceutico_Click_1(object sender, EventArgs e)
        {
            String nombre = Tnombre_emple.Text.Trim();
            String apellido = Tapellido_emple.Text.Trim();
            String dni = Tdni_emple.Text.Trim();
            String cuil = Tcuil_emple.Text.Trim();
            String telefono = Ttelefono_empleado.Text.Trim();
            String puesto = Cpuesto_empleado.Text.Trim();
            String salario = Tsalario_empleado.Text.Trim();

            if (nombre != "" || apellido != "" || dni != "" || cuil != "" || telefono != "" || salario != "" || fotoempleado.Image != null)
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
                fotoempleado.Image = null;

            }
            else
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que vaciar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
