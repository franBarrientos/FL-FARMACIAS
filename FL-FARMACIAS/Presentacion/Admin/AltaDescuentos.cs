﻿using FL_FARMACIAS.Aplicacion;
using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class AltaDescuentos : Form
    {

        public Dictionary<string, List<string>> provArr = StaticBD.provinciasYLocalidades;
        private DescuentoAplicacion descuentosAplicacion;
        private DescuentosSubMenu descuentosSubMenu;

        public AltaDescuentos()
        {
            InitializeComponent();
        }

        public AltaDescuentos(DescuentoAplicacion descuentosAplicacion, DescuentosSubMenu descuentosSubMenu)
        {
            this.descuentosAplicacion = descuentosAplicacion;
            this.descuentosSubMenu = descuentosSubMenu;
            InitializeComponent();
        }

        private void BFalta_ingresarcli_Click(object sender, EventArgs e)
        {
            String descripcion = descripcion_descuento.Text.Trim();
            String porcentaje = porcentaje_descuento.Text.Trim();
            porcentaje = porcentaje.Replace(',', '.');


            if (descripcion == "" || porcentaje == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(descripcion) || !descripcion.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Por favor, ingrese solo letras el campo de descripcion.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!porcentaje.All(c => char.IsDigit(c) || c == '.') || Convert.ToDouble(porcentaje) < 0 || Convert.ToDouble(porcentaje) > 100)
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo porcentaje.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (descripcion != "" && porcentaje != "")
            {
                this.descuentosAplicacion.AgregarDescuento(new DescuentoDominio(descripcion, Convert.ToDouble(porcentaje), true));
                MessageBox.Show("El descuento con la descripcion: " + descripcion + ", cuenta con un porcentaje de descuento del" + porcentaje + "%, ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.descuentosSubMenu.fullDeaults();
                this.Close();
            }

        }

        private void BFalta_vaciarcampos_Click(object sender, EventArgs e)
        {

            String descripcion = descripcion_descuento.Text.Trim();
            String porcentaje = porcentaje_descuento.Text.Trim();
            if (descripcion != " " || porcentaje != " " )
            {
                descripcion_descuento.Clear();
                porcentaje_descuento.Clear();

            }
            else
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que vaciar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
