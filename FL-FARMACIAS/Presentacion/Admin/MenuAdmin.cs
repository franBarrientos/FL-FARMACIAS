using FL_FARMACIAS.Presentacion.Farmaceutico;
using FL_FARMACIAS.Presentacion.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class MenuAdmin : Form
    {
        // Diccionario para almacenar las instancias de los subformularios
        private Dictionary<Type, Form> subFormularios = new Dictionary<Type, Form>();

        private LoginForm loginForm { get; set; }

        public MenuAdmin(LoginForm loginForm)
        {
            InitializeComponent();
            this.label1.Text = "Hola: " + (LoginForm.user.empleado != null ? LoginForm.user.empleado.nombre : LoginForm.user.rol.descripcion);
            this.loginForm = loginForm;
        }

        // Método genérico para mostrar cualquier subformulario
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

        // Evento de los botones que muestran los submenús
        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu<EmpleadoSubMenu>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowSubMenu<productoSubMenu>();
        }

        private void p_Click(object sender, EventArgs e)
        {
            ShowSubMenu<ProveedoresSubMenu>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowSubMenu<DescuentosSubMenu>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowSubMenu<EstadisticasSubMenu>();
        }

        // Método para cerrar sesión y formularios abiertos
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
                    if (!( form is LoginForm))
                    {
                        form.Close();
                    }


                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowSubMenu<backups>();
        }
    }
}
