using FL_FARMACIAS.Aplicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            InitializeComponent();
            VentasAplicacion = new VentasAplicacion(); // Instancia de tu clase de aplicación
            CargarGrafico();
            CargarGrafico2();
            CargarGraficoTorta();

        }

        private void CargarGrafico()
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

        private void CargarGrafico2()
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

        private void CargarGraficoTorta()
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
    }
}
   


    

