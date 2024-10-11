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

        public ClienteSubMenu()
        {
            InitializeComponent();
            this.clienteApp = new ClienteAplicacion();
            this.descuentoApp = new DescuentoAplicacion();
            fullDefaults();
            fullFiltros();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void fullFiltros()
        {
            List<DescuentoDominio> matcheds = this.descuentoApp.ObtenerDescuentos();
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
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;

            foreach (var c in matcheds){
                this.dataGridView1.Rows.Add(c.id, c.nombre, c.apellido, c.dni, c.telefono,c.idDescuento, c.desc.descripcion, c.activo ? "ACTIVO" : "INACTIVO" ,  "MODIFICAR", "ELIMINAR");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var dataGridView = sender as DataGridView;
                if (dataGridView.Columns[e.ColumnIndex].Name == "MODIFICAR")
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
                else if (dataGridView.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    var nombre = dataGridView.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                    var apellido = dataGridView.Rows[e.RowIndex].Cells["APELLIDO"].Value.ToString();
                    var dni = dataGridView.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
                    var telefono = dataGridView.Rows[e.RowIndex].Cells["TELEFONO"].Value.ToString();
                    var idDesc = dataGridView.Rows[e.RowIndex].Cells["DESCUENTOID"].Value.ToString();
                    var desDesc = dataGridView.Rows[e.RowIndex].Cells["DESCUENTO"].Value.ToString();

                    var activo = dataGridView.Rows[e.RowIndex].Cells["ESTADO"].Value.ToString() == "ACTIVO";

                    if (!activo)
                    {
                        MessageBox.Show("No se puede eliminar un cliente NO activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var desc = this.descuentoApp.ObtenerDescuentoPorDescripcion(desDesc);
                    var id = int.Parse(dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el cliente " + apellido + " " + nombre + "?",
                                                              "Confirmar eliminación",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        DescuentoDominio descuento = this.descuentoApp.ObtenerDescuentoPorDescripcion(desDesc);
                        this.clienteApp.ActualizarCliente(new ClienteDominio(id, nombre, apellido, dni, telefono, false, descuento));
                        this.fullDefaults();
                        MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
               
            }

        }


    

        private void button2_Click(object sender, EventArgs e)
        {
           fullDefaults();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string idOrApellido = this.placeholderTextBox1.Text;
            if (idOrApellido == "INGRESE DNI O APELLIDO")
            {
                idOrApellido = string.Empty;
            }

            // Tratar de convertir a entero, si es válido se usa como ID
            bool esNumerico = !string.IsNullOrEmpty(idOrApellido) && idOrApellido.All(char.IsDigit);
            string dni = null;
            if (esNumerico)
            {
                dni = idOrApellido;
                idOrApellido = string.Empty;
            }

            // Determinar el estado basándose en los checkboxes
            bool? estado = null;
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                estado = true;  // Activo
            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                estado = false; // Inactivo
            }


            List<ClienteDominio> matched = this.clienteApp.BuscarCliente(dni, idOrApellido, estado, this.comboBox1.Text == "Todos"? null : this.comboBox1.SelectedItem.ToString());
            this.dataGridView1.Rows.Clear();
            foreach (var c in matched) { 
                this.dataGridView1.Rows.Add(c.id, c.nombre, c.apellido, c.dni, c.telefono, c.idDescuento, c.desc.descripcion, c.activo ? "ACTIVO" : "INACTIVO", "MODIFICAR", "ELIMINAR"); 
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { 
                checkBox1.Checked = false;}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Verificar si el valor de la celda es "INACTIVO"
            var estado = dataGridView1.Rows[e.RowIndex].Cells["ESTADO"].Value?.ToString();
            if (estado != "ACTIVO")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;  // Fondo rojo suave
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;       // Texto negro
            }
            else
            {
                // Color de fondo y texto para filas activas
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;  // Fondo verde suave
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;       // Texto negro
            }
        }


    }
}
