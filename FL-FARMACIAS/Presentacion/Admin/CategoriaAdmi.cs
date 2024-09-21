using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class CategoriaAdmi : Form
    {
        public CategoriaAdmi()
        {
            InitializeComponent();
        }

        private void Bagregar_categoria_Click(object sender, EventArgs e)
        {
            String descripcion = TC_descripcion.Text.Trim();
            

            if (descripcion == "" || (CC_inactivo.Checked == false && CC_activo.Checked == false))
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (descripcion != "" )
            {
                MessageBox.Show("La descripcion: " + descripcion + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
