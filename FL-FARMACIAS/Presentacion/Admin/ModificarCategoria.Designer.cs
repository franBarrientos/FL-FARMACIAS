namespace FL_FARMACIAS.Presentacion.Admin
{
    partial class ModificarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarCategoria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TC_descripcion = new System.Windows.Forms.TextBox();
            this.Bagregar_categoria = new System.Windows.Forms.Button();
            this.CC_inactivo = new System.Windows.Forms.CheckBox();
            this.LAS_cate_titulo = new System.Windows.Forms.Label();
            this.CC_activo = new System.Windows.Forms.CheckBox();
            this.LAS_cate_estado = new System.Windows.Forms.Label();
            this.LAS_cate_descrip = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TC_descripcion);
            this.panel1.Controls.Add(this.Bagregar_categoria);
            this.panel1.Controls.Add(this.CC_inactivo);
            this.panel1.Controls.Add(this.LAS_cate_titulo);
            this.panel1.Controls.Add(this.CC_activo);
            this.panel1.Controls.Add(this.LAS_cate_estado);
            this.panel1.Controls.Add(this.LAS_cate_descrip);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 344);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // TC_descripcion
            // 
            this.TC_descripcion.Location = new System.Drawing.Point(37, 141);
            this.TC_descripcion.Name = "TC_descripcion";
            this.TC_descripcion.Size = new System.Drawing.Size(311, 20);
            this.TC_descripcion.TabIndex = 5;
            // 
            // Bagregar_categoria
            // 
            this.Bagregar_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bagregar_categoria.Location = new System.Drawing.Point(113, 258);
            this.Bagregar_categoria.Name = "Bagregar_categoria";
            this.Bagregar_categoria.Size = new System.Drawing.Size(133, 62);
            this.Bagregar_categoria.TabIndex = 33;
            this.Bagregar_categoria.Text = "ACEPTAR";
            this.Bagregar_categoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bagregar_categoria.UseVisualStyleBackColor = true;
            this.Bagregar_categoria.Click += new System.EventHandler(this.Bagregar_categoria_Click_1);
            // 
            // CC_inactivo
            // 
            this.CC_inactivo.AutoSize = true;
            this.CC_inactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_inactivo.Location = new System.Drawing.Point(242, 225);
            this.CC_inactivo.Name = "CC_inactivo";
            this.CC_inactivo.Size = new System.Drawing.Size(84, 17);
            this.CC_inactivo.TabIndex = 4;
            this.CC_inactivo.Text = "INACTIVO";
            this.CC_inactivo.UseVisualStyleBackColor = true;
            this.CC_inactivo.CheckedChanged += new System.EventHandler(this.CC_inactivo_CheckedChanged);
            // 
            // LAS_cate_titulo
            // 
            this.LAS_cate_titulo.AutoSize = true;
            this.LAS_cate_titulo.BackColor = System.Drawing.Color.Transparent;
            this.LAS_cate_titulo.CausesValidation = false;
            this.LAS_cate_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAS_cate_titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LAS_cate_titulo.Location = new System.Drawing.Point(28, 12);
            this.LAS_cate_titulo.Name = "LAS_cate_titulo";
            this.LAS_cate_titulo.Size = new System.Drawing.Size(382, 31);
            this.LAS_cate_titulo.TabIndex = 0;
            this.LAS_cate_titulo.Text = "MODIFICAR  CATEGORIAS";
            // 
            // CC_activo
            // 
            this.CC_activo.AutoSize = true;
            this.CC_activo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_activo.Location = new System.Drawing.Point(38, 225);
            this.CC_activo.Name = "CC_activo";
            this.CC_activo.Size = new System.Drawing.Size(71, 17);
            this.CC_activo.TabIndex = 3;
            this.CC_activo.Text = "ACTIVO";
            this.CC_activo.UseVisualStyleBackColor = true;
            this.CC_activo.CheckedChanged += new System.EventHandler(this.CC_activo_CheckedChanged);
            // 
            // LAS_cate_estado
            // 
            this.LAS_cate_estado.AutoSize = true;
            this.LAS_cate_estado.BackColor = System.Drawing.Color.Transparent;
            this.LAS_cate_estado.CausesValidation = false;
            this.LAS_cate_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAS_cate_estado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LAS_cate_estado.Location = new System.Drawing.Point(160, 187);
            this.LAS_cate_estado.Name = "LAS_cate_estado";
            this.LAS_cate_estado.Size = new System.Drawing.Size(64, 20);
            this.LAS_cate_estado.TabIndex = 2;
            this.LAS_cate_estado.Text = "Estado:";
            // 
            // LAS_cate_descrip
            // 
            this.LAS_cate_descrip.AutoSize = true;
            this.LAS_cate_descrip.BackColor = System.Drawing.Color.Transparent;
            this.LAS_cate_descrip.CausesValidation = false;
            this.LAS_cate_descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAS_cate_descrip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LAS_cate_descrip.Location = new System.Drawing.Point(145, 118);
            this.LAS_cate_descrip.Name = "LAS_cate_descrip";
            this.LAS_cate_descrip.Size = new System.Drawing.Size(96, 20);
            this.LAS_cate_descrip.TabIndex = 1;
            this.LAS_cate_descrip.Text = "Descripcion:";
            // 
            // ModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(441, 368);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModificarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Categoria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LAS_cate_titulo;
        private System.Windows.Forms.Label LAS_cate_descrip;
        private System.Windows.Forms.CheckBox CC_inactivo;
        private System.Windows.Forms.CheckBox CC_activo;
        private System.Windows.Forms.Label LAS_cate_estado;
        private System.Windows.Forms.TextBox TC_descripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Bagregar_categoria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}