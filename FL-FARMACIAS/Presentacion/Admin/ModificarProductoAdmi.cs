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

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class ModificarProductoAdmi : Form
    {

        private readonly productoSubMenu productoSubMenu;
        public ModificarProductoAdmi( productoSubMenu m, ProductoDominio p)
        {
            this.productoSubMenu = m;
            InitializeComponent();
            fullComboBoxes();
            this.cod_producto_mod.Text = p.codProducto;
            this.nombre_prod_mod.Text = p.nombre;
            this.laboratorio_precio_mod.Text = p.precio.ToString();
            this.stock_prod_mod.Text = p.stock.ToString();
            if (!categoria_prod_mod.Items.Contains(p.categoria.descripcion))
            {
                categoria_prod_mod.Items.Add(p.categoria.descripcion);
            }

            this.categoria_prod_mod.Text = p.categoria.descripcion;
            if (p.laboratorio != null)
            {
                if (!lab_mod.Items.Contains(p.laboratorio.nombre))
                {
                    lab_mod.Items.Add(p.laboratorio.nombre);
                }
                this.lab_mod.Text = p.laboratorio.nombre;
            }

            if (!marca_prod_mod.Items.Contains(p.marca.nombre))
            {
                marca_prod_mod.Items.Add(p.marca.nombre);
            }
            this.marca_prod_mod.Text = p.marca.nombre;
            if (p.estado == true)
            {
                this.activo_prod.Checked = true;
            }
            else
            {
                this.desactivar_prod.Checked = true;   
            }

        }

        public void fullComboBoxes()
        {
            //CATEGORIA
            List<CategoriaDominio> categorias = this.productoSubMenu.categoriaApp.ObtenerTodosActivo();
            categoria_prod_mod.Items.Clear();
            foreach (var cat in categorias)
            {
                categoria_prod_mod.Items.Add(cat.descripcion);
            }

            //MARCA
            List<MarcaDominio> marcas = this.productoSubMenu.productoApp.ObtenerMarcas();
            marca_prod_mod.Items.Clear();
            foreach (var mar in marcas)
            {
                marca_prod_mod.Items.Add(mar.nombre);
            }

            //LABORATORIO
            List<LaboratorioDominio> laboratorios = this.productoSubMenu.productoApp.ObtenerLaboratorios();
            lab_mod.Items.Clear();
            lab_mod.Items.Add("-");
            foreach (var lab in laboratorios)
            {
                lab_mod.Items.Add(lab.nombre);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = nombre_prod_mod.Text.Trim();
            String codigo = cod_producto_mod.Text.Trim();
            String categoria = categoria_prod_mod.Text.Trim();
            String marca = marca_prod_mod.Text.Trim();
            String laboratorio = lab_mod.Text.Trim();
            String stock = stock_prod_mod.Text.Trim();
            String codigocompara = @"^[A-Za-z]{3}_\d{5}$";
            String precio = laboratorio_precio_mod.Text.Trim();
            int numero;
            float numeroprecio;
            precio = precio.Replace(",", ".");
            // Intenta convertir el texto a un número entero
            bool espositivo = int.TryParse(stock, out numero) && numero > 0;
            bool preciopositivo = float.TryParse(precio, out numeroprecio) && numeroprecio > 0;

            Console.WriteLine("ATRIBUTOS: ");
            Console.WriteLine(nombre);
            Console.WriteLine(codigo);
            Console.WriteLine(categoria);
            Console.WriteLine(precio);
            Console.WriteLine(stock);
            Console.WriteLine(marca);



            //if (nombre == "" || codigo == "" || stock == "" || categoria == "" || precio == "" || marca == ""  || (activo_prod.Checked == false && desactivar_prod.Checked == false))
           if (nombre == "" || codigo == "" || stock == "" || categoria == "" || precio == "" || marca == ""  )

            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese solo letras en el campo de Nombre de Producto.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(marca))
            {
                MessageBox.Show("Por favor, ingrese solo letras en el campo de Marca de Producto.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            if (!Regex.IsMatch(codigo, codigocompara))
            {
                MessageBox.Show("El codigo del producto debe tener la forma: DRO_12345/PER_12345/LIM_12345 .", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (!stock.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo stock del producto.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!espositivo)
            {
                MessageBox.Show("Por favor, ingrese solo números positivos .", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!preciopositivo)
            {
                MessageBox.Show("Por favor, ingrese solo números positivos .", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nombre != "" && codigo != "" && categoria != "" && precio != "" && marca != "")
            {
                var categoriaD = this.productoSubMenu.categoriaApp.ObtenerPorDescripcion(categoria);
                var marcaD = this.productoSubMenu.productoApp.ObtenerMarcaPorNombre(marca);
                LaboratorioDominio labD = null;
                if (laboratorio != "-" && laboratorio != "")
                {
                    labD = this.productoSubMenu.productoApp.ObtenerLaboratorioPorNombre(laboratorio);
                }

                this.productoSubMenu.productoApp.ActualizarProducto(new ProductoDominio(codigo, nombre, float.Parse(precio), int.Parse(stock), categoriaD, marcaD, labD, activo_prod.Checked));
                this.productoSubMenu.fullProductos();
                MessageBox.Show("El prducto " + nombre + "Marca:" + marca + "con el codigo " + codigo + " " + "de categoria: " + categoria + "precio: $ " + precio + " ha sido modificado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

   

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void desactivar_prod_CheckedChanged(object sender, EventArgs e)
        {
            if (activo_prod.Checked == true)
            {
                activo_prod.Checked = false;
            }
        }

        private void activo_prod_CheckedChanged(object sender, EventArgs e)
        {
            if (desactivar_prod.Checked == true)
            {
                desactivar_prod.Checked = false;
            }
        }
    }
}
