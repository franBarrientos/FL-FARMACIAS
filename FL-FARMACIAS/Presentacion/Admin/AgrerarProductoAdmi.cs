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
            this.productoSubMenu = productoSubMenu;
        }

        private void vaciar_productos_Click(object sender, EventArgs e)
        {
            String nombre = TP_nombre.Text.Trim();
            String codigo = TP_codproducto.Text.Trim();
            String categoria = CB_productocat.Text.Trim();
            String stock = TP_stock.Text.Trim();
            String descripcion = TP_descripcion.Text.Trim();
            String precio = TP_precio.Text.Trim();
            String marca = Tmarca_produ.Text.Trim();
            String laboratorio = Tlaboratorio_prod.Text.Trim();
            if (nombre != "" || codigo != "" || descripcion != "" || stock != "" || categoria != "" || precio != "" || laboratorio != "" || marca != "")
            {
                TP_nombre.Clear();
                TP_codproducto.Clear();
                TP_stock.Clear();
                TP_descripcion.Clear();
                TP_precio.Clear();
                Tmarca_produ.Clear();
                Tlaboratorio_prod.Clear();
            }
            else
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que vaciar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void botonAgregarProducto_Click(object sender, EventArgs e)
        {
            String nombre = TP_nombre.Text.Trim();
            String codigo = TP_codproducto.Text.Trim();
            String categoria = CB_productocat.Text.Trim();
            String marca = Tmarca_produ.Text.Trim();
            String laboratorio = Tlaboratorio_prod.Text.Trim();
            String stock = TP_stock.Text.Trim();
            String descripcion = TP_descripcion.Text.Trim();
            String codigocompara = @"^[A-Za-z]{3}_\d{5}$";
            String precio = TP_precio.Text.Trim();
            int numero;
            float numeroprecio;
            // Intenta convertir el texto a un número entero
            bool espositivo = int.TryParse(stock, out numero) && numero >= 0;
            bool preciopositivo = float.TryParse(precio, out numeroprecio) && numeroprecio > 0;


            if (nombre == "" || codigo == "" || descripcion == "" || stock == "" || categoria == "" || precio == "" || marca == "" || laboratorio == "" || (CBP_inactivo.Checked == false && CBP_activo.Checked == false) || (CBP_inactivo.Checked == true && CBP_activo.Checked == true))
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!nombre.All(char.IsLetter))
            {
                MessageBox.Show("Por favor, ingrese solo letras en el campo de Nombre de Producto.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!marca.All(char.IsLetter))
            {
                MessageBox.Show("Por favor, ingrese solo letras en el campo de Marca de Producto.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!laboratorio.All(char.IsLetter))
            {
                MessageBox.Show("Por favor, ingrese solo letras en el campo de Laboratorio de Producto.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!descripcion.All(char.IsLetter))
            {
                MessageBox.Show("Por favor, ingrese solo letras en el campo Descripcion del Producto.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Por favor, ingrese solo números positivos en el campo stock.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!preciopositivo)
            {
                MessageBox.Show("Por favor, ingrese solo números positivos en el campo precio.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nombre != "" && codigo != "" && categoria != "" && precio != "" && marca != "" && descripcion != "" && laboratorio != "" && stock != "")
            {
                MessageBox.Show("El prducto " + nombre + "Marca:"+ marca + "con el codigo " + codigo + " " + "de categoria: " + categoria + "precio: $ " + precio + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            //convierte el precio en string a float para mostrar
            float preciomostrar = Convert.ToSingle(precio);

            // convierte el string del stock en int
            int stockmostrar = Convert.ToInt32(stock);

            CategoriaDominio categoria_obje = new CategoriaDominio(1, categoria, true);
            ProductoDominio producto_obj = new ProductoDominio(1, codigo, nombre, preciomostrar, stockmostrar, categoria_obje, true);

            this.productoSubMenu.insertProduct(producto_obj);
            // this.productoSubMenu.insertProduct(new object[] { 6, "P006", "Producto 6", 10.5, 100, "Perfumeria", true, });
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
            String descripcion = TP_descripcion.Text.Trim();
            String precio = TP_precio.Text.Trim();
            String marca = Tmarca_produ.Text.Trim();
            String laboratorio = Tlaboratorio_prod.Text.Trim();
            if (nombre != "" || codigo != "" || descripcion != "" || stock != "" || categoria != "" || precio != "" || laboratorio != "" || marca != "")
            {
                TP_nombre.Clear();
                TP_codproducto.Clear();
                TP_stock.Clear();
                TP_descripcion.Clear();
                TP_precio.Clear();
                Tmarca_produ.Clear();
                Tlaboratorio_prod.Clear();
            }
            else
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que vaciar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
