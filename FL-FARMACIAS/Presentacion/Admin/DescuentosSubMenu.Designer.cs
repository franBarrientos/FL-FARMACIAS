using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FL_FARMACIAS.Presentacion.Admin
{
    partial class DescuentosSubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DescuentosSubMenu));
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PORCENTAJE_DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODIFICAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.placeholderTextBox1 = new PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(11, 55);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 60);
            this.button3.TabIndex = 24;
            this.button3.Text = "DAR DE ALTA NUEVO DESCUENTO";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(512, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "FILTROS";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DESCRIPCION,
            this.ESTADO,
            this.PORCENTAJE_DESCUENTO,
            this.MODIFICAR,
            this.ELIMINAR});
            this.dataGridView2.Location = new System.Drawing.Point(70, 189);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 60;
            this.dataGridView2.Size = new System.Drawing.Size(918, 374);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.MinimumWidth = 8;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 150;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.MinimumWidth = 8;
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Width = 150;
            // 
            // PORCENTAJE_DESCUENTO
            // 
            this.PORCENTAJE_DESCUENTO.HeaderText = "PORCENTAJE DESCUENTO";
            this.PORCENTAJE_DESCUENTO.Name = "PORCENTAJE_DESCUENTO";
            this.PORCENTAJE_DESCUENTO.ReadOnly = true;
            // 
            // MODIFICAR
            // 
            this.MODIFICAR.HeaderText = "MODIFICAR";
            this.MODIFICAR.MinimumWidth = 8;
            this.MODIFICAR.Name = "MODIFICAR";
            this.MODIFICAR.ReadOnly = true;
            this.MODIFICAR.Width = 150;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.MinimumWidth = 8;
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            this.ELIMINAR.Width = 150;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(869, 140);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 39);
            this.button4.TabIndex = 23;
            this.button4.Text = "LIMPIAR";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(664, 138);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 39);
            this.button5.TabIndex = 22;
            this.button5.Text = "BUSCAR";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(404, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "ACTIVO";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(475, 153);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "NO ACTIVO";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ESTADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(244, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 41);
            this.label2.TabIndex = 30;
            this.label2.Text = "DESCUENTOS Y OBRA SOCIALES";
            // 
            // placeholderTextBox1
            // 
            this.placeholderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeholderTextBox1.IsPassword = false;
            this.placeholderTextBox1.Location = new System.Drawing.Point(70, 148);
            this.placeholderTextBox1.Name = "placeholderTextBox1";
            this.placeholderTextBox1.Placeholder = "INGRESE ID";
            this.placeholderTextBox1.Size = new System.Drawing.Size(252, 20);
            this.placeholderTextBox1.TabIndex = 28;
            this.placeholderTextBox1.Text = "INGRESE ID";
            // 
            // DescuentosSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1060, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.placeholderTextBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DescuentosSubMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Descuentos y Obras Sociales Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private Button button3;
        private Label label4;
        private DataGridView dataGridView2;
        private Button button4;
        private Button button5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private PlaceholderTextBox placeholderTextBox1;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DESCRIPCION;
        private DataGridViewTextBoxColumn ESTADO;
        private DataGridViewTextBoxColumn PORCENTAJE_DESCUENTO;
        private DataGridViewButtonColumn MODIFICAR;
        private DataGridViewButtonColumn ELIMINAR;
        private Label label2;
    }
}