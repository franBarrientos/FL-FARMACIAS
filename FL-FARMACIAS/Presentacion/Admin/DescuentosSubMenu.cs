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

        public DescuentosSubMenu()
        {
            InitializeComponent();
            foreach (var p in BD.descuentos)
            {
                dataGridView2.Rows.Add(p.id, p.descripcion, p.estado == true ? "ACTIVO" : "NO ACTIVO", p.porcentajeDescuento.ToString(), "EDITAR", "ELIMINAR" );
            }
        
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            new AltaDescuentos().Show();
        }
    }
}
