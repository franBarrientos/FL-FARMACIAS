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

            textBox3.Text = p.id.ToString();
            textBox2.Text = p.porcentajeDescuento.ToString();
            textBox1.Text = p.descripcion;
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
    }
}
