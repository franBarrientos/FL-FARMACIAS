using FL_FARMACIAS.Dominio;
using FL_FARMACIAS.Presentacion.Admin;
using FL_FARMACIAS.Presentacion.Farmaceutico;
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

namespace FL_FARMACIAS.Presentacion.Login
{
    public partial class LoginForm : Form
    {
        private List<UsuarioDominio> defaultUsers = new List<UsuarioDominio>()
        {
            new UsuarioDominio("admin", "admin", Rol.Admin),
            new UsuarioDominio("supervisor", "supervisor", Rol.Supervisor),
            new UsuarioDominio("farmaceutico", "farmaceutico", Rol.Farmaceutico),
        };
        

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Bingresar_login_Click(object sender, EventArgs e)
        {
            string usuario = usuario_login.Text;
            string clave = contraseña_login.Text;

            UsuarioDominio usuarioEncontrado = this.defaultUsers.FirstOrDefault(x => x.usuario.Equals(usuario) && x.clave.Equals(clave));

            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuarioEncontrado.rol == Rol.Admin)
            {
                new MenuAdmin().Show(this);
                return;
            }

            if (usuarioEncontrado.rol == Rol.Farmaceutico)
            {
                new MenuFarmaceutico().Show(this);
                return;
            }

            if (usuarioEncontrado.rol == Rol.Supervisor)
            {
                new MenuSupervisor().Show(this);
                return;
            }

        }
        

        private void Beliminar_login_Click(object sender, EventArgs e)
        {
            usuario_login.Clear();
            contraseña_login.Clear();
        }
    }
}
