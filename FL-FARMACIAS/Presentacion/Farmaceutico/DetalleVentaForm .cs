using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Farmaceutico
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class DetalleVentaForm : Form
    {
        public DetalleVentaForm()
        {
            InitializeComponent();
        }

        // Método para cargar el DataTable en el DataGridView
        public void CargarDetalles(DataTable detalles)
        {
            dataGridView1.DataSource = detalles;
        }
    }

}
