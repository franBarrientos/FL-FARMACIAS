using FL_FARMACIAS.Dominio;
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
    public partial class ModificarDescuentas : Form
    {

        public Dictionary<string, List<string>> provArr = BD.provinciasYLocalidades;

        public ModificarDescuentas(DescuentoDominio p)
        {
            InitializeComponent();

            id_descuento.Text = p.id.ToString();
            porcentaje_edit_descuentos.Text = p.porcentajeDescuento.ToString();
            descripcion_edit_descuentos.Text = p.descripcion;
            if (p.estado == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox2.Checked = true;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void BFalta_ingresarcli_Click(object sender, EventArgs e)
        {
           String id= id_descuento.Text.Trim();
            String descripcion = descripcion_edit_descuentos.Text.Trim();
            String porcentaje = porcentaje_edit_descuentos.Text.Trim();

            if (descripcion == " " || porcentaje == " " || id == " " )
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!id.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo DNI.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (id != "" && descripcion != "" && porcentaje != "")
            {
                MessageBox.Show("El descuento" + id + "con la descripcion: " + descripcion + ", cuenta con un porcentaje de descuento" + porcentaje + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BFalta_vaciarcampos_Click(object sender, EventArgs e)
        {
            String id = id_descuento.Text.Trim();
            String descripcion = descripcion_edit_descuentos.Text.Trim();
            String porcentaje = porcentaje_edit_descuentos.Text.Trim();
            if (descripcion != " " || porcentaje != " " || id != " ")
            {
                id_descuento.Clear();
                descripcion_edit_descuentos.Clear();
                porcentaje_edit_descuentos.Clear();

            }
            else
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que vaciar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
