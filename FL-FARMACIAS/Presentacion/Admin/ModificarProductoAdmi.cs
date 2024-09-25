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
        public ModificarProductoAdmi(ProductoDominio p)
        {
            InitializeComponent();
            this.cod_producto_mod.Text = p.codProducto;
            this.nombre_prod_mod.Text = p.codProducto;
            this.precio_prod_mod.Text = p.precio.ToString();
            this.stock_prod_mod.Text = p.stock.ToString();
            this.activo_prod.Checked = p.estado;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = nombre_prod_mod.Text.Trim();
            String codigo = cod_producto_mod.Text.Trim();
            String categoria = categoria_prod_mod.Text.Trim();
            String marca = marca_prod_mod.Text.Trim();
            String laboratorio = laboratorio_prod_mod.Text.Trim();
            String stock = stock_prod_mod.Text.Trim();
            String descripcion = descripcion_prod_mod.Text.Trim();
            String codigocompara = @"^[A-Za-z]{3}_\d{5}$";
            String precio = precio_prod_mod.Text.Trim();
            int numero;
            float numeroprecio;
            // Intenta convertir el texto a un número entero
            bool espositivo = int.TryParse(stock, out numero) && numero > 0;
            bool preciopositivo = float.TryParse(precio, out numeroprecio) && numeroprecio > 0;


            if (nombre == "" || codigo == "" || descripcion == "" || stock == "" || categoria == "" || precio == "" || marca == "" || laboratorio == "" || (activo_prod.Checked == false && desactivar_prod.Checked == false))
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
                MessageBox.Show("El prducto " + nombre + "Marca:" + marca + "con el codigo " + codigo + " " + "de categoria: " + categoria + "precio: $ " + precio + " ha sido modificado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
