using FL_FARMACIAS.Aplicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class EstadisticasSubMenu : Form
    {
        public VentasAplicacion VentasAplicacion;

        public EstadisticasSubMenu()
        {
            DateTime desde = new DateTime(1970, 1, 1);
            InitializeComponent();
            VentasAplicacion = new VentasAplicacion(); // Instancia de tu clase de aplicación
            CargarGrafico(desde, DateTime.Now);
            CargarGrafico2(desde, DateTime.Now);
            CargarGraficoTorta(desde, DateTime.Now);
         
            DateTime hasta = DateTime.Now;  // Hasta la fecha actual
            CargarDatosEnGrid(desde, hasta);

        }

        private void CargarGrafico(DateTime desde, DateTime hasta)
        {
            // Obtener datos de ventas por producto
            var datosVentas = VentasAplicacion.ObtenerCantidadVendidaPorProducto();

            // Configurar el gráfico
            chart1.Series.Clear();
            var serie = new Series("Ventas")
            {
                ChartType = SeriesChartType.Column
            };
            chart1.Series.Add(serie);

            // Agregar datos al gráfico
            foreach (var item in datosVentas)
            {
                serie.Points.AddXY(item.Key, item.Value); // item.Key es el nombre del producto, item.Value es la cantidad
            }

            // Opcional: Personalizar el gráfico
            chart1.ChartAreas[0].AxisX.Title = "Productos";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad Vendida";
            chart1.Titles.Add("Cantidad Vendida por Producto");

           
        }

        /// <summary>
        /// 
        /// </summary>
        private void CargarGrafico2(DateTime desde, DateTime hasta)
        {
            // Obtener datos de ingresos por producto
            var datosIngresos = VentasAplicacion.ObtenerIngresosPorProducto();

            // Configurar el gráfico
            prodIngr.Series.Clear();
            var serie = new Series("Ingresos")
            {
                ChartType = SeriesChartType.Column
            };
            prodIngr.Series.Add(serie);

            // Agregar datos al gráfico
            foreach (var item in datosIngresos)
            {
                serie.Points.AddXY(item.Key, item.Value); // item.Key es el nombre del producto, item.Value es el ingreso
            }

            // Opcional: Personalizar el gráfico
            prodIngr.ChartAreas[0].AxisX.Title = "Productos";
            prodIngr.ChartAreas[0].AxisY.Title = "Ingresos Generados";
            prodIngr.Titles.Add("Ingresos por Producto");
        }

        private void CargarGraficoTorta(DateTime desde, DateTime hasta)
        {
            // Obtener los 20 productos más vendidos
            var topProductos = VentasAplicacion.ObtenerTopProductosVendidos(20);

            // Configurar el gráfico
            prodTorta.Series.Clear();
            var serie = new Series("Ventas")
            {
                ChartType = SeriesChartType.Pie // Tipo de gráfico de torta
            };
            prodTorta.Series.Add(serie);

            // Agregar datos al gráfico
            foreach (var item in topProductos)
            {
                serie.Points.AddXY(item.NombreProducto, item.Cantidad); // item.NombreProducto y item.Cantidad
            }

            // Opcional: Personalizar el gráfico
            prodTorta.Titles.Add("Top 20 Productos Más Vendidos");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            // Obtener datos de ventas por producto
            var datosVentas = VentasAplicacion.ObtenerCantidadVendidaPorProducto(dateTimePicker2.Value, dateTimePicker1.Value);

            if (datosVentas == null || datosVentas.Count == 0)
            {
                MessageBox.Show("No se encontro ningin dato, Por favor ingrese otro rango de fechas.", "Fechas invalidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir si no hay datos
            }

            // Configurar el gráfico
            chart1.Series.Clear();
            chart1.Titles.Clear(); // Limpia los títulos anteriores para evitar duplicados

            var serie = new Series("Ventas")
            {
                ChartType = SeriesChartType.Column
            };
            chart1.Series.Add(serie);

            // Agregar datos al gráfico
            foreach (var item in datosVentas)
            {
                serie.Points.AddXY(item.Key, item.Value); // item.Key es el nombre del producto, item.Value es la cantidad
            }

            // Opcional: Personalizar el gráfico
            chart1.ChartAreas[0].AxisX.Title = "Productos";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad Vendida";
            chart1.Titles.Add("Cantidad Vendida por Producto");
            chart1.Invalidate(); // Refresca el gráfico


        }

        //limpiar
        private void button5_Click(object sender, EventArgs e)
        {
            var datosVentas = VentasAplicacion.ObtenerCantidadVendidaPorProducto();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = new DateTime(1970, 1, 1);

            // Configurar el gráfico
            chart1.Series.Clear();
            chart1.Titles.Clear(); // Limpia los títulos anteriores para evitar duplicados

            var serie = new Series("Ventas")
            {
                ChartType = SeriesChartType.Column
            };
            chart1.Series.Add(serie);

            // Agregar datos al gráfico
            foreach (var item in datosVentas)
            {
                serie.Points.AddXY(item.Key, item.Value); // item.Key es el nombre del producto, item.Value es la cantidad
            }

            // Opcional: Personalizar el gráfico
            chart1.ChartAreas[0].AxisX.Title = "Productos";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad Vendida";
            chart1.Titles.Add("Cantidad Vendida por Producto");
            chart1.Invalidate(); // Refresca el gráfico

        }

        //buscar
        private void button10_Click(object sender, EventArgs e)
        {
            // Obtener datos de ingresos por producto
            var datosIngresos = VentasAplicacion.ObtenerIngresosPorProducto(dateTimePicker8.Value, dateTimePicker7.Value);
            if (datosIngresos == null || datosIngresos.Count == 0)
            {
                MessageBox.Show("No se encontro ningin dato, Por favor ingrese otro rango de fechas.", "Fechas invalidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir si no hay datos
            }
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = new DateTime(1970, 1, 1);
            // Configurar el gráfico
            prodIngr.Series.Clear();
            prodIngr.Titles.Clear();
            var serie = new Series("Ingresos")
            {
                ChartType = SeriesChartType.Column
            };
            prodIngr.Series.Add(serie);

            // Agregar datos al gráfico
            foreach (var item in datosIngresos)
            {
                serie.Points.AddXY(item.Key, item.Value); // item.Key es el nombre del producto, item.Value es el ingreso
            }

            // Opcional: Personalizar el gráfico
            prodIngr.ChartAreas[0].AxisX.Title = "Productos";
            prodIngr.ChartAreas[0].AxisY.Title = "Ingresos Generados";
            prodIngr.Titles.Add("Ingresos por Producto");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Obtener datos de ingresos por producto
            var datosIngresos = VentasAplicacion.ObtenerIngresosPorProducto();

            // Configurar el gráfico
            prodIngr.Series.Clear();
            prodIngr.Titles.Clear();
            var serie = new Series("Ingresos")
            {
                ChartType = SeriesChartType.Column
            };
            prodIngr.Series.Add(serie);

            // Agregar datos al gráfico
            foreach (var item in datosIngresos)
            {
                serie.Points.AddXY(item.Key, item.Value); // item.Key es el nombre del producto, item.Value es el ingreso
            }

            // Opcional: Personalizar el gráfico
            prodIngr.ChartAreas[0].AxisX.Title = "Productos";
            prodIngr.ChartAreas[0].AxisY.Title = "Ingresos Generados";
            prodIngr.Titles.Add("Ingresos por Producto");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Obtener los 20 productos más vendidos
            var topProductos = VentasAplicacion.ObtenerTopProductosVendidos(20, dateTimePicker10.Value, dateTimePicker9.Value);

            if (topProductos == null || topProductos.Count == 0)
            {
                MessageBox.Show("No se encontro ningin dato, Por favor ingrese otro rango de fechas.", "Fechas invalidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir si no hay datos
            }

            // Configurar el gráfico
            prodTorta.Series.Clear();
            prodTorta.Titles.Clear();
            var serie = new Series("Ventas")
            {
                ChartType = SeriesChartType.Pie // Tipo de gráfico de torta
            };
            prodTorta.Series.Add(serie);

            // Agregar datos al gráfico
            foreach (var item in topProductos)
            {
                serie.Points.AddXY(item.NombreProducto, item.Cantidad); // item.NombreProducto y item.Cantidad
            }

            // Opcional: Personalizar el gráfico
            prodTorta.Titles.Add("Top 20 Productos Más Vendidos");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Obtener los 20 productos más vendidos
            var topProductos = VentasAplicacion.ObtenerTopProductosVendidos(20);
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = new DateTime(1970, 1, 1);
            // Configurar el gráfico
            prodTorta.Series.Clear();
            prodTorta.Titles.Clear();
            var serie = new Series("Ventas")
            {
                ChartType = SeriesChartType.Pie // Tipo de gráfico de torta
            };
            prodTorta.Series.Add(serie);

            // Agregar datos al gráfico
            foreach (var item in topProductos)
            {
                serie.Points.AddXY(item.NombreProducto, item.Cantidad); // item.NombreProducto y item.Cantidad
            }

            // Opcional: Personalizar el gráfico
            prodTorta.Titles.Add("Top 20 Productos Más Vendidos");
        }

        private void CargarDatosEnGrid(DateTime desde, DateTime hasta)
        {
            // Obtener los productos más vendidos
            var topProductos = VentasAplicacion.ObtenerTopProductosVendidos(20, desde, hasta);

            // Limpiar las filas existentes del DataGridView antes de agregar nuevos datos
            dataGridView1.Rows.Clear();

            // Agregar los datos a las filas del DataGridView
            foreach (var producto in topProductos)
            {
                dataGridView1.Rows.Add(producto.NombreProducto, producto.Cantidad);
            }
        }

        private void ConfigurarDataGridView()
        {
            // Asegúrate de que el DataGridView tiene las columnas necesarias
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("producto_nombre", "Nombre del Producto");
                dataGridView1.Columns.Add("cantidad_vendida", "Cantidad Vendida");
            }
            // Establecer formato si es necesario
            dataGridView1.Columns["cantidad_vendida"].DefaultCellStyle.Format = "N0"; // Para mostrar la cantidad sin decimales
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el nombre del producto y la cantidad vendida de la fila seleccionada
                var nombreProducto = dataGridView1.Rows[e.RowIndex].Cells["producto_nombre"].Value.ToString();
                var cantidadVendida = dataGridView1.Rows[e.RowIndex].Cells["cantidad_vendida"].Value.ToString();

                // Realizar una acción con los valores obtenidos, por ejemplo, mostrar un mensaje
                MessageBox.Show($"Producto: {nombreProducto}\nCantidad Vendida: {cantidadVendida}");
            }
        }

        private void prodTorta_Click(object sender, EventArgs e)
        {

        }
    }
}
   


    

