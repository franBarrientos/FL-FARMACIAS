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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EmpleadoSubMenu().Show();
        }
    
       
        private void button2_Click(object sender, EventArgs e)
        {
            new productoSubMenu().Show();
        }

        private void p_Click(object sender, EventArgs e)
        {
            new ProveedoresSubMenu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DescuentosSubMenu().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new EstadisticasSubMenu().Show();
        }
    }
}
