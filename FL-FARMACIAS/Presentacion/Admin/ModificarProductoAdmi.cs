using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class ModificarProductoAdmi : Form
    {
        public ModificarProductoAdmi(ProductoDominio p)
        {
            InitializeComponent();
            this.TPM_codproducto.Text = p.CodProducto;
            this.TPM_nombre.Text = p.Nombre;
            this.TPM_precio.Text = p.Precio.ToString();
            this.TPM_stock.Text = p.Stock.ToString();
            this.CBM_activo.Checked = p.Estado;

        }
    }
}
