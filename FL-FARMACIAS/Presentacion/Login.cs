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

        private List<UsuarioDominio> defaultUsers = new List<UsuarioDominio>()
        {
            new UsuarioDominio(1,"admin", "admin", new Rol(1, "Admin")),
            new UsuarioDominio(2,"supervisor", "supervisor", new Rol(2, "Supervisor")) ,
            new UsuarioDominio(3, "farmaceutico", "farmaceutico", new Rol(3, "Farmaceutico")),
        };
        

        public LoginForm()
        {
            InitializeComponent();
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
              
            UsuarioDominio usuarioEncontrado = this.defaultUsers.FirstOrDefault(x => x.usuario.Equals(usuario) && x.clave.Equals(clave));

            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Beliminar_login_Click(sender,e);
                this.Show();
                return;
            }

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
