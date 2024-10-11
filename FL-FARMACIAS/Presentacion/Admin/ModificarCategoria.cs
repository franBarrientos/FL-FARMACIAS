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
    public partial class ModificarCategoria : Form
    {
        public productoSubMenu productoSubMenu;
        public ModificarCategoria(productoSubMenu m, CategoriaDominio c)
        {
            InitializeComponent();
            this.productoSubMenu = m;
            this.textBox1.Text = c.id.ToString();
            this.TC_descripcion.Text = c.descripcion;
            if (c.estado == true)
            {
                CC_activo.Checked = true;
            }
            else
            {
                CC_inactivo.Checked = true;
            }
        }

        private void Bagregar_categoria_Click(object sender, EventArgs e)
        {
            String descripcion = TC_descripcion.Text.Trim();
            
            if (descripcion == "" || (CC_inactivo.Checked == false && CC_activo.Checked == false))
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(descripcion) || !descripcion.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Por favor, ingrese solo letras el campo de descripcion.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (descripcion != "" )
            {
                MessageBox.Show("La descripcion: " + descripcion + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Vaciar_campos_categoria_Click(object sender, EventArgs e)
        {
            String descripcion = TC_descripcion.Text.Trim();
            if (descripcion != "" || CC_inactivo.Checked != false || CC_activo.Checked != false)
            {
                TC_descripcion.Clear();
                CC_inactivo.Checked = false;
                CC_activo.Checked = false;
            }else
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que vaciar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void BFalta_vaciarcampos_Click(object sender, EventArgs e)
        {
            String descripcion = TC_descripcion.Text.Trim();
            if (descripcion != "" || CC_inactivo.Checked != false || CC_activo.Checked != false)
            {
                TC_descripcion.Clear();
                CC_inactivo.Checked = false;
                CC_activo.Checked = false;
            }
            else
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que vaciar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void Bagregar_categoria_Click_1(object sender, EventArgs e)
        {
            String descripcion = TC_descripcion.Text.Trim();
            int id = int.Parse(textBox1.Text);


            if (descripcion == "" || (CC_inactivo.Checked == false && CC_activo.Checked == false) || (CC_inactivo.Checked == true && CC_activo.Checked == true))
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (descripcion != "")
            {
                this.productoSubMenu.categoriaApp.ActualizarCategoria(new Dominio.CategoriaDominio(id, descripcion, CC_activo.Checked));
                this.productoSubMenu.fullCategorias();
                MessageBox.Show("La descripcion: " + descripcion + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CC_activo_CheckedChanged(object sender, EventArgs e)
        {
            if (CC_inactivo.Checked == true)
            {
                CC_inactivo.Checked = false;
            }
        }

        private void CC_inactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (CC_activo.Checked == true)
            {
                CC_activo.Checked = false;
            }
        }
    }
}
