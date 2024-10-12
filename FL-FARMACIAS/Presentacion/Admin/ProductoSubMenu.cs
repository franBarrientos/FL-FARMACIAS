using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using FL_FARMACIAS.Presentacion.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class productoSubMenu : Form
    {
        private AgrerarProductoAdmi AltaProducto = null;
        private AltaCategoria AltaCategoria = null;
        public ProductoAplicacion productoApp;
        public CategoriaAplicacion categoriaApp;

    

        public productoSubMenu()
        {
            InitializeComponent();
            this.productoApp = new ProductoAplicacion();
            this.categoriaApp = new CategoriaAplicacion();

            fullProductos();
            fullCategorias();

            if (LoginForm.user.rol.descripcion == "Supervisor")
            {
                button3w.Hide();
                button3.Hide();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Suponiendo que la columna 1 (index 0) es la columna de precios
            if (dataGridView1.Columns[e.ColumnIndex].Name == "PRECIO" && e.Value != null)
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

        public void fullProductos()
        {
            var productos = this.productoApp.ObtenerTodos();
            dataGridView1.Rows.Clear();
            foreach (var p in productos)
            {
                this.dataGridView1.Rows.Add(p.id, p.codProducto, p.nombre, p.precio, p.stock, p.categoria.descripcion, p.marca.nombre, p.laboratorio != null ? p.laboratorio.nombre : "", p.estado == true ? "ACTIVO" : "NO ACTIVO");

            }

        }

        public void fullCategorias()
        {
           
            var categorias = this.categoriaApp.ObtenerTodos();
            dataGridView2.Rows.Clear();
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add("Todos");
            this.comboBox1.SelectedIndex = 0;
            foreach (var c in categorias)
            {
                this.comboBox1.Items.Add(c.descripcion);
                this.dataGridView2.Rows.Add(c.id, c.descripcion, c.estado == true ? "ACTIVO" : "NO ACTIVO", "ELIMINAR", "MODIFICAR");
            }

        }



        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var dataGridView = sender as DataGridView;
                string productName = dataGridView.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                string codigo = dataGridView.Rows[e.RowIndex].Cells["CODIGO_PROD"].Value.ToString();
                string idName = dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                bool estado = dataGridView.Rows[e.RowIndex].Cells["ACTIVO"].Value.ToString() == "ACTIVO";

                ProductoDominio product = this.productoApp.BuscarProductos(codigo, null, null).First();

                if (dataGridView.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    if (!estado)
                    {
                        MessageBox.Show("El producto: " + productName + " ya no esta activo.", "Producto inactivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


                    DialogResult ask = MessageBox.Show(
                   "Esta a punto de eliminar el Poducto: " + productName,
                   "Confirmar Eliminacion",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation,
                   MessageBoxDefaultButton.Button2);

                    if (ask == DialogResult.Yes)
                    {
                        product.estado = false;
                        this.productoApp.ActualizarProducto(product);
                        MessageBox.Show("El producto " + productName + " ha sido eliminado con exito.", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.fullProductos();
                    }
                }

                else if (dataGridView.Columns[e.ColumnIndex].Name == "MODIFICAR")
                {
                    new ModificarProductoAdmi(this, product).Show();
                }
                
            }

        }



        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var dataGridView2 = sender as DataGridView;
                string id = dataGridView2.Rows[e.RowIndex].Cells["IDC"].Value.ToString();
                string descripcion = dataGridView2.Rows[e.RowIndex].Cells["DESCRIPCIONC"].Value.ToString();
                bool estado = dataGridView2.Rows[e.RowIndex].Cells["ESTADOC"].Value.ToString() == "ACTIVO" ? true : false;

                if (dataGridView2.Columns[e.ColumnIndex].Name == "ELIMINARC")
                {

                    if (!estado)
                    {
                        MessageBox.Show("La Categoria: " + descripcion + " ya no esta activa.", "Categoria inactiva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    DialogResult ask = MessageBox.Show(
                   "Esta a punto de eliminar la Categoria: " + descripcion ,
                   "Confirmar Eliminacion",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation,
                   MessageBoxDefaultButton.Button2);

                    if (ask == DialogResult.Yes)
                    {
                        this.categoriaApp.ActualizarCategoria(new CategoriaDominio( int.Parse(id), descripcion, false));
                        MessageBox.Show("La Categoria " + descripcion + " ha sido eliminado con exito.", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.fullCategorias();
                    }
                }

                else if (dataGridView2.Columns[e.ColumnIndex].Name == "MODIFICARC")
                {
                    new ModificarCategoria(this, new CategoriaDominio(int.Parse(id), descripcion, estado)).Show();
                }

            }

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Verificar si el valor de la celda es "INACTIVO"
            var estado = dataGridView1.Rows[e.RowIndex].Cells["ACTIVO"].Value?.ToString();
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

        private void dataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Verificar si el valor de la celda es "INACTIVO"
            var estado = dataGridView2.Rows[e.RowIndex].Cells["ESTADOC"].Value?.ToString();
            if (estado != "ACTIVO")
                {
                dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;  // Fondo rojo suave
                 dataGridView2.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;       // Texto negro
                }
                else
                {
                    // Color de fondo y texto para filas activas
                    dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;  // Fondo verde suave
                    dataGridView2.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;       // Texto negro
                }
           }
        

        private void button1_Click(object sender, EventArgs e)
        {
  
            String codigocompara = @"^[A-Za-z]{3}_\d{5}$";

            string codCompra = null;
            string nombre = null;
            string categoria = null;

            if (Regex.IsMatch(textBox1.Text, codigocompara))
            {
                codCompra = textBox1.Text;
            }
            else if (textBox1.Text != "" && textBox1.Text != "INGRESE NOMBRE O COD PRODUCTO")
            {
                nombre = textBox1.Text;
            }

            if (comboBox1.Text != "Todos")
            {
                categoria = comboBox1.Text;
            }

            List<ProductoDominio> matched = this.productoApp.BuscarProductos(codCompra, nombre, categoria);
            this.dataGridView1.Rows.Clear();
            foreach (var p in matched)
            {
                this.dataGridView1.Rows.Add(p.id, p.codProducto, p.nombre, p.precio, p.stock, p.categoria.descripcion, p.marca.nombre, p.laboratorio != null ? p.laboratorio.nombre : "", p.estado == true ? "ACTIVO" : "NO ACTIVO");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox1.ForeColor = Color.Black;
            this.comboBox1.Text = "Todos";
           fullProductos();
        }

        private void ShowAltaProducto()
        {
            if (AltaProducto == null || AltaProducto.IsDisposed)
            {
                AltaProducto = new AgrerarProductoAdmi(this);
                AltaProducto.Show();
            }
            else
            {
                AltaProducto.BringToFront(); // Trae el formulario existente al frente
            }
        }
        private void button3w_Click(object sender, EventArgs e)
        {
            ShowAltaProducto();
           // new AgrerarProductoAdmi(this).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "" || textBox2.Text == "INGRESE ID O DESCRIPCION")
            {
                MessageBox.Show("Por favor, ingrese el ID o Descripcion que desea buscar.", "No hay elementos para buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? idD = null;
            string nombreD = null;
            if (int.TryParse(textBox2.Text, out int parsedId)) { 
                idD = parsedId;
            }
            else
            {
                nombreD = textBox2.Text;
            }

            List<CategoriaDominio> matched = this.categoriaApp.BuscarCategorias(idD, nombreD);
            this.dataGridView2.Rows.Clear();
            foreach (var r in matched)
            {
                this.dataGridView2.Rows.Add(r.id, r.descripcion, r.estado == true ? "ACTIVO" : "NO ACTIVO", "ELIMINAR", "MODIFICAR");
            }


        }

        private void ShowAltaCategoria()
        {
            if (AltaCategoria == null || AltaCategoria.IsDisposed)
            {
                AltaCategoria = new AltaCategoria(this);
                AltaCategoria.Show();
            }
            else
            {
                AltaCategoria.BringToFront(); // Trae el formulario existente al frente
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ShowAltaCategoria();
            //new Vaciar_campos_categoria().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                   fullCategorias();
                    this.textBox2.Text = "";
                    this.textBox2.ForeColor = Color.Black;
        }

        private void prodTab_Click(object sender, EventArgs e)
        {

        }

        
    }
}
