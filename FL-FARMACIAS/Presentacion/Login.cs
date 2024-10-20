using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using FL_FARMACIAS.Presentacion.Admin;
using FL_FARMACIAS.Presentacion.Farmaceutico;
using FL_FARMACIAS.Presentacion.Supervisor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Login
{
    public partial class LoginForm : Form
    {
        //        private LoginForm loginmenu = null;

        public static UsuarioDominio user { get; set; }
        public UsuarioAplicacion usuarioApp { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            this.usuarioApp = new UsuarioAplicacion();
            WarmUpDatabaseConnection();

        }

        private void WarmUpDatabaseConnection()
        {
            try
            {
                using (var context = new DBConnect())
                {
                    var count = context.Cliente.Count();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurren
                MessageBox.Show("Error warming up the database: " + ex.Message);
            }
        }
        private void Bingresar_login_Click(object sender, EventArgs e)
        {
            string usuario = usuario_login.Text;
            string clave = contraseña_login.Text;
            this.Hide();//oculta el formulario login
            try
            {
                UsuarioDominio usuarioEncontrado = this.usuarioApp.ObtenerUsuarioPorUserPassw(usuario, clave);
                LoginForm.user = usuarioEncontrado;
                if (usuarioEncontrado.rol.descripcion == "Admin")
                {
                    new MenuAdmin(this).Show(this);
                    this.Beliminar_login_Click(sender, e);
                    this.Hide();
                    return;

                }

                if (usuarioEncontrado.rol.descripcion == "Farmaceutico")
                {
                    new MenuFarmaceutico(this).Show(this);
                    this.Beliminar_login_Click(sender, e);
                    this.Hide();
                    return;
                }

                if (usuarioEncontrado.rol.descripcion == "Supervisor")
                {
                    new MenuSupervisor(this).Show(this);
                    this.Beliminar_login_Click(sender, e);
                    this.Hide();
                    return;
                }
            }
            catch (Exception ex) {
                 MessageBox.Show("Error: " + ex.Message);
                this.Beliminar_login_Click(sender, e);
                this.Show();
                return;
            }
            

        }
        

        private void Beliminar_login_Click(object sender, EventArgs e)
        {
            usuario_login.Clear();
            contraseña_login.Clear();
        }

        // en caso de que se cierre el login con la crucecita se cierra todo el programa
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void enter(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Enter)
                {
                    this.Bingresar_login_Click(sender, e);
                }
        }

        
    }
}
