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
            this.TPM_codproducto.Text = p.codProducto;
            this.TPM_nombre.Text = p.codProducto;
            this.TPM_precio.Text = p.precio.ToString();
            this.TPM_stock.Text = p.stock.ToString();
            this.CBM_activo.Checked = p.estado;

        }
    }
}
