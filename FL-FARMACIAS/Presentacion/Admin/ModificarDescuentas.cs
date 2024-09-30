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

        public Dictionary<string, List<string>> provArr = StaticBD.provinciasYLocalidades;
        public DescuentosSubMenu DescuentosSubMenu;

        public ModificarDescuentas(DescuentoDominio p, DescuentosSubMenu m)
        {
            InitializeComponent();
            this.DescuentosSubMenu = m;
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
            porcentaje.Replace(',', '.');

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

            if (string.IsNullOrWhiteSpace(descripcion) || !descripcion.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Por favor, ingrese solo letras el campo de descripcion.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!porcentaje.All(c => char.IsDigit(c) || c == '.') || Convert.ToDouble(porcentaje) < 0 || Convert.ToDouble(porcentaje) > 100)
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo porcentaje.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DescuentosSubMenu.descuentosAplicacion.ActualizarDescuento(new DescuentoDominio(int.Parse(id),  descripcion, Convert.ToDouble(porcentaje), checkBox1.Checked));
            MessageBox.Show("El descuento" + id + "con la descripcion: " + descripcion + ", cuenta con un porcentaje de descuento del " + porcentaje + "% ha sido modificado con exito.", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DescuentosSubMenu.fullDeaults();
            this.Close();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
