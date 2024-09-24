using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private List<CategoriaDominio> orgCategories = new List<CategoriaDominio>
        {
            new CategoriaDominio( 1, "Perfumeria", true ),
            new CategoriaDominio( 1, "Medicamentos", true )
        };

        private List<ProductoDominio> orgProducts = new List<ProductoDominio>
        {
            new ProductoDominio(1, "P001", "Producto 1", 10.5, 100, new CategoriaDominio( 1, "Perfumeria", true ) , true),
            new ProductoDominio(2, "P002", "Producto 2", 20.0, 50, new CategoriaDominio( 2, "Medicamentos", true ) , false),
            new ProductoDominio(3, "P003", "Producto 3", 15.0, 200, new CategoriaDominio( 2, "Medicamentos", true ) , true),
            new ProductoDominio(4, "P004", "Producto 4", 25.75, 150, new CategoriaDominio( 2, "Medicamentos", true ) , true),
            new ProductoDominio(5, "P005", "Producto 5", 5.0, 300, new CategoriaDominio( 2, "Medicamentos", true ) , false)
        };

     

        public void insertProduct(ProductoDominio p)
        {
            this.dataGridView1.Rows.Add(p.Id, p.CodProducto, p.Nombre, p.Precio, p.Stock, p.Categoria.Descripcion, p.Estado == true ? "ACTIVO" : "NO ACTIVO");
            this.orgProducts.Add(p);
        }
        public productoSubMenu()
        {
            InitializeComponent();
          
                 foreach (var row in this.orgProducts)
                 {
                     this.dataGridView1.Rows.Add(row.Id, row.CodProducto, row.Nombre, row.Precio, row.Stock, row.Categoria.Descripcion, row.Estado == true ? "ACTIVO" : "NO ACTIVO");

                 }

                foreach (var row in this.orgCategories)
                {
                    this.dataGridView2.Rows.Add(row.Id, row.Descripcion, row.Estado == true ? "ACTIVO" : "NO ACTIVO");
                }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var dataGridView = sender as DataGridView;
                string productName = dataGridView.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                string idName = dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                ProductoDominio product = this.orgProducts.Where(x => x.Id.ToString() == idName).FirstOrDefault();

                if (dataGridView.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    DialogResult ask = MessageBox.Show(
                   "Esta a punto de eliminar el Poducto: " + productName,
                   "Confirmar Eliminacion",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation,
                   MessageBoxDefaultButton.Button2);

                    if (ask == DialogResult.Yes)
                    {

                        MessageBox.Show("El producto " + productName + " ha sido eliminado con exito.", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView.Rows.RemoveAt(e.RowIndex);
                    }
                }

                else if (dataGridView.Columns[e.ColumnIndex].Name == "MODIFICAR")
                {
                    new ModificarProductoAdmi(product).Show();
                }
                
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "INGRESE DNI O APELLIDO")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void converTextBlack(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text != "INGRESE DNI O APELLIDO")
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "INGRESE DNI O APELLIDO";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "INGRESE ID O DESCRIPCION")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void converTextBlack2(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text != "INGRESE ID O DESCRIPCION")
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "INGRESE ID O DESCRIPCION";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " && comboBox1.Text == " ")
            {
                MessageBox.Show("Por favor, ingrese el Nombre del producto o Cod_producto que desea buscar.", "No hay elementos para buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductoDominio[] matched;
            if (textBox1.Text == "INGRESE NOMBRE O COD PRODUCTO" && comboBox1.Text == "Todos")
            {
                matched = this.orgProducts
                           .ToArray(); // Convertir a un array de object[][]
            }
            else if (textBox1.Text == "INGRESE NOMBRE O COD PRODUCTO" && comboBox1.Text != "Todos")
            {
                matched = this.orgProducts
                           .Where(x => x.Categoria.Descripcion.ToString() == comboBox1.Text)
                           .ToArray(); // Convertir a un array de object[][]
            }
            else if ((comboBox1.Text == "Todos") && (textBox1.Text != "INGRESE NOMBRE O COD PRODUCTO"))
            {
                matched = this.orgProducts
                       .Where(x => x.Nombre.ToString().Contains(textBox1.Text) ||
                                   x.CodProducto.ToString().Contains(textBox1.Text))
                           .ToArray(); // Convertir a un array de object[][]
            }
            else if ((comboBox1.Text != "Todos") && (textBox1.Text != "INGRESE NOMBRE O COD PRODUCTO"))
            {
                matched = this.orgProducts
                       .Where(x => x.CodProducto.ToString().Contains(textBox1.Text) ||
                                   x.Nombre.ToString().Contains(textBox1.Text) &&
                                    x.Categoria.Descripcion.ToString() == comboBox1.Text)
                           .ToArray(); // Convertir a un array de object[][]
            }
            else
            {
                matched = this.orgProducts
                       .ToArray(); // Convertir a un array de object[][]
            }


            this.dataGridView1.Rows.Clear();

            foreach (var p in matched)
            {
                this.dataGridView1.Rows.Add(p.Id, p.CodProducto, p.Nombre, p.Precio, p.Stock, p.Categoria.Descripcion, p.Estado == true ? "ACTIVO" : "NO ACTIVO");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear ();

            foreach (var p in this.orgProducts)
            {
                this.dataGridView1.Rows.Add(p.Id, p.CodProducto, p.Nombre, p.Precio, p.Stock, p.Categoria.Descripcion, p.Estado == true ? "ACTIVO" : "NO ACTIVO");
            }
        }

        private void button3w_Click(object sender, EventArgs e)
        {
            new AgrerarProductoAdmi(this).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == " ")
            {
                MessageBox.Show("Por favor, ingrese el ID o Descripcion que desea buscar.", "No hay elementos para buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CategoriaDominio[] matched;
            if (textBox2.Text != "INGRESE ID O DESCRIPCION")
            {
                matched = this.orgCategories
                    .Where(x => x.Id.ToString().Contains(textBox2.Text)
                    || x.Descripcion.ToString().Contains(textBox2.Text))
                           .ToArray();
            }
            else
            {
                matched = this.orgCategories
                       .ToArray();
            }


            this.dataGridView2.Rows.Clear();

            foreach (var row in matched)
            {
                this.dataGridView2.Rows.Add(row);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CategoriaAdmi().Show();
        }
    }
}
