using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using FL_FARMACIAS.Presentacion.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Farmaceutico
{
    public partial class ClienteSubMenu : Form
    {

        private AltaCliente altaCliente;
        public ClienteAplicacion clienteApp;
        public DescuentoAplicacion descuentoApp;

        private object[][] orgEmployess = new object[][]
                {
        new object[] { "30", "Silvia", "Campos", "F", "88990011", "27-88990011-9", "555-3459", "Supervisor", "37500", "20/04/24" ,"Usuario", "Eliminar", "Modificar" }
                };

        public ClienteSubMenu()
        {
            InitializeComponent();
            this.clienteApp = new ClienteAplicacion();
            this.descuentoApp = new DescuentoAplicacion();
            fullDefaults();
            fullFiltros();
        }

        public void fullFiltros()
        {
            List<DescuentoDominio> matcheds = this.descuentoApp.BuscarDescuentos(null, null, true);
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add("Todos");
            foreach (var d in matcheds)
            {
                this.comboBox1.Items.Add(d.descripcion);
            }
            this.comboBox1.SelectedIndex = 0;
        }

        public void fullDefaults()
        {
            List<ClienteDominio> matcheds = this.clienteApp.ObtenerTodos();
            this.dataGridView1.Rows.Clear();
            this.placeholderTextBox1.Text = "INGRESE DNI O APELLIDO";
            this.placeholderTextBox1.ForeColor = Color.Gray;
            this.comboBox1.SelectedIndex = 0;

            foreach (var c in matcheds){
                this.dataGridView1.Rows.Add(c.id, c.nombre, c.apellido, c.dni, c.telefono,c.idDescuento, c.desc.descripcion, c.activo ? "ACTIVO" : "INACTIVO" ,  "MODIFICAR", "ELIMINAR");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var dataGridView = sender as DataGridView;

                if (dataGridView.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    // Aquí colocas el código que se ejecuta al hacer clic en el botón "Eliminar"
                    MessageBox.Show($"Eliminar fila {e.RowIndex}");
                    // Ejemplo: eliminar la fila
                    dataGridView.Rows.RemoveAt(e.RowIndex);
                }
                // Verifica si la columna clicada es "Modificar"
                else if (dataGridView.Columns[e.ColumnIndex].Name == "MODIFICAR")
                {
                   
                    var nombre = dataGridView.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                    var apellido = dataGridView.Rows[e.RowIndex].Cells["APELLIDO"].Value.ToString();
                    var dni = dataGridView.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
                    var telefono = dataGridView.Rows[e.RowIndex].Cells["TELEFONO"].Value.ToString();
                    var idDesc = dataGridView.Rows[e.RowIndex].Cells["DESCUENTOID"].Value.ToString();
                    var desDesc = dataGridView.Rows[e.RowIndex].Cells["DESCUENTO"].Value.ToString();

                    var activo = dataGridView.Rows[e.RowIndex].Cells["ESTADO"].Value.ToString() == "ACTIVO";

                    var desc = this.descuentoApp.ObtenerDescuentoPorDescripcion(desDesc);
                    var id = int.Parse(dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    new ModificarCliente(this, new ClienteDominio(id, nombre, apellido, dni, telefono, activo, desc)).Show();
                
                }
               
            }

        }


    

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();

            foreach (var row in this.orgEmployess)
            {
                this.dataGridView1.Rows.Add(row);
            }
        }

      

        private void BFalta_ingresarcli_Click(object sender, EventArgs e)
        {
            if (altaCliente == null || altaCliente.IsDisposed)
            {
                altaCliente = new AltaCliente(this);
                altaCliente.Show();
            }
            else
            {
                altaCliente.BringToFront(); // Trae el formulario existente al frente
            }
        }
    }
}
