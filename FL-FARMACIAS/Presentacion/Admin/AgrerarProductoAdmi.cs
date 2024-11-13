using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class AgrerarProductoAdmi : Form
    {
        private productoSubMenu productoSubMenu;

        public AgrerarProductoAdmi(productoSubMenu productoSubMenu)
        {
            InitializeComponent();            
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.productoSubMenu = productoSubMenu;
            fullComboBoxes();

        }

        public void fullComboBoxes()
        {
            //CATEGORIA
            List<CategoriaDominio> categorias = this.productoSubMenu.categoriaApp.ObtenerTodosActivo();
            CB_productocat.Items.Clear();
            foreach (var cat in categorias)
            {
                CB_productocat.Items.Add(cat.descripcion);
            }

            //MARCA
            List<MarcaDominio> marcas = this.productoSubMenu.productoApp.ObtenerMarcas();
            CB_MARCA.Items.Clear();
            foreach (var mar in marcas)
            {
                CB_MARCA.Items.Add(mar.nombre);
            }    

            //LABORATORIO
            List<LaboratorioDominio> laboratorios = this.productoSubMenu.productoApp.ObtenerLaboratorios();
            CB_LABORATORIO.Items.Clear();
            CB_LABORATORIO.Items.Add("-");
            foreach (var lab in laboratorios)
            {
                CB_LABORATORIO.Items.Add(lab.nombre);
            }
            

        }

          private void botonAgregarProducto_Click(object sender, EventArgs e)
        {
            String nombre = TP_nombre.Text.Trim();
            String codigo = TP_codproducto.Text.Trim();
            String categoria = CB_productocat.Text.Trim();
            String marca = CB_MARCA.Text.Trim();
            String laboratorio = CB_LABORATORIO.Text.Trim();
            String stock = TP_stock.Text.Trim();
            String codigocompara = @"^[A-Za-z]{3}_\d{5}$";
            String precio = TP_precio.Text.Trim();
            precio = precio.Replace(",", ".");

            int numero;
            float numeroprecio;
            // Intenta convertir el texto a un número entero
            bool espositivo = int.TryParse(stock, out numero) && numero >= 0;
            bool preciopositivo = float.TryParse(precio, out numeroprecio) && numeroprecio > 0;

            if (nombre == "" || codigo == "" ||  stock == "" || categoria == "" || precio == "" || marca == ""  || (CBP_inactivo.Checked == false && CBP_activo.Checked == false) || (CBP_inactivo.Checked == true && CBP_activo.Checked == true))
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

           // if (string.IsNullOrWhiteSpace(descripcion) || !descripcion.All(c => char.IsLetter(c) || c == ' '))
           // {
              //  MessageBox.Show("Por favor, ingrese solo letras en el campo Descripcion del Producto.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // return;
            //}

            if (!Regex.IsMatch(codigo, codigocompara))
            {
                MessageBox.Show("El codigo del producto debe tener la forma: DRO_12345/PER_12345/LIM_12345 .", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (!stock.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo stock del producto.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!precio.All(c => char.IsDigit(c) || c == '.') || Convert.ToDouble(precio) < 0)
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo precio.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //convierte el precio en string a float para mostrar
            float preciomostrar = Convert.ToSingle(precio);

            // convierte el string del stock en int
            int stockmostrar = Convert.ToInt32(stock);

            CategoriaDominio categoriaDominio = this.productoSubMenu.categoriaApp.ObtenerPorDescripcion(categoria);
            MarcaDominio marcaDominio = this.productoSubMenu.productoApp.ObtenerMarcaPorNombre(marca);
            LaboratorioDominio laboratorioDominio = null;
            if (laboratorio == "" || laboratorio == null || laboratorio == "-")
            {
                laboratorioDominio = null;
            }
            else
            {
                laboratorioDominio = this.productoSubMenu.productoApp.ObtenerLaboratorioPorNombre(laboratorio);
            }
            ProductoDominio producto_obj = new ProductoDominio(codigo, nombre, preciomostrar, stockmostrar, categoriaDominio, marcaDominio, laboratorioDominio, CBP_activo.Checked);
            Console.WriteLine(producto_obj);
            this.productoSubMenu.productoApp.AgregarProducto(producto_obj);
            this.productoSubMenu.fullProductos();
           // if (nombre != "" && codigo != "" && categoria != "" && precio != "" && marca != "" && descripcion != "" && stock != "" && Regex.IsMatch(codigo, codigocompara))
            //{
             //   MessageBox.Show("El prducto " + nombre + "Marca:" + marca + "con el codigo " + codigo + " " + "de categoria: " + categoria + "precio: $ " + precio + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

           // }
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void vaciar_productos_Click_1(object sender, EventArgs e)
        {
            String nombre = TP_nombre.Text.Trim();
            String codigo = TP_codproducto.Text.Trim();
            String categoria = CB_productocat.Text.Trim();
            String stock = TP_stock.Text.Trim();
            String precio = TP_precio.Text.Trim();
            String marca = CB_MARCA.Text.Trim();
            String laboratorio = CB_LABORATORIO.Text.Trim();
            if (nombre != "" || codigo != "" ||  stock != "" || categoria != "" || precio != "" || laboratorio != "" || marca != "")
            {
                TP_nombre.Clear();
                TP_codproducto.Clear();
                TP_stock.Clear();
                TP_precio.Clear();
                CB_MARCA.Text = "";
                CB_LABORATORIO.Text = "";
            }
            else
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que vaciar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
