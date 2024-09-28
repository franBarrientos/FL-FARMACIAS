using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class AltaPedido : Form
    {

        public Dictionary<string, List<string>> provArr = BD.provinciasYLocalidades;

        public AltaPedido()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(provincia_pedido.Text == "" || provincia_pedido.Text == null)
            {
                MessageBox.Show("Selecciona una provincia antes de seleccionar una localidad", "Entrada Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void onChangeSelectedProv(object sender, EventArgs e)
        {
            string prov = provincia_pedido.Text;
            localidad_pedido.Items.Clear();
            foreach (var loc in provArr[prov]){
                localidad_pedido.Items.Add(loc);
            }
        }

        private void BFalta_ingresarcli_Click(object sender, EventArgs e)
        {

        }

        private void BFalta_ingresarcli_Click_1(object sender, EventArgs e)
        {
            String nombre = Tnombre_pedido.Text.Trim();
            String cuit = Tcuit_pedido.Text.Trim();
            String dni = dni_pedido.Text.Trim();
            String provincia = provincia_pedido.Text.Trim();
            String localidad = localidad_pedido.Text.Trim();
            String direccion = direccion_pedido.Text.Trim();
            String correo = correo_pedido.Text.Trim();
            String telefono = telefono_pedido.Text.Trim();
            if (nombre == "" || cuit == "" || dni == "" || provincia == "" || localidad == "" || direccion == "" || correo == "" || telefono == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!nombre.All(char.IsLetter))
            {
                MessageBox.Show("Por favor, ingrese solo letras el campo de Nombre del proveedor.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!cuit.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo cuil en el campo cuit.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cuit.Length != 11)
            {
                MessageBox.Show("Por favor, ingrese un numero de cuil de 11 digitos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Por favor, ingrese solo números en el campo telefono.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (telefono.Length != 10)
            {
                MessageBox.Show("Por favor, ingrese un numero de telefono de 10 digitos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarGmail_proveedor(correo))
            {
                MessageBox.Show("El correo no es válido. Asegúrate de que sea un correo de Gmail.");
            }

            if (nombre != "" && cuit != "" && dni != "" && correo != "" && telefono != "" && ValidarGmail_proveedor(correo) && provincia != "" && localidad != "" && direccion != "")
            {
                MessageBox.Show("El pedido" + nombre + "," + "D.N.I:" + dni + "CUIT: " + cuit + "CORREO:" + correo  +"TELEFONO:" + telefono + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private bool ValidarGmail_proveedor(string email)
        {
            // Expresión regular para validar correos de Gmail
            string restricciones = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, restricciones);
        }

        private void BFalta_vaciarcampos_Click(object sender, EventArgs e)
        {
            String nombre = Tnombre_pedido.Text.Trim();
            String cuit = Tcuit_pedido.Text.Trim();
            String dni = dni_pedido.Text.Trim();
            String provincia = provincia_pedido.Text.Trim();
            String localidad = localidad_pedido.Text.Trim();
            String direccion = direccion_pedido.Text.Trim();
            String correo = correo_pedido.Text.Trim();
            String telefono = telefono_pedido.Text.Trim();
            if (nombre != "" || cuit != "" || dni != "" || provincia != "" || localidad != "" || direccion != "" || correo != "" || telefono != "")
            {
                Tnombre_pedido.Clear();
                Tcuit_pedido.Clear();
                dni_pedido.Clear();
                provincia_pedido.Text = " ";
                localidad_pedido.Text=" ";
                direccion_pedido.Clear();
                correo_pedido.Clear();
                telefono_pedido.Clear();
            }
            else
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que vaciar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
