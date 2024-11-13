using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FL_FARMACIAS.Presentacion.Farmaceutico
{
    public partial class EstadisticosFarmaceutico : Form
    {
        public VentasAplicacion ventasAplicacion;
        public EstadisticosFarmaceutico()
        {
            this.ventasAplicacion = new VentasAplicacion();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var datos = ventasAplicacion.ObtenerCantidadProductosVendidosPorEmpleado();

            // Verifica si hay datos
            if (datos == null || datos.Count == 0)
            {
                MessageBox.Show("No se encontraron datos para mostrar.");
                return; // Salir si no hay datos
            }

            chart1.Series.Clear();
            var series = new Series("Productos Vendidos");
            series.ChartType = SeriesChartType.Bar;

            foreach (var dato in datos)
            {
                Console.WriteLine(dato.empleadoNombre.ToString());
                Console.WriteLine(dato.cantidadProductos.ToString());
                series.Points.AddXY(dato.empleadoNombre, dato.cantidadProductos);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Empleados";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad de Productos Vendidos";
            chart1.Invalidate(); // Refresca el gráfico

             DateTime desde = new DateTime(1970, 1, 1);
         
            CargarGrafico( desde, DateTime.Now);
            CargarGraficoTorta();
            CargarDatosEnGrid();
        }

        //grafico 2
        private void CargarGrafico(DateTime desde, DateTime hasta)
        {
            
            var ventasAplicacion = new VentasAplicacion();
            var ingresos = ventasAplicacion.ObtenerIngresosPorEmpleado(desde, hasta);

            chartIngresos.Series.Clear();
            chartIngresos.Titles.Clear();
            var serie = chartIngresos.Series.Add("Ingresos por Empleado");

            foreach (var ingreso in ingresos)
            {
                serie.Points.AddXY(ingreso.Key, ingreso.Value);
            }

            // Configuración adicional del gráfico
            chartIngresos.ChartAreas[0].AxisX.Title = "Empleados";
            chartIngresos.ChartAreas[0].AxisY.Title = "Ingresos";
        }

        //grafico torta 
        private void CargarGraficoTorta()
        {
            var ventasAplicacion = new VentasAplicacion();
            var topEmpleados = ventasAplicacion.ObtenerTopEmpleadosPorVentas(10);


            chartVentas.Series.Clear();
            var serie = chartVentas.Series.Add("Ventas por Empleado");

            foreach (var empleado in topEmpleados)
            {
                //serie.Points.AddXY(empleado.EmpleadoNombre, empleado.TotalVentas);
                int puntoIndex = serie.Points.AddXY(empleado.EmpleadoNombre, empleado.TotalVentas);
                serie.Points[puntoIndex].Label = $"{empleado.EmpleadoNombre}: {empleado.TotalVentas}";
            }

            // Configuración adicional del gráfico
            chartVentas.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False; // Ocultar el eje X
            chartVentas.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False; // Ocultar el eje Y
            serie.IsValueShownAsLabel = true; // Mostrar etiquetas de valores en el gráfico
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie; // Establecer tipo de gráfico a torta
        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ingresos = ventasAplicacion.ObtenerIngresosPorEmpleado(dateTimePicker8.Value, dateTimePicker7.Value);
            if (ingresos == null || ingresos.Count == 0)
            {
                MessageBox.Show("No se encontro ningin dato, Por favor ingrese otro rango de fechas.", "Fechas invalidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir si no hay datos
            }
            CargarGrafico(dateTimePicker8.Value, dateTimePicker7.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarGrafico(new DateTime(1970, 1, 1), DateTime.Now);
            dateTimePicker8.Value = new DateTime(1970, 1, 1);
            dateTimePicker7.Value = DateTime.Now;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var datos = ventasAplicacion.ObtenerCantidadProductosVendidosPorEmpleado(dateTimePicker1.Value, dateTimePicker2.Value);

            // Verifica si hay datos
            if (datos == null || datos.Count == 0)
            {
                MessageBox.Show("No se encontro ningin dato, Por favor ingrese otro rango de fechas.", "Fechas invalidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir si no hay datos
            }

            chart1.Series.Clear();
            var series = new Series("Productos Vendidos");
            series.ChartType = SeriesChartType.Bar;

            foreach (var dato in datos)
            {
                Console.WriteLine(dato.empleadoNombre.ToString());
                Console.WriteLine(dato.cantidadProductos.ToString());
                series.Points.AddXY(dato.empleadoNombre, dato.cantidadProductos);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Empleados";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad de Productos Vendidos";
            chart1.Invalidate(); // Refresca el gráfico
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var datos = ventasAplicacion.ObtenerCantidadProductosVendidosPorEmpleado();
            dateTimePicker1.Value = new DateTime(1970, 1, 1);
            dateTimePicker2.Value = DateTime.Now;
            // Verifica si hay datos
            if (datos == null || datos.Count == 0)
            {
                MessageBox.Show("No se encontro ningin dato, Por favor ingrese otro rango de fechas.", "Fechas invalidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir si no hay datos
            }

            chart1.Series.Clear();
            var series = new Series("Productos Vendidos");
            series.ChartType = SeriesChartType.Bar;

            foreach (var dato in datos)
            {
                Console.WriteLine(dato.empleadoNombre.ToString());
                Console.WriteLine(dato.cantidadProductos.ToString());
                series.Points.AddXY(dato.empleadoNombre, dato.cantidadProductos);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Empleados";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad de Productos Vendidos";
            chart1.Invalidate(); // Refresca el gráfico
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var topEmpleados = ventasAplicacion.ObtenerTopEmpleadosPorVentas(10, dateTimePicker2.Value, dateTimePicker3.Value);

            if (topEmpleados == null || topEmpleados.Count == 0)
            {
                MessageBox.Show("No se encontro ningin dato, Por favor ingrese otro rango de fechas.", "Fechas invalidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir si no hay datos
            }

            chartVentas.Series.Clear();
            chartVentas.Titles.Clear();

            var serie = chartVentas.Series.Add("Ventas por Empleado");

            foreach (var empleado in topEmpleados)
            {
               // serie.Points.AddXY(empleado.EmpleadoNombre, empleado.TotalVentas);
                //serie.Points.AddXY(empleado.EmpleadoNombre, empleado.TotalVentas);
                int puntoIndex = serie.Points.AddXY(empleado.EmpleadoNombre, empleado.TotalVentas);
                serie.Points[puntoIndex].Label = $"{empleado.EmpleadoNombre}: {empleado.TotalVentas}";
            }

            // Configuración adicional del gráfico
            chartVentas.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False; // Ocultar el eje X
            chartVentas.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False; // Ocultar el eje Y
            serie.IsValueShownAsLabel = true; // Mostrar etiquetas de valores en el gráfico
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie; // Establecer tipo de gráfico a torta
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var topEmpleados = ventasAplicacion.ObtenerTopEmpleadosPorVentas(10);
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker4.Value = new DateTime(1970, 1, 1);

            chartVentas.Series.Clear();
            chartVentas.Titles.Clear();
            var serie = chartVentas.Series.Add("Ventas por Empleado");

            foreach (var empleado in topEmpleados)
            {
                //serie.Points.AddXY(empleado.EmpleadoNombre, empleado.TotalVentas);
                //serie.Points.AddXY(empleado.EmpleadoNombre, empleado.TotalVentas);
                int puntoIndex = serie.Points.AddXY(empleado.EmpleadoNombre, empleado.TotalVentas);
                serie.Points[puntoIndex].Label = $"{empleado.EmpleadoNombre}: {empleado.TotalVentas}";
            }

            // Configuración adicional del gráfico
            chartVentas.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False; // Ocultar el eje X
            chartVentas.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False; // Ocultar el eje Y
            serie.IsValueShownAsLabel = true; // Mostrar etiquetas de valores en el gráfico
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie; // Establecer tipo de gráfico a torta
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatosEnGrid()
        {
            var ventasAplicacion = new VentasAplicacion();
            var topEmpleados = ventasAplicacion.ObtenerTopEmpleadosPorVentas(10);

           
             dataGridView1.Rows.Clear();

           
            foreach (var empleado in topEmpleados)
            {
                dataGridView1.Rows.Add(empleado.EmpleadoNombre, empleado.TotalVentas);
            }
        }
       

        private void chartVentas_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarDataGridView()
        {
            
            dataGridView1.Columns.Add("nombre_empleado", "Nombre del Empleado");
            dataGridView1.Columns.Add("ventas_acumulado", "Ventas Acumuladas");

            dataGridView1.Columns["ventas_acumulado"].DefaultCellStyle.Format = "C2"; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var nombreEmpleado = dataGridView1.Rows[e.RowIndex].Cells["nombre_empleado"].Value.ToString();
                var ventasAcumulado = dataGridView1.Rows[e.RowIndex].Cells["ventas_acumulado"].Value.ToString();

                MessageBox.Show($"Empleado: {nombreEmpleado}, Ventas Acumuladas: {ventasAcumulado}");
            }
        }

    }
}
