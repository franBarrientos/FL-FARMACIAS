using FL_FARMACIAS.Presentacion.Admin;
using FL_FARMACIAS.Presentacion.Farmaceutico;
using FL_FARMACIAS.Presentacion.Login;
using FL_FARMACIAS.Presentacion.Supervisor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_FARMACIAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MenuAdmin().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MenuSupervisor().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MenuFarmaceutico().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }
    }
}
