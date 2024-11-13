using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using FL_FARMACIAS.Presentacion.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Net;


namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class EmpleadoSubMenu : Form
    {
        private AltaEmpleado altaEmpleado = null;
        public EmpleadoAplicacion empleadoApp;

        private object[][] orgEmployess = new object[][]
                {
        new object[] { "1", "Juan", "Pérez", "M", "12345678", "20-12345678-9", "555-1234", "Farmaceutico", "30000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "2", "Ana", "Gómez", "F", "87654321", "27-87654321-5", "555-5678", "Farmaceutico", "32000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "3", "Carlos", "Martínez", "M", "11223344", "20-11223344-0", "555-6789", "Farmaceutico", "50000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "4", "Laura", "Rodríguez", "F", "22334455", "27-22334455-8", "555-7890", "Farmaceutico", "45000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "5", "Miguel", "López", "M", "33445566", "20-33445566-1", "555-8901", "Farmaceutico", "31000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "6", "Lucía", "Hernández", "F", "44556677", "27-44556677-3", "555-9012", "Farmaceutico", "29000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "7", "Roberto", "González", "M", "55667788", "20-55667788-5", "555-0123", "Farmaceutico", "38000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "8", "Sofía", "Fernández", "F", "66778899", "27-66778899-7", "555-1235", "Farmaceutico", "27000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "9", "Pedro", "Ramírez", "M", "77889900", "20-77889900-9", "555-2346", "Farmaceutico", "47000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "10", "Marta", "Sánchez", "F", "88990011", "27-88990011-1", "555-3457", "Farmaceutico", "36000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "11", "Diego", "Torres", "M", "99001122", "20-99001122-3", "555-4568", "Farmaceutico", "31000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "12", "María", "Cruz", "F", "00112233", "27-00112233-5", "555-5679", "Farmaceutico", "29000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "13", "Luis", "Flores", "M", "11223344", "20-11223344-6", "555-6780", "Gerente", "52000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "14", "Elena", "Morales", "F", "22334455", "27-22334455-8", "555-7891", "Farmaceutico", "28000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "15", "Javier", "Díaz", "M", "33445566", "20-33445566-0", "555-8902", "Supervisor", "39000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "16", "Carla", "Suárez", "F", "44556677", "27-44556677-2", "555-9013", "Supervisor", "29500", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "17", "Alberto", "Pérez", "M", "55667788", "20-55667788-4", "555-0124", "Supervisor", "48000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "18", "Patricia", "Ramos", "F", "66778899", "27-66778899-6", "555-1236", "Supervisor", "46000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "19", "Fernando", "Herrera", "M", "77889900", "20-77889900-8", "555-2347", "Supervisor", "31500", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "20", "Sandra", "Gutiérrez", "F", "88990011", "27-88990011-0", "555-3458", "Supervisor", "37000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "21", "Esteban", "Jiménez", "M", "99001122", "20-99001122-2", "555-4569", "Supervisor", "31000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "22", "Julia", "Navarro", "F", "00112233", "27-00112233-4", "555-5680", "Supervisor", "30000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "23", "Manuel", "Mendoza", "M", "11223344", "20-11223344-5", "555-6791", "Supervisor", "53000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "24", "Verónica", "Ortiz", "F", "22334455", "27-22334455-7", "555-7892", "Supervisor", "30000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "25", "Raúl", "Castro", "M", "33445566", "20-33445566-9", "555-8903", "Supervisor", "40000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "26", "Alicia", "Blanco", "F", "44556677", "27-44556677-1", "555-9014", "Supervisor", "46500", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "27", "Ignacio", "Pardo", "M", "55667788", "20-55667788-3", "555-0125", "Supervisor", "49000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "28", "Rosa", "Gil", "F", "66778899", "27-66778899-5", "555-1237", "Supervisor", "27500", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "29", "Tomás", "Velázquez", "M", "77889900", "20-77889900-7", "555-2348", "Supervisor", "32000", "20/04/24" ,"Usuario", "Eliminar", "Modificar" },
        new object[] { "30", "Silvia", "Campos", "F", "88990011", "27-88990011-9", "555-3459", "Supervisor", "37500", "20/04/24" ,"Usuario", "Eliminar", "Modificar" }
                };

        public EmpleadoSubMenu()
        {
            InitializeComponent();
            if (LoginForm.user.rol.descripcion == "Admin")
            {
                BFalta_ingresarcli.Hide();
            }
            this.empleadoApp = new EmpleadoAplicacion();
            this.fullFiltros();
            this.fullDefault();
          
        }

        public void fullFiltros()
        {

            List<CargoDominio> matcheds = this.empleadoApp.ObtenerCargos();
            matcheds.RemoveAll(cargo => cargo.descripcion == "Admin");
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add("Todos");
            foreach (var e in matcheds)
            {
                this.comboBox1.Items.Add(e.descripcion);
            }
            this.comboBox1.SelectedIndex = 0;
        }

        public void fullDefault()
        {

            List<Empleadodominio> matcheds = this.empleadoApp.ObtenerTodos();
            this.dataGridView1.Rows.Clear();
            foreach (var e in matcheds)
            {
                Image defaultImage = null;
                if (e.foto != null)
                {
                    using (var ms = new MemoryStream(e.foto))
                    {
                        defaultImage = Image.FromStream(ms);
                    }
                }
                this.dataGridView1.Rows.Add(e.id, defaultImage, e.nombre, e.apellido, e.sexo == true ? "M" : "F", e.dni, e.cuil, e.telefono, e.cargo.descripcion, e.salario, e.fechaingreso, e.estado == true ? "ACTIVO" : "INACTIVO", "Usuario", "Modificar", "Eliminar");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var emp = this.empleadoApp.BuscarEmpleado(this.dataGridView1.Rows[e.RowIndex].Cells["DNI"].Value.ToString(), null, null);
                var dataGridView = sender as DataGridView;

                if (dataGridView.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    //pregunrar seguro deseas elimianr?
                    if (!emp.estado)
                    {
                        MessageBox.Show("No se puede eliminar un empleado NO activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el empleado " + emp.apellido + " " + emp.nombre + "?",
                                                              "Confirmar eliminación",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        this.empleadoApp.BorrarEmpleado(emp.id);
                        this.fullDefault();
                        MessageBox.Show("Empleado eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                // Verifica si la columna clicada es "Modificar"
                else if (dataGridView.Columns[e.ColumnIndex].Name == "MODIFICAR")
                {
                    new ModificarEmpleado(this, emp).Show();
                }
                else if (dataGridView.Columns[e.ColumnIndex].Name == "USUARIO")
                {
                    Empleadodominio ed = this.empleadoApp.BuscarEmpleado(dataGridView.Rows[e.RowIndex].Cells["DNI"].Value.ToString(), null, null);
                    new CrearCuentaModal(this, ed).Show();
                }
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


        private void button1_Click(object sender, EventArgs e)
        {
            string dni = null;
            string apellido = null;
            string cargo = null;
            DateTime desde = dateTimePicker1.Value;
            DateTime hasta = dateTimePicker2.Value;

            if (!(textBox1.Text.Trim() == "INGRESE DNI O APELLIDO" || textBox1.Text.Trim() == ""))
            {
                if (textBox1.Text.All(char.IsDigit))
                {
                    dni = textBox1.Text;
                }
                else
                {
                    apellido = textBox1.Text;
                }
            }

            if (comboBox1.Text != "Todos")
            {
                cargo = comboBox1.Text;
            }

            List<Empleadodominio> matcheds = this.empleadoApp.BuscarEmpleados(dni, apellido, cargo, desde, hasta);
            matcheds.RemoveAll(em => em.cargo.descripcion == "Admin");
            this.dataGridView1.Rows.Clear();
            foreach (var em in matcheds)
            {
                Image defaultImage = null;
                if (em.foto != null)
                {
                    using (var ms = new MemoryStream(em.foto))
                    {
                        defaultImage = Image.FromStream(ms);
                    }
                }
                this.dataGridView1.Rows.Add(em.id, defaultImage, em.nombre, em.apellido, em.sexo == true ? "M" : "F", em.dni, em.cuil, em.telefono, em.cargo.descripcion, em.salario, em.fechaingreso, em.estado == true ? "ACTIVO" : "INACTIVO", "Usuario", "Modificar", "Eliminar");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "Todos";
            dateTimePicker1.Value = new DateTime(1960, 1, 1);
            dateTimePicker2.Value = DateTime.Now;
            this.fullDefault();
        }

        private void ShowAltaEmpleado()
        {
            if (altaEmpleado == null || altaEmpleado.IsDisposed)
            {
                altaEmpleado = new AltaEmpleado(this);
                altaEmpleado.Show();
            }
            else
            {
                altaEmpleado.BringToFront(); // Trae el formulario existente al frente
            }
        }
        private void BFalta_ingresarcli_Click(object sender, EventArgs e)
        {
            ShowAltaEmpleado();
            //new AltaEmpleado().Show();

        }
    }
}
