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

namespace FL_FARMACIAS.Presentacion.Farmaceutico
{
    public partial class AltaProveedor : Form
    {

        public Dictionary<string, List<string>> provArr = Shared.provinciasYLocalidades;

        public AltaProveedor()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "" || comboBox1.Text == null)
            {
                MessageBox.Show("Selecciona una provincia antes de seleccionar una localidad", "Entrada Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void onChangeSelectedProv(object sender, EventArgs e)
        {
            string prov = comboBox1.Text;
            comboBox2.Items.Clear();
            foreach (var loc in provArr[prov]){
                comboBox2.Items.Add(loc);
            }
        }


    }
}
