using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Globalization;


namespace FL_FARMACIAS.Presentacion.Farmaceutico
{

    public partial class VentasSubMenu : Form
    {
        private Timer searchTimer;
        private Timer productTimer;
        public ClienteAplicacion clienteApp;
      
        public VentasSubMenu()
        {
            this.clienteApp = new ClienteAplicacion();
            InitializeComponent();
            fullDataGridAllClients();
            fullDataGridAllProducts();
            //cliente
            searchTimer = new Timer();
            searchTimer.Interval = 500; // Intervalo de 500 ms
            searchTimer.Tick += new EventHandler(OnSearchTimerTick);
            //product
            productTimer = new Timer();
            productTimer.Interval = 500;
            productTimer.Tick += new EventHandler(OnProductTimerTick);

        }

        private void fullDataGridAllProducts()
        {
            dataGridView3.Rows.Clear();
           foreach (var p in StaticBD.productos) { dataGridView3.Rows.Add(p.codProducto, p.nombre, p.precio, p.stock, "ESCOJER"); }
        }

        private void OnProductTimerTick(object sender, EventArgs e)
        {
            
            // Parar el timer y realizar la búsqueda    
            productTimer.Stop();

            // Realizar la búsqueda

            if (placeholderTextBox2.Text.Length >= 1 && placeholderTextBox2.Text != "INGRESE COD PRODUCTO O DESCRIPCION")
            {
                buscarProduct(placeholderTextBox2.Text);
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            // Reiniciar el Timer cuando el texto cambie
            productTimer.Stop();
            productTimer.Start();
        }

        private void buscarProduct(string s)
        {
            dataGridView3.Rows.Clear();
            foreach (var p in StaticBD.productos)
            {
                if (p.codProducto.StartsWith(s, StringComparison.OrdinalIgnoreCase) || p.nombre.ToLower().Contains(s.ToLower()))
                {
                    dataGridView3.Rows.Add(p.codProducto, p.nombre, p.precio, p.stock, "ESCOJER");
                }
            }

            
        }

        private void fullDataGridAllClients()
        {

            List<ClienteDominio> matcheds = this.clienteApp.BuscarCliente(null, null, true, null);
            this.dataGridView2.Rows.Clear();

            foreach (var c in matcheds)
            {
                this.dataGridView2.Rows.Add(c.apellido, c.nombre, c.dni, c.desc.descripcion, c.desc.porcentajeDescuento, "ESCOJER");
                
            }
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            // Reiniciar el Timer cuando el texto cambie
            searchTimer.Stop();
            searchTimer.Start();
        }
        private void OnSearchTimerTick(object sender, EventArgs e)
        {
            // Parar el timer y realizar la búsqueda
            searchTimer.Stop();
            Debug.WriteLine("Buscando clientes...");

            if (placeholderTextBox1.Text.Length >= 1 && placeholderTextBox1.Text != "INGRESE DNI O APELLIDO")
            {
                buscarClientes(placeholderTextBox1.Text);
            }else
            {
                fullDataGridAllClients();
            }
        }


        private void buscarClientes(string s)
        {
            var apellido = s;
            var dni = s;
            if (s.Trim().All(char.IsDigit))
            {
                apellido = null;
            }else
            {
                dni = null;
            }

            var matcheds = this.clienteApp.BuscarCliente(dni, apellido, true, null);
            dataGridView2.Rows.Clear();
            foreach (var c in matcheds)
            {        
                this.dataGridView2.Rows.Add(c.apellido, c.nombre, c.dni, c.desc.descripcion, c.desc.porcentajeDescuento, "ESCOJER");

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic fue en la columna de botones
            if (dataGridView2.Columns[e.ColumnIndex].Name == "ESCOJER")
            {
                // Obtener el valor de la fila seleccionada, por ejemplo, el nombre
                string apellido = dataGridView2.Rows[e.RowIndex].Cells["APELLIDO_V"].Value.ToString();
                string dni = dataGridView2.Rows[e.RowIndex].Cells["DNIV"].Value.ToString();
                string obraSocial = dataGridView2.Rows[e.RowIndex].Cells["OBRASOCIALV"].Value.ToString();

                // Mostrar un mensaje con la información del cliente seleccionado
                //MessageBox.Show($"Cliente escogido: {apellido}, DNI: {dni}", "Cliente Escogido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label7.Text = "DNI: " + dni;
                label11.Text = "DNI: " + dni;

                label5.Text = "APELLIDO: " + " " + apellido;
                label13.Text = "APELLIDO: " + " " + apellido;

                label16.Text = "NOMBRE: " + dataGridView2.Rows[e.RowIndex].Cells["NOMBREC"].Value.ToString();

                label6.Text = "OBRA SOCIAL: " + obraSocial;
                label12.Text = "OBRA SOCIAL: " + obraSocial;
                label17.Text = "% DESCUENTO: " + dataGridView2.Rows[e.RowIndex].Cells["DESCPORCENTAJE"].Value.ToString() + "%";

                if (label14.Text != "TOTAL:")
                {
                    var total = calcularTotal();
                    label14.Text = "TOTAL: " + total.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                    double pdesc;
                    if (!Double.TryParse(label17.Text.Split(':')[1].Replace("%", "").Trim(), out pdesc))
                    {
                        pdesc = 0; // Si la conversión falla, asigna 0
                    }
                    var totalDesc = Math.Round(total * pdesc / 100, 2);
                    label20.Text = "DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));

                    totalDesc = Math.Round(total - totalDesc, 2);
                    label19.Text = "TOTAL C\\DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                }
            }
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Suponiendo que la columna 1 (index 0) es la columna de precios
            if (dataGridView3.Columns[e.ColumnIndex].Name == "PRECIOP" && e.Value != null)
            {
                double precio;
                // Intentamos convertir el valor a double
                if (Double.TryParse(e.Value.ToString(), out precio))
                {
                    // Mostramos el precio con el símbolo de moneda, sin modificar el valor real
                    e.Value = precio.ToString("C", CultureInfo.GetCultureInfo("es-AR")); // o tu formato de moneda preferido
                    e.FormattingApplied = true;
                }

            }
        }
        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        { 

            if (dataGridView4.Columns[e.ColumnIndex].Name == "PRECIO" && e.Value != null)
            {
                double precio;
                // Intentamos convertir el valor a double
                if (Double.TryParse(e.Value.ToString(), out precio))
                {
                    // Mostramos el precio con el símbolo de moneda, sin modificar el valor real
                    e.Value = precio.ToString("C", CultureInfo.GetCultureInfo("es-AR")); // o tu formato de moneda preferido
                    e.FormattingApplied = true;
                }
            }

            if (dataGridView4.Columns[e.ColumnIndex].Name == "SUBTOTAL" && e.Value != null)
            {
                double precio;
                // Intentamos convertir el valor a double
                if (Double.TryParse(e.Value.ToString(), out precio))
                {
                    // Mostramos el precio con el símbolo de moneda, sin modificar el valor real
                    e.Value = precio.ToString("C", CultureInfo.GetCultureInfo("es-AR")); // o tu formato de moneda preferido
                    e.FormattingApplied = true;
                }
            }

        }


        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic fue en la columna de botones
            if (dataGridView3.Columns[e.ColumnIndex].Name == "ESCOJERP")
            {
                // Obtener el valor de la fila seleccionada, por ejemplo, el nombre
                string codP = dataGridView3.Rows[e.RowIndex].Cells["CODP"].Value.ToString();
                string descp = dataGridView3.Rows[e.RowIndex].Cells["DESCPP"].Value.ToString();
              

                // Mostrar un mensaje con la información del cliente seleccionado
               // MessageBox.Show($"Producto escogido: {codP}, DESCRIPCION: {descp}", "Producto Escogido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label8.Text = "CODIGO: " + codP;
                label9.Text = "DESCRIPCION: " + descp;
                preciolb.Text = "PRECIO: " + dataGridView3.Rows[e.RowIndex].Cells["PRECIOP"].Value.ToString();
                label18.Text = "STOCK: " + dataGridView3.Rows[e.RowIndex].Cells["STOCKP"].Value.ToString();
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.Columns[e.ColumnIndex].Name == "QUITAR")
            {
                dataGridView4.Rows.RemoveAt(e.RowIndex);
                var total = calcularTotal();
                label14.Text = "TOTAL: " + total.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                double pdesc;
                if (!Double.TryParse(label17.Text.Split(':')[1].Replace("%", "").Trim(), out pdesc))
                {
                    pdesc = 0; // Si la conversión falla, asigna 0
                }
                var totalDesc = Math.Round(total * pdesc / 100, 2);
                label20.Text = "DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));

                totalDesc = Math.Round(total - totalDesc, 2);
                label19.Text = "TOTAL C\\DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));

            }
        }

        private double calcularTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                total += Convert.ToDouble(row.Cells["SUBTOTAL"].Value);
            }
            return total;
        }


       
        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "APELLIDO: Consumidor Final";
            label6.Text = "OBRA SOCIAL: Ninguna";
            label7.Text = "DNI: Ninguno";


            label11.Text = "DNI: Ninguno";

            label13.Text = "APELLIDO: Consumidor Final";

            label16.Text = "NOMBRE: Ninguno";

            label12.Text = "OBRA SOCIAL: Ninguna";
            label17.Text = "% DESCUENTO: Ninguno";

            if (label14.Text != "TOTAL:")
            {
                var total = calcularTotal();
                label14.Text = "TOTAL: " + total.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
                double pdesc;
                if (!Double.TryParse(label17.Text.Split(':')[1].Replace("%", "").Trim(), out pdesc))
                {
                    pdesc = 0; // Si la conversión falla, asigna 0
                }
                var totalDesc = Math.Round(total * pdesc / 100, 2);
                label20.Text = "DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));

                totalDesc = Math.Round(total - totalDesc, 2);
                label19.Text = "TOTAL C\\DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label8.Text == "COD PRODUCTO:" || label9.Text == "DESCRIPCION:")
            {
                MessageBox.Show("Por favor, seleccione un producto");
                return;
            }

            var stockAv = label18.Text.Split(':')[1];

            if (numericUpDown1.Value > Convert.ToInt32(stockAv))
            {
                MessageBox.Show("Por favor, seleccione un stock disponible");
                return;
            }

            var cod = label8.Text.Split(':')[1];
            var price = preciolb.Text.Split(':');
            var desc = label9.Text.Split(':')[1];
            double sub = Math.Round(Convert.ToDouble(price[1]) * Convert.ToDouble(numericUpDown1.Value), 2);

            this.dataGridView4.Rows.Add(cod, desc, numericUpDown1.Value.ToString(), price[1], sub, "QUITAR");

            var total = calcularTotal();
            label14.Text = "TOTAL: " + total.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
            double pdesc;
            if (!Double.TryParse(label17.Text.Split(':')[1].Replace("%", "").Trim(), out pdesc))
            {
                pdesc = 0; // Si la conversión falla, asigna 0
            }
            var totalDesc  = Math.Round(total * pdesc / 100, 2);
            label20.Text = "DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));

            totalDesc = Math.Round(total - totalDesc, 2);
            label19.Text = "TOTAL C\\DESCUENTO: " + totalDesc.ToString("C", CultureInfo.GetCultureInfo("es-AR"));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label15.Text = "MEDIO DE PAGO: " + comboBox2.Text;
        }
    }
}
