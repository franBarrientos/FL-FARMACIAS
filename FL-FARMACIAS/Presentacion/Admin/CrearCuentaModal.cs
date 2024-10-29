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
    public partial class CrearCuentaModal : Form
    {
        public Empleadodominio e;
        public EmpleadoSubMenu m;
        public CrearCuentaModal(EmpleadoSubMenu m,  Empleadodominio e)
        {
            InitializeComponent();
            this.e = e;
            this.m = m;
            fullRoles();
            if (!(e.usuario == null))
            {
                label1.Text = "MODIFICAR CUENTA DE EMPLEADO";
                this.comboBox1.Text = e.usuario.rol.descripcion;
                this.textBox1.Text = e.usuario.usuario;
                this.textBox2.Text = e.usuario.clave;
            }     
        }

        public void fullRoles()
        {
            this.comboBox1.Items.Clear();
            foreach(var r in this.m.empleadoApp.ObtenerRoles())
            {
                this.comboBox1.Items.Add(r.descripcion);
            }
        }

        private void BFalta_ingresarcli_Click_1(object sender, EventArgs e)
        {
            var updE = this.e;
            var rol = this.m.empleadoApp.ObtenerRoles().Where(x => x.descripcion == this.comboBox1.Text).FirstOrDefault();
            var pass = SimpleEncryption.Encrypt(this.textBox2.Text);
            updE.usuario = new UsuarioDominio(this.textBox1.Text, pass, rol);
            this.m.empleadoApp.ActualizarEmpleado(updE);
            this.m.fullDefault();
            MessageBox.Show("Cuenta de usuario actualizada");
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
