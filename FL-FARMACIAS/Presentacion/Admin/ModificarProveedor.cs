﻿using FL_FARMACIAS.Dominio;
using FL_FARMACIAS.Presentacion.Admin;
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

namespace FL_FARMACIAS.Presentacion.Farmaceutico
{
    public partial class ModificarProveedor : Form
    {

        public Dictionary<string, List<string>> provArr = StaticBD.provinciasYLocalidades;
        public ProveedoresSubMenu proveedorSubMenu { get; set; }
        public ProveedorDominio provedor {  get; set; }
        public ModificarProveedor(ProveedoresSubMenu m, ProveedorDominio p)
        {
            InitializeComponent();
            this.proveedorSubMenu = m;
            this.provedor = p;
            foreach (var prov in provArr)
            {
                provincia_proveedor.Items.Add(prov.Key);
            }
            this.Tnombre_pedido.Text = p.nombre;
            this.Tcuit_proveedor.Text = p.cuit;
            this.provincia_proveedor.Text = p.provincia;
            this.localidad_proveedor.Text = p.localidad;
            this.direccion_proveedor.Text = p.direccion;
            this.correo_proveedor.Text = p.correo;
            this.telefono_proveedor.Text = p.telefono;
            if(p.activo == true)
            {
                this.checkBox1.Checked = true;
            }
            else
            {
                this.checkBox2.Checked = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(provincia_proveedor.Text == "" || provincia_proveedor.Text == null)
            {
                MessageBox.Show("Selecciona una provincia antes de seleccionar una localidad", "Entrada Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void onChangeSelectedProv(object sender, EventArgs e)
        {
            string prov = provincia_proveedor.Text;
            localidad_proveedor.Items.Clear();
            foreach (var loc in provArr[prov]){
                localidad_proveedor.Items.Add(loc);
            }
        }

        private void BFalta_ingresarcli_Click(object sender, EventArgs e)
        {
            String nombre = Tnombre_pedido.Text.Trim();
            String cuit = Tcuit_proveedor.Text.Trim();
            String provincia = provincia_proveedor.Text.Trim();
            String localidad = localidad_proveedor.Text.Trim();
            String direccion = direccion_proveedor.Text.Trim();
            String correo = correo_proveedor.Text.Trim();
            String telefono = telefono_proveedor.Text.Trim();
            
            if (nombre == "" || cuit == ""  || provincia == "" || localidad == "" || direccion == "" || correo == "" || telefono == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nombre) || !nombre.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Por favor, ingrese solo letras el campo de Nombre del proveedor.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!cuit.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo numeros en el campo cuit.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cuit.Length != 11)
            {
                MessageBox.Show("Por favor, ingrese un numero de cuil de 11 digitos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

     
            if (!telefono.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo telefono.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (telefono.Length != 10)
            {
                MessageBox.Show("Por favor, ingrese un numero de telefono de 10 digitos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarGmail_proveedor(correo))
            {
                MessageBox.Show("El correo no es válido. Asegúrate de que sea un correo de Gmail.");
            }





            if (nombre != "" && cuit != "" && correo != "" && telefono != "" && provincia != "" && localidad != "" && direccion != "" && ValidarGmail_proveedor(correo))
            {
                this.proveedorSubMenu.proveedorApp.ActualizarProveedor(new ProveedorDominio(this.provedor.id, nombre, cuit, provincia, localidad, direccion, correo, telefono, this.checkBox1.Checked ));
               this.proveedorSubMenu.fullProvedores();
                MessageBox.Show("El proveedor " + nombre + ","  + "CUIT: " + cuit + "CORREO:" + correo + "TELEFONO:" + telefono + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool ValidarGmail_proveedor(string email)
        {
            // Expresión regular para validar correos de Gmail
            string restricciones = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, restricciones);
        }

        private void BFalta_vaciarcampos_Click(object sender, EventArgs e)
        {
            String nombre = Tnombre_pedido.Text.Trim();
            String cuit = Tcuit_proveedor.Text.Trim();
            String provincia = provincia_proveedor.Text.Trim();
            String localidad = localidad_proveedor.Text.Trim();
            String direccion = direccion_proveedor.Text.Trim();
            String correo = correo_proveedor.Text.Trim();
            String telefono = telefono_proveedor.Text.Trim();
            if (nombre != "" || cuit != "" || provincia != "" || localidad != "" || direccion != "" || correo != "" || telefono != "")
            {
                Tnombre_pedido.Clear();
                Tcuit_proveedor.Clear();
                provincia_proveedor.Text = " ";
                localidad_proveedor.Text = " ";
                direccion_proveedor.Clear();
                correo_proveedor.Clear();
                telefono_proveedor.Clear();
            }
            else
            {
                MessageBox.Show("Los campos se encuentran vacios.", "No hay elementos que vaciar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
        }
    }
}
