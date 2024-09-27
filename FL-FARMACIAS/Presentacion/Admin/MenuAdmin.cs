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
        private EmpleadoSubMenu empleadoSubMenu = null;
        private productoSubMenu productoSubMenu = null;
        private ProveedoresSubMenu proveedoresSubMenu = null;
        private DescuentosSubMenu descuentosSubMenu = null;
        private EstadisticasSubMenu estadisticosSubMenu = null;
        private void ShowEmpleadoSubMenu()
        {
            if (empleadoSubMenu == null || empleadoSubMenu.IsDisposed)
            {
                empleadoSubMenu = new EmpleadoSubMenu();
                empleadoSubMenu.Show();
            }
            else
            {
                empleadoSubMenu.BringToFront(); // Trae el formulario existente al frente
            }
        }

        private void ShowproductoSubMenu()
        {
            if (productoSubMenu == null || productoSubMenu.IsDisposed)
            {
                productoSubMenu = new productoSubMenu();
                productoSubMenu.Show();
            }
            else
            {
                productoSubMenu.BringToFront(); // Trae el formulario existente al frente
            }
        }

        private void ShowproveedoresSubMenu()
        {
            if (proveedoresSubMenu == null || proveedoresSubMenu.IsDisposed)
            {
                proveedoresSubMenu = new ProveedoresSubMenu();
                proveedoresSubMenu.Show();
            }
            else
            {
                proveedoresSubMenu.BringToFront(); 
            }
        }

        private void ShowdescuentosSubMenu()
        {
            if (descuentosSubMenu == null || descuentosSubMenu.IsDisposed)
            {
                descuentosSubMenu = new DescuentosSubMenu();
                descuentosSubMenu.Show();
            }
            else
            {
                descuentosSubMenu.BringToFront(); 
            }
        }

        private void ShowdestadisticoSubMenu()
        {
            if (estadisticosSubMenu == null || estadisticosSubMenu.IsDisposed)
            {
                estadisticosSubMenu = new EstadisticasSubMenu();
                estadisticosSubMenu.Show();
            }
            else
            {
                estadisticosSubMenu.BringToFront();
            }
        }
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowEmpleadoSubMenu();
        }
        
       
        private void button2_Click(object sender, EventArgs e)
        {
            ShowproductoSubMenu();
        }

        private void p_Click(object sender, EventArgs e)
        {
            ShowproveedoresSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowdescuentosSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowdestadisticoSubMenu();
        }
    }
}
