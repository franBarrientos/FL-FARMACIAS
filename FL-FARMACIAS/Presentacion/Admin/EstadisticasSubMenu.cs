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

        //limpiar
        private void button5_Click(object sender, EventArgs e)
        {
            var datosVentas = VentasAplicacion.ObtenerCantidadVendidaPorProducto();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = new DateTime(1970, 1, 1);

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

        //buscar
        private void button10_Click(object sender, EventArgs e)
        {
            // Obtener datos de ingresos por producto
            var datosIngresos = VentasAplicacion.ObtenerIngresosPorProducto(dateTimePicker8.Value, dateTimePicker7.Value);
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = new DateTime(1970, 1, 1);
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

        private void button9_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
        {
            // Obtener los 20 productos más vendidos
            var topProductos = VentasAplicacion.ObtenerTopProductosVendidos(20, dateTimePicker10.Value, dateTimePicker9.Value);

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

        private void button12_Click(object sender, EventArgs e)
        {
            // Obtener los 20 productos más vendidos
            var topProductos = VentasAplicacion.ObtenerTopProductosVendidos(20);
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = new DateTime(1970, 1, 1);
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
    }
}
   


    

