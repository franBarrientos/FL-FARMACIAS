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
    public partial class AgrerarProductoAdmi : Form
    {
        private productoSubMenu productoSubMenu;
        public AgrerarProductoAdmi(productoSubMenu productoSubMenu)
        {
            InitializeComponent();
            this.productoSubMenu = productoSubMenu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.productoSubMenu.insertProduct(new Dominio.ProductoDominio( 6, "P006", "Producto 6", 10.5, 100, new Dominio.CategoriaDominio(2, "Perfumeria", true), true ));
        }
    }
}
