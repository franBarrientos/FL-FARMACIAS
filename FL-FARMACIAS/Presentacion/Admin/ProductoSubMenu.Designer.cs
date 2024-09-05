using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FL_FARMACIAS.Presentacion.Admin
{
    partial class productoSubMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MODIFICAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3w = new System.Windows.Forms.Button();
            this.label3w = new System.Windows.Forms.Label();
            this.PRODUCTOS = new System.Windows.Forms.TabControl();
            this.prodTab = new System.Windows.Forms.TabPage();
            this.catTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PRODUCTOS.SuspendLayout();
            this.prodTab.SuspendLayout();
            this.catTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CODIGO_PROD,
            this.NOMBRE,
            this.PRECIO,
            this.STOCK,
            this.CATEGORIA,
            this.ACTIVO,
            this.ELIMINAR,
            this.MODIFICAR});
            this.dataGridView1.Location = new System.Drawing.Point(56, 153);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(903, 364);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // CODIGO_PROD
            // 
            this.CODIGO_PROD.HeaderText = "CODIGO PRODUCTO";
            this.CODIGO_PROD.MinimumWidth = 10;
            this.CODIGO_PROD.Name = "CODIGO_PROD";
            this.CODIGO_PROD.Width = 200;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 10;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 200;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.MinimumWidth = 10;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.Width = 200;
            // 
            // STOCK
            // 
            this.STOCK.HeaderText = "STOCK";
            this.STOCK.MinimumWidth = 10;
            this.STOCK.Name = "STOCK";
            this.STOCK.ReadOnly = true;
            this.STOCK.Width = 200;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.MinimumWidth = 10;
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            this.CATEGORIA.Width = 200;
            // 
            // ACTIVO
            // 
            this.ACTIVO.HeaderText = "ESTADO";
            this.ACTIVO.MinimumWidth = 10;
            this.ACTIVO.Name = "ACTIVO";
            this.ACTIVO.ReadOnly = true;
            this.ACTIVO.Width = 200;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.MinimumWidth = 8;
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            this.ELIMINAR.Text = "ELIMINAR";
            this.ELIMINAR.UseColumnTextForButtonValue = true;
            this.ELIMINAR.Width = 150;
            // 
            // MODIFICAR
            // 
            this.MODIFICAR.HeaderText = "MODIFICAR";
            this.MODIFICAR.MinimumWidth = 8;
            this.MODIFICAR.Name = "MODIFICAR";
            this.MODIFICAR.ReadOnly = true;
            this.MODIFICAR.Text = "MODIFICAR";
            this.MODIFICAR.UseColumnTextForButtonValue = true;
            this.MODIFICAR.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(440, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRODUCTOS";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(100, 114);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 19);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "INGRESE NOMBRE O COD PRODUCTO";
            this.textBox1.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.TabIndexChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.converTextBlack);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 106);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Perfumeria"});
            this.comboBox1.Location = new System.Drawing.Point(437, 114);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Todos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(366, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CATEGORIA";
            // 
            // button3w
            // 
            this.button3w.Location = new System.Drawing.Point(33, 20);
            this.button3w.Margin = new System.Windows.Forms.Padding(2);
            this.button3w.Name = "button3w";
            this.button3w.Size = new System.Drawing.Size(118, 49);
            this.button3w.TabIndex = 8;
            this.button3w.Text = "DAR DE ALTA NUEVO PRODUCTO";
            this.button3w.UseVisualStyleBackColor = true;
            this.button3w.Click += new System.EventHandler(this.button3w_Click);
            // 
            // label3w
            // 
            this.label3w.AutoSize = true;
            this.label3w.BackColor = System.Drawing.Color.Transparent;
            this.label3w.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3w.ForeColor = System.Drawing.Color.Black;
            this.label3w.Location = new System.Drawing.Point(456, 79);
            this.label3w.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3w.Name = "label3w";
            this.label3w.Size = new System.Drawing.Size(77, 18);
            this.label3w.TabIndex = 9;
            this.label3w.Text = "FILTROS";
            // 
            // PRODUCTOS
            // 
            this.PRODUCTOS.Controls.Add(this.prodTab);
            this.PRODUCTOS.Controls.Add(this.catTab);
            this.PRODUCTOS.Location = new System.Drawing.Point(28, 23);
            this.PRODUCTOS.Margin = new System.Windows.Forms.Padding(2);
            this.PRODUCTOS.Name = "PRODUCTOS";
            this.PRODUCTOS.SelectedIndex = 0;
            this.PRODUCTOS.Size = new System.Drawing.Size(1005, 563);
            this.PRODUCTOS.TabIndex = 10;
            // 
            // prodTab
            // 
            this.prodTab.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.prodTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prodTab.Controls.Add(this.label1);
            this.prodTab.Controls.Add(this.button3w);
            this.prodTab.Controls.Add(this.label3w);
            this.prodTab.Controls.Add(this.dataGridView1);
            this.prodTab.Controls.Add(this.textBox1);
            this.prodTab.Controls.Add(this.label2);
            this.prodTab.Controls.Add(this.button2);
            this.prodTab.Controls.Add(this.comboBox1);
            this.prodTab.Controls.Add(this.button1);
            this.prodTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodTab.Location = new System.Drawing.Point(4, 22);
            this.prodTab.Margin = new System.Windows.Forms.Padding(2);
            this.prodTab.Name = "prodTab";
            this.prodTab.Padding = new System.Windows.Forms.Padding(2);
            this.prodTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prodTab.Size = new System.Drawing.Size(997, 537);
            this.prodTab.TabIndex = 0;
            this.prodTab.Text = "PRODUCTOS";
            this.prodTab.UseVisualStyleBackColor = true;
            // 
            // catTab
            // 
            this.catTab.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.catTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.catTab.Controls.Add(this.label3);
            this.catTab.Controls.Add(this.button3);
            this.catTab.Controls.Add(this.label4);
            this.catTab.Controls.Add(this.dataGridView2);
            this.catTab.Controls.Add(this.textBox2);
            this.catTab.Controls.Add(this.button4);
            this.catTab.Controls.Add(this.button5);
            this.catTab.Location = new System.Drawing.Point(4, 22);
            this.catTab.Margin = new System.Windows.Forms.Padding(2);
            this.catTab.Name = "catTab";
            this.catTab.Padding = new System.Windows.Forms.Padding(2);
            this.catTab.Size = new System.Drawing.Size(997, 537);
            this.catTab.TabIndex = 1;
            this.catTab.Text = "CATEGORIAS";
            this.catTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(442, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "CATEGORIAS";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(79, 42);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 49);
            this.button3.TabIndex = 17;
            this.button3.Text = "DAR DE ALTA NUEVA CATEGORIA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(484, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "FILTROS";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewButtonColumn2,
            this.dataGridViewButtonColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(302, 146);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 60;
            this.dataGridView2.Size = new System.Drawing.Size(452, 374);
            this.dataGridView2.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "DESCRIPCION";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "ESTADO";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "ELIMINAR";
            this.dataGridViewButtonColumn2.MinimumWidth = 8;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Width = 150;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "MODIFICAR";
            this.dataGridViewButtonColumn3.MinimumWidth = 8;
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.ReadOnly = true;
            this.dataGridViewButtonColumn3.Width = 150;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(274, 112);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "INGRESE ID O DESCRIPCION";
            this.textBox2.Click += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.TabIndexChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.TextChanged += new System.EventHandler(this.converTextBlack2);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(634, 104);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 31);
            this.button4.TabIndex = 14;
            this.button4.Text = "LIMPIAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(520, 104);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 31);
            this.button5.TabIndex = 13;
            this.button5.Text = "BUSCAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // productoSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1057, 587);
            this.Controls.Add(this.PRODUCTOS);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "productoSubMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Productos y Categorias Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PRODUCTOS.ResumeLayout(false);
            this.prodTab.ResumeLayout(false);
            this.prodTab.PerformLayout();
            this.catTab.ResumeLayout(false);
            this.catTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

       
   
        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label2;
        private Button button3w;
        private Label label3w;
        private TabPage prodTab;
        private TabPage catTab;
        private TabControl PRODUCTOS;
        private Label label3;
        private Button button3;
        private Label label4;
        private DataGridView dataGridView2;
        private TextBox textBox2;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CODIGO_PROD;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn STOCK;
        private DataGridViewTextBoxColumn CATEGORIA;
        private DataGridViewTextBoxColumn ACTIVO;
        private DataGridViewButtonColumn ELIMINAR;
        private DataGridViewButtonColumn MODIFICAR;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
    }
}