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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productoSubMenu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LABORATORIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MODIFICAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3w = new System.Windows.Forms.Button();
            this.PRODUCTOS = new System.Windows.Forms.TabControl();
            this.prodTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new PlaceholderTextBox();
            this.catTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new PlaceholderTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCIONC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELIMINARC = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MODIFICARC = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CODIGO_PROD,
            this.NOMBRE,
            this.PRECIO,
            this.STOCK,
            this.CATEGORIA,
            this.MARCA,
            this.LABORATORIO,
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
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
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
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            // 
            // LABORATORIO
            // 
            this.LABORATORIO.HeaderText = "LABORATORIO";
            this.LABORATORIO.Name = "LABORATORIO";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(672, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "BUSCAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(801, 99);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "LIMPIAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(480, 107);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CATEGORIA";
            // 
            // button3w
            // 
            this.button3w.BackColor = System.Drawing.Color.White;
            this.button3w.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3w.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3w.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3w.Image = ((System.Drawing.Image)(resources.GetObject("button3w.Image")));
            this.button3w.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3w.Location = new System.Drawing.Point(42, 45);
            this.button3w.Margin = new System.Windows.Forms.Padding(2);
            this.button3w.Name = "button3w";
            this.button3w.Size = new System.Drawing.Size(242, 59);
            this.button3w.TabIndex = 8;
            this.button3w.Text = "DAR DE ALTA NUEVO PRODUCTO";
            this.button3w.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3w.UseVisualStyleBackColor = false;
            this.button3w.Click += new System.EventHandler(this.button3w_Click);
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
            this.prodTab.Controls.Add(this.label1);
            this.prodTab.Controls.Add(this.textBox1);
            this.prodTab.Controls.Add(this.button3w);
            this.prodTab.Controls.Add(this.dataGridView1);
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
            this.prodTab.Click += new System.EventHandler(this.prodTab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(374, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "PRODUCTOS";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.IsPassword = false;
            this.textBox1.Location = new System.Drawing.Point(56, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Placeholder = "INGRESE NOMBRE O COD PRODUCTO";
            this.textBox1.Size = new System.Drawing.Size(294, 19);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "INGRESE NOMBRE O COD PRODUCTO";
            // 
            // catTab
            // 
            this.catTab.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.catTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.catTab.Controls.Add(this.label3);
            this.catTab.Controls.Add(this.textBox2);
            this.catTab.Controls.Add(this.button3);
            this.catTab.Controls.Add(this.label4);
            this.catTab.Controls.Add(this.dataGridView2);
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
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(377, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 41);
            this.label3.TabIndex = 30;
            this.label3.Text = "CATEGORIAS";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.IsPassword = false;
            this.textBox2.Location = new System.Drawing.Point(339, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Placeholder = "INGRESE ID O DESCRIPCION";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(23, 68);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 59);
            this.button3.TabIndex = 17;
            this.button3.Text = "DAR DE ALTA NUEVA CATEGORIA";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(483, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "FILTROS";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDC,
            this.DESCRIPCIONC,
            this.ESTADOC,
            this.ELIMINARC,
            this.MODIFICARC});
            this.dataGridView2.Location = new System.Drawing.Point(109, 146);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 60;
            this.dataGridView2.Size = new System.Drawing.Size(818, 374);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            this.dataGridView2.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView2_RowPrePaint);
            // 
            // IDC
            // 
            this.IDC.HeaderText = "ID";
            this.IDC.MinimumWidth = 8;
            this.IDC.Name = "IDC";
            this.IDC.ReadOnly = true;
            this.IDC.Width = 150;
            // 
            // DESCRIPCIONC
            // 
            this.DESCRIPCIONC.HeaderText = "DESCRIPCION";
            this.DESCRIPCIONC.MinimumWidth = 8;
            this.DESCRIPCIONC.Name = "DESCRIPCIONC";
            this.DESCRIPCIONC.ReadOnly = true;
            this.DESCRIPCIONC.Width = 150;
            // 
            // ESTADOC
            // 
            this.ESTADOC.HeaderText = "ESTADO";
            this.ESTADOC.MinimumWidth = 8;
            this.ESTADOC.Name = "ESTADOC";
            this.ESTADOC.ReadOnly = true;
            this.ESTADOC.Width = 150;
            // 
            // ELIMINARC
            // 
            this.ELIMINARC.HeaderText = "ELIMINAR";
            this.ELIMINARC.MinimumWidth = 8;
            this.ELIMINARC.Name = "ELIMINARC";
            this.ELIMINARC.ReadOnly = true;
            this.ELIMINARC.Width = 150;
            // 
            // MODIFICARC
            // 
            this.MODIFICARC.HeaderText = "MODIFICAR";
            this.MODIFICARC.MinimumWidth = 8;
            this.MODIFICARC.Name = "MODIFICARC";
            this.MODIFICARC.ReadOnly = true;
            this.MODIFICARC.Width = 150;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(687, 102);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 40);
            this.button4.TabIndex = 14;
            this.button4.Text = "LIMPIAR";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(593, 103);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 39);
            this.button5.TabIndex = 13;
            this.button5.Text = "BUSCAR";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // productoSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1060, 597);
            this.Controls.Add(this.PRODUCTOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "productoSubMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Productos y Categorias ";
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
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label2;
        private Button button3w;
        private TabPage prodTab;
        private TabPage catTab;
        private TabControl PRODUCTOS;
        private Button button3;
        private Label label4;
        private DataGridView dataGridView2;
        private Button button4;
        private Button button5;
        private PlaceholderTextBox textBox2;
        private PlaceholderTextBox textBox1;
        private Label label1;
        private Label label3;
        private DataGridViewTextBoxColumn IDC;
        private DataGridViewTextBoxColumn DESCRIPCIONC;
        private DataGridViewTextBoxColumn ESTADOC;
        private DataGridViewButtonColumn ELIMINARC;
        private DataGridViewButtonColumn MODIFICARC;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CODIGO_PROD;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn STOCK;
        private DataGridViewTextBoxColumn CATEGORIA;
        private DataGridViewTextBoxColumn MARCA;
        private DataGridViewTextBoxColumn LABORATORIO;
        private DataGridViewTextBoxColumn ACTIVO;
        private DataGridViewButtonColumn ELIMINAR;
        private DataGridViewButtonColumn MODIFICAR;
    }
}