using FL_FARMACIAS.Aplicacion;
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
    public partial class DescuentosSubMenu : Form
    { 
        public DescuentoAplicacion descuentosAplicacion;
        public AltaDescuentos subForm;

        public DescuentosSubMenu()
        {
            InitializeComponent();
            descuentosAplicacion = new DescuentoAplicacion();
            fullDeaults();
        }

        public void fullDeaults()
        {
            this.placeholderTextBox1.Text = "INGRESE ID O DESCRIPCION";
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;
            dataGridView2.Rows.Clear();
            foreach (var descuento in descuentosAplicacion.ObtenerDescuentos())
            {
                dataGridView2.Rows.Add(descuento.id, descuento.descripcion, descuento.estado ? "ACTIVO" : "INACTIVO", descuento.porcentajeDescuento, "MODIFICAR", "ELIMINAR");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var dataGridView = sender as DataGridView;
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Extrae el valor del ID (asumiendo que está en la primera columna)
                var id = row.Cells["ID"].Value.ToString(); // O usa el índice de la columna si prefieres: row.Cells[0]

                // Extrae el valor de otras columnas (puedes usar el nombre de la columna o el índice)
                var descripcion = row.Cells["DESCRIPCION"].Value.ToString();
                var estado = row.Cells["ESTADO"].Value.ToString().Trim();
                var porcentajeDescuento = row.Cells["PORCENTAJE_DESCUENTO"].Value.ToString();
                int idI = int.Parse(row.Cells["ID"].Value.ToString());
                double porcentajeDescuentoD = double.Parse(row.Cells["PORCENTAJE_DESCUENTO"].Value.ToString());

            


                if (dataGridView.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    if (estado == "INACTIVO")
                    {
                        MessageBox.Show("El descuento: " + id + " con la descripcin: " + descripcion + " ya no esta activo.", "Descuento inactivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el descuento " + descripcion + " ?",
                                                       "Confirmar eliminación",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        this.descuentosAplicacion.ActualizarDescuento(new DescuentoDominio(int.Parse(id), descripcion, porcentajeDescuentoD, false));
                        MessageBox.Show("El descuento" + id + "con la descripcion: " + descripcion + ", cuenta con un porcentaje de descuento del " + porcentajeDescuentoD + "% ha sido eliminado con exito.", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.fullDeaults();
                    }
                }
                else if (dataGridView.Columns[e.ColumnIndex].Name == "MODIFICAR")
                {
                    var aux = estado == "ACTIVO" ? true : false;
                              
                    var dtpModify = new DescuentoDominio(idI, descripcion, porcentajeDescuentoD, aux);
                    new ModificarDescuentas(dtpModify, this).Show();                    
                }
                
                
            }

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (subForm != null && !subForm.IsDisposed)
            {
                subForm.BringToFront();
            }
            else
            {
                // Si no existe, crea una nueva instancia y la añade al diccionario
                subForm = new AltaDescuentos(this.descuentosAplicacion, this);
                subForm.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            // Obtener el valor de idOrDesc y limpiar el campo si es el placeholder
            string idOrDesc = this.placeholderTextBox1.Text;
            if (idOrDesc == "INGRESE ID O DESCRIPCION")
            {
                idOrDesc = string.Empty;
            }

            // Tratar de convertir a entero, si es válido se usa como ID
            int? id = int.TryParse(idOrDesc, out int parsedId) ? (int?)parsedId : null;

            if (id > 0) {
                idOrDesc = string.Empty;
            }

            // Determinar el estado basándose en los checkboxes
            bool? estado = null;
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                estado = true;  // Activo
            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                estado = false; // Inactivo
            }

            // Limpiar el DataGridView antes de agregar nuevas filas
            List<DescuentoDominio> matcheds = descuentosAplicacion.BuscarDescuentos(id, string.IsNullOrWhiteSpace(idOrDesc) ? null : idOrDesc, estado);
            dataGridView2.Rows.Clear();
            foreach (var descuento in matcheds)
            {
                dataGridView2.Rows.Add(descuento.id, descuento.descripcion, descuento.estado ? "ACTIVO" : "INACTIVO", descuento.porcentajeDescuento, "MODIFICAR", "ELIMINAR");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fullDeaults();
        }
    }
}
