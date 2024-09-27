using FL_FARMACIAS.Presentacion.Farmaceutico;
using FL_FARMACIAS.Presentacion.Login;
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
        private LoginForm sesioninicio = new LoginForm();

        //fijarse porque no se cierra cuando se presiona cerrar sesion
        private AltaEmpleado altaEmpleado = null;
        private AgrerarProductoAdmi AltaProducto = null;
        private Vaciar_campos_categoria AltaCategoria = null;
        private AltaProveedor AltaProveedor = null;
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

        //cierra la sesion cuando presiona cerrar sesion, pero los formularios que son alta producto cat empleado y proveedor no cierran
        private void cerrar_sesion_Click(object sender, EventArgs e)
        {
            
        DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar sesión?",
                "Confirmar cierre de sesión",
                MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
          
            if (result == DialogResult.Yes)
            {  // por si queda abierto algun formulario del admin
                if (estadisticosSubMenu != null)
                {
                    estadisticosSubMenu.Close();
                }

                if (descuentosSubMenu != null)
                {
                    descuentosSubMenu.Close();
                }

                if (proveedoresSubMenu != null)
                {

                    proveedoresSubMenu.Close();
                }

                if (productoSubMenu != null)
                {
                    productoSubMenu.Close();
                }

                if (empleadoSubMenu != null)
                {

                    empleadoSubMenu.Close();
                }
                //REVISAR PORQUE NO SE CIERRAR....
                if (altaEmpleado != null)
                {

                    altaEmpleado.Close();
                }

                if (AltaProducto != null && !AltaProducto.IsDisposed)
                {
                    AltaProducto.Close();
                }

                if (AltaCategoria != null)
                {
                    AltaCategoria.Close();
                }

                if (AltaProveedor != null)
                {
                    AltaProveedor.Close();
                }
                

                this.Close();

                sesioninicio.Show();
            }
          
        }
       }
}
