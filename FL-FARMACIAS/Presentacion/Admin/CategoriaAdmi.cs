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
    public partial class Vaciar_campos_categoria : Form
    {
        public Vaciar_campos_categoria()
        {
            InitializeComponent();
        }

        private void Bagregar_categoria_Click(object sender, EventArgs e)
        {
            String descripcion = TC_descripcion.Text.Trim();
            

            if (descripcion == "" || (CC_inactivo.Checked == false && CC_activo.Checked == false))
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        }
    }
}
