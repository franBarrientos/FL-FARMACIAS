using FL_FARMACIAS.Presentacion.Admin;
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

namespace FL_FARMACIAS.Presentacion.Supervisor
{
    public partial class MenuSupervisor : Form
    {
        private Dictionary<Type, Form> subFormularios = new Dictionary<Type, Form>();

        private LoginForm loginForm { get; set; }

        public MenuSupervisor(LoginForm loginForm)
        {
            InitializeComponent();
            this.button6.Text = (LoginForm.user.empleado != null ? LoginForm.user.rol.descripcion.ToUpper() + " " + LoginForm.user.empleado.nombre.ToUpper() : LoginForm.user.rol.descripcion.ToUpper());
            this.loginForm = loginForm;
        }

       
        private void ShowSubMenu<T>() where T : Form, new()
        {
            Form subForm;

            // Si el formulario ya existe en el diccionario y no está cerrado, lo trae al frente
            if (subFormularios.TryGetValue(typeof(T), out subForm) && !subForm.IsDisposed)
            {
                subForm.BringToFront();
            }
            else
            {
                // Si no existe, crea una nueva instancia y la añade al diccionario
                subForm = new T();
                subFormularios[typeof(T)] = subForm;
                subForm.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu<EmpleadoSubMenu>();

        }

        private void cerrar_sesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "¿Estás seguro de que deseas cerrar sesión?",
               "Confirmar cierre de sesión",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {   // Cierra todos los formularios abiertos en el diccionario
                // Cierra todos los formularios abiertos en el diccionario
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    loginForm.Show();
                    if (!(form is LoginForm))
                    {
                        form.Close();
                    }


                }

            }
        }

        private void p_Click(object sender, EventArgs e)
        {
            ShowSubMenu<ProveedoresSubMenu>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowSubMenu<productoSubMenu>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowSubMenu<DescuentosSubMenu>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowSubMenu<EstadisticosFarmaceutico>();
        }
    }
}
