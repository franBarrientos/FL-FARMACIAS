﻿using System;
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
    public partial class AltaMarcas : Form
    {
        public productoSubMenu productoSubMenu;
        public AltaMarcas(productoSubMenu productoSubMenu)
        {
            InitializeComponent();
            this.productoSubMenu = productoSubMenu;
        }

        private void Bagregar_categoria_Click(object sender, EventArgs e)
        {

        }
    }
}
