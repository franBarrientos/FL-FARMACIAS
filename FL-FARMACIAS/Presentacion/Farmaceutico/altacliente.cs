using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Farmaceutico
{
    public partial class AltaCliente : Form
    {
        public ClienteSubMenu cMenu;
        public AltaCliente(ClienteSubMenu c)
        {
            InitializeComponent();
            this.cMenu = c;
            fullObraSociales();
           
        }

        public void fullObraSociales()
        {
            this.DFalta_obrasocial.Items.Clear();
            foreach (var d in this.cMenu.descuentoApp.BuscarDescuentos(null, null, true))
            {
                this.DFalta_obrasocial.Items.Add(d.descripcion);
            }
        }
        private void BFalta_ingresarcli_Click(object sender, EventArgs e)
        {
            String nombre = Tnombre_cliente.Text.Trim();
            String apellido = Tapellido_cliente.Text.Trim();
            String dni = Tdni_cliente.Text.Trim();
            String obrasocial = DFalta_obrasocial.Text.Trim();
            String telefono = Ttelefono_cliente.Text.Trim();

            if (nombre == "" || apellido == "" || dni == "" || telefono == "" || obrasocial == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (string.IsNullOrWhiteSpace(nombre) || !nombre.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Por favor, ingrese solo letras en el campo Nombre.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(apellido) || !apellido.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Por favor, ingrese solo letras en el campo Apellido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nombre != "" && apellido != "" && dni != "" && telefono != "" && DFalta_obrasocial.Text != "")
            {
                MessageBox.Show("El cliente " + nombre + " " + apellido + " " + "numero de DNI: " + dni + "obra social: " + DFalta_obrasocial.Text + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BFalta_vaciarcampos_Click(object sender, EventArgs e)
        {
            String nombre = Tnombre_cliente.Text.Trim();
            String apellido = Tapellido_cliente.Text.Trim();
            String dni = Tdni_cliente.Text.Trim();
            String obrasocial = DFalta_obrasocial.Text.Trim();
            String telefono = Ttelefono_cliente.Text.Trim();

            if (nombre != "" || apellido != "" || dni != "" || telefono != "" || obrasocial != "")
            {
              Tnombre_cliente.Clear();
            Tapellido_cliente.Clear();
            Tdni_cliente.Clear();
            Ttelefono_cliente.Clear();
            DFalta_obrasocial.Text = " ";
            }
            else
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que vaciar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
