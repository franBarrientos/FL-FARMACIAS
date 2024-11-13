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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Aplica formato de moneda en las columnas "Precio Venta" y "Subtotal"
            if (dataGridView1.Columns.Contains("Precio Venta"))
            {
                dataGridView1.Columns["Precio Venta"].DefaultCellStyle.Format = "C2";
                dataGridView1.Columns["Precio Venta"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("es-AR");
            }

            if (dataGridView1.Columns.Contains("Subtotal"))
            {
                dataGridView1.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
                dataGridView1.Columns["Subtotal"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("es-AR");
            }
        }
    }

}
