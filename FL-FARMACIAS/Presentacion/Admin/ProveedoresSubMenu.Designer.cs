using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FL_FARMACIAS.Presentacion.Admin
{
    partial class ProveedoresSubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedoresSubMenu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.placeholderTextBox1 = new PlaceholderTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3w = new System.Windows.Forms.Label();
            this.button3w = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.placeholderTextBox2 = new PlaceholderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODIFICARP = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ELIMINARP = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR_CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI_SOLICITANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DETALLE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.APROBAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RECIBIR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CANCELAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MODIFICAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1036, 573);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.placeholderTextBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3w);
            this.tabPage1.Controls.Add(this.button3w);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1028, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PEDIDOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // placeholderTextBox1
            // 
            this.placeholderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeholderTextBox1.IsPassword = false;
            this.placeholderTextBox1.Location = new System.Drawing.Point(22, 179);
            this.placeholderTextBox1.Name = "placeholderTextBox1";
            this.placeholderTextBox1.Placeholder = "INGRESE ID PEDIDO";
            this.placeholderTextBox1.Size = new System.Drawing.Size(264, 20);
            this.placeholderTextBox1.TabIndex = 20;
            this.placeholderTextBox1.Text = "INGRESE ID PEDIDO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(425, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 41);
            this.label4.TabIndex = 19;
            this.label4.Text = "PEDIDOS";
            // 
            // label3w
            // 
            this.label3w.AutoSize = true;
            this.label3w.BackColor = System.Drawing.Color.Transparent;
            this.label3w.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3w.ForeColor = System.Drawing.Color.Black;
            this.label3w.Location = new System.Drawing.Point(477, 111);
            this.label3w.Margin = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.label3w.Name = "label3w";
            this.label3w.Size = new System.Drawing.Size(77, 18);
            this.label3w.TabIndex = 18;
            this.label3w.Text = "FILTROS";
            // 
            // button3w
            // 
            this.button3w.BackColor = System.Drawing.Color.White;
            this.button3w.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3w.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3w.Image = ((System.Drawing.Image)(resources.GetObject("button3w.Image")));
            this.button3w.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3w.Location = new System.Drawing.Point(22, 94);
            this.button3w.Margin = new System.Windows.Forms.Padding(64);
            this.button3w.Name = "button3w";
            this.button3w.Size = new System.Drawing.Size(207, 55);
            this.button3w.TabIndex = 17;
            this.button3w.Text = "REALIZAR NUEVO PEDIDO";
            this.button3w.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3w.UseVisualStyleBackColor = false;
            this.button3w.Click += new System.EventHandler(this.button3w_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(858, 163);
            this.button2.Margin = new System.Windows.Forms.Padding(64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 39);
            this.button2.TabIndex = 14;
            this.button2.Text = "LIMPIAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(740, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "BUSCAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FECHAINGRESO,
            this.NOMBRE,
            this.PROVEEDOR_CUIT,
            this.DNI,
            this.DNI_SOLICITANTE,
            this.ESTADOP,
            this.DETALLE,
            this.APROBAR,
            this.RECIBIR,
            this.CANCELAR,
            this.MODIFICAR});
            this.dataGridView1.Location = new System.Drawing.Point(13, 228);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 309);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.tabPage2.Controls.Add(this.placeholderTextBox2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1028, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PROVEEDORES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // placeholderTextBox2
            // 
            this.placeholderTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.placeholderTextBox2.IsPassword = false;
            this.placeholderTextBox2.Location = new System.Drawing.Point(382, 175);
            this.placeholderTextBox2.Name = "placeholderTextBox2";
            this.placeholderTextBox2.Placeholder = "INGRESE NOMBRE O CUIT";
            this.placeholderTextBox2.Size = new System.Drawing.Size(236, 20);
            this.placeholderTextBox2.TabIndex = 29;
            this.placeholderTextBox2.Text = "INGRESE NOMBRE O CUIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(382, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 41);
            this.label1.TabIndex = 28;
            this.label1.Text = "PROVEEDORES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(484, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "FILTROS";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(29, 87);
            this.button3.Margin = new System.Windows.Forms.Padding(64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 61);
            this.button3.TabIndex = 26;
            this.button3.Text = "DAR DE ALTA NUEVO PROVEEDOR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(780, 161);
            this.button4.Margin = new System.Windows.Forms.Padding(64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 47);
            this.button4.TabIndex = 23;
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
            this.button5.Location = new System.Drawing.Point(669, 161);
            this.button5.Margin = new System.Windows.Forms.Padding(64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 47);
            this.button5.TabIndex = 22;
            this.button5.Text = "BUSCAR";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDP,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewButtonColumn1,
            this.ESTADO,
            this.MODIFICARP,
            this.ELIMINARP});
            this.dataGridView2.Location = new System.Drawing.Point(14, 226);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 60;
            this.dataGridView2.Size = new System.Drawing.Size(1001, 309);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            this.dataGridView2.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView2_RowPrePaint);
            // 
            // IDP
            // 
            this.IDP.HeaderText = "ID";
            this.IDP.MinimumWidth = 8;
            this.IDP.Name = "IDP";
            this.IDP.ReadOnly = true;
            this.IDP.Visible = false;
            this.IDP.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "CUIT";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "TELEFONO";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "CORREO";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "DIRECCION";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "LOCALIDAD";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "PROVINCIA";
            this.dataGridViewButtonColumn1.MinimumWidth = 8;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewButtonColumn1.Width = 150;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Visible = false;
            // 
            // MODIFICARP
            // 
            this.MODIFICARP.HeaderText = "MODIFICAR";
            this.MODIFICARP.MinimumWidth = 8;
            this.MODIFICARP.Name = "MODIFICARP";
            this.MODIFICARP.ReadOnly = true;
            this.MODIFICARP.Width = 150;
            // 
            // ELIMINARP
            // 
            this.ELIMINARP.HeaderText = "ELIMINAR";
            this.ELIMINARP.MinimumWidth = 8;
            this.ELIMINARP.Name = "ELIMINARP";
            this.ELIMINARP.ReadOnly = true;
            this.ELIMINARP.Width = 150;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID PEDIDO";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // FECHAINGRESO
            // 
            this.FECHAINGRESO.HeaderText = "FECHA ";
            this.FECHAINGRESO.MinimumWidth = 8;
            this.FECHAINGRESO.Name = "FECHAINGRESO";
            this.FECHAINGRESO.ReadOnly = true;
            this.FECHAINGRESO.Width = 150;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "PROVEEDOR";
            this.NOMBRE.MinimumWidth = 8;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NOMBRE.Width = 150;
            // 
            // PROVEEDOR_CUIT
            // 
            this.PROVEEDOR_CUIT.HeaderText = "CUIT PROVEEDOR";
            this.PROVEEDOR_CUIT.Name = "PROVEEDOR_CUIT";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "SOLICITANTE";
            this.DNI.MinimumWidth = 8;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DNI.Width = 150;
            // 
            // DNI_SOLICITANTE
            // 
            this.DNI_SOLICITANTE.HeaderText = "DNI SOLICITANTE";
            this.DNI_SOLICITANTE.Name = "DNI_SOLICITANTE";
            // 
            // ESTADOP
            // 
            this.ESTADOP.HeaderText = "ESTADO";
            this.ESTADOP.MinimumWidth = 8;
            this.ESTADOP.Name = "ESTADOP";
            this.ESTADOP.ReadOnly = true;
            this.ESTADOP.Width = 150;
            // 
            // DETALLE
            // 
            this.DETALLE.HeaderText = "PRODUCTOS";
            this.DETALLE.MinimumWidth = 8;
            this.DETALLE.Name = "DETALLE";
            this.DETALLE.ReadOnly = true;
            this.DETALLE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DETALLE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DETALLE.Width = 150;
            // 
            // APROBAR
            // 
            this.APROBAR.HeaderText = "APROBAR";
            this.APROBAR.Name = "APROBAR";
            // 
            // RECIBIR
            // 
            this.RECIBIR.HeaderText = "RECIBIR";
            this.RECIBIR.Name = "RECIBIR";
            this.RECIBIR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RECIBIR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CANCELAR
            // 
            this.CANCELAR.HeaderText = "CANCELAR";
            this.CANCELAR.MinimumWidth = 8;
            this.CANCELAR.Name = "CANCELAR";
            this.CANCELAR.ReadOnly = true;
            this.CANCELAR.Width = 150;
            // 
            // MODIFICAR
            // 
            this.MODIFICAR.HeaderText = "MODIFICAR";
            this.MODIFICAR.MinimumWidth = 8;
            this.MODIFICAR.Name = "MODIFICAR";
            this.MODIFICAR.ReadOnly = true;
            this.MODIFICAR.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Fecha hasta";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(323, 163);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "Fecha desde";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(532, 179);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker2.TabIndex = 57;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 56;
            this.dateTimePicker1.Value = new System.DateTime(1970, 10, 19, 20, 19, 0, 0);
            // 
            // ProveedoresSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 597);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(64);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProveedoresSubMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Pedidos y Proveedores";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3w;
        private Button button3w;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Label label3;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label1;
        private PlaceholderTextBox placeholderTextBox1;
        private PlaceholderTextBox placeholderTextBox2;
        private DataGridViewTextBoxColumn IDP;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewButtonColumn1;
        private DataGridViewTextBoxColumn ESTADO;
        private DataGridViewButtonColumn MODIFICARP;
        private DataGridViewButtonColumn ELIMINARP;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FECHAINGRESO;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn PROVEEDOR_CUIT;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn DNI_SOLICITANTE;
        private DataGridViewTextBoxColumn ESTADOP;
        private DataGridViewButtonColumn DETALLE;
        private DataGridViewButtonColumn APROBAR;
        private DataGridViewButtonColumn RECIBIR;
        private DataGridViewButtonColumn CANCELAR;
        private DataGridViewButtonColumn MODIFICAR;
        private Label label2;
        private Label label21;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
    }
}