using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class AltaDescuentos : Form
    {

        public Dictionary<string, List<string>> provArr = BD.provinciasYLocalidades;

        public AltaDescuentos()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (inactivo_descuento.Checked)
            {
                inactivo_descuento.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (activo_descuento.Checked)
            {
                activo_descuento.Checked = false;
            }
        }

        private void BFalta_ingresarcli_Click(object sender, EventArgs e)
        {
            String descripcion = descripcion_descuento.Text.Trim();
            String porcentaje = porcentaje_descuento.Text.Trim();

            if (descripcion == " " || porcentaje == " "  || (activo_descuento.Checked == false && inactivo_descuento.Checked == false))
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!descripcion.All(char.IsLetter))
            {
                MessageBox.Show("Por favor, ingrese solo letras el campo de Nombre.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!porcentaje.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo DNI.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (descripcion != "" && porcentaje != "")
            {
                MessageBox.Show("El descuento con la descripcion: " + descripcion + ", cuenta con un porcentaje de descuento" + porcentaje + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BFalta_vaciarcampos_Click(object sender, EventArgs e)
        {

            String descripcion = descripcion_descuento.Text.Trim();
            String porcentaje = porcentaje_descuento.Text.Trim();
            if (descripcion != " " || porcentaje != " " )
            {
                descripcion_descuento.Clear();
                porcentaje_descuento.Clear();

            }
            else
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que vaciar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
