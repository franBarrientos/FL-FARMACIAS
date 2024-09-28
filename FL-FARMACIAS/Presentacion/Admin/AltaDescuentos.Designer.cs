namespace FL_FARMACIAS.Presentacion.Admin
{
    partial class AltaDescuentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaDescuentos));
            this.Pfarm_altacliente = new System.Windows.Forms.Panel();
            this.inactivo_descuento = new System.Windows.Forms.CheckBox();
            this.activo_descuento = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BFalta_vaciarcampos = new System.Windows.Forms.Button();
            this.BFalta_ingresarcli = new System.Windows.Forms.Button();
            this.porcentaje_descuento = new System.Windows.Forms.TextBox();
            this.descripcion_descuento = new System.Windows.Forms.TextBox();
            this.LFalta_apellido = new System.Windows.Forms.Label();
            this.LFalta_nombre = new System.Windows.Forms.Label();
            this.Lfarm_tituloalt = new System.Windows.Forms.Label();
            this.Pfarm_altacliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pfarm_altacliente
            // 
            this.Pfarm_altacliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pfarm_altacliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pfarm_altacliente.Controls.Add(this.inactivo_descuento);
            this.Pfarm_altacliente.Controls.Add(this.activo_descuento);
            this.Pfarm_altacliente.Controls.Add(this.label1);
            this.Pfarm_altacliente.Controls.Add(this.pictureBox3);
            this.Pfarm_altacliente.Controls.Add(this.pictureBox2);
            this.Pfarm_altacliente.Controls.Add(this.BFalta_vaciarcampos);
            this.Pfarm_altacliente.Controls.Add(this.BFalta_ingresarcli);
            this.Pfarm_altacliente.Controls.Add(this.porcentaje_descuento);
            this.Pfarm_altacliente.Controls.Add(this.descripcion_descuento);
            this.Pfarm_altacliente.Controls.Add(this.LFalta_apellido);
            this.Pfarm_altacliente.Controls.Add(this.LFalta_nombre);
            this.Pfarm_altacliente.Controls.Add(this.Lfarm_tituloalt);
            this.Pfarm_altacliente.Location = new System.Drawing.Point(12, 13);
            this.Pfarm_altacliente.Name = "Pfarm_altacliente";
            this.Pfarm_altacliente.Size = new System.Drawing.Size(492, 346);
            this.Pfarm_altacliente.TabIndex = 0;
            // 
            // inactivo_descuento
            // 
            this.inactivo_descuento.AutoSize = true;
            this.inactivo_descuento.Location = new System.Drawing.Point(277, 212);
            this.inactivo_descuento.Name = "inactivo_descuento";
            this.inactivo_descuento.Size = new System.Drawing.Size(73, 17);
            this.inactivo_descuento.TabIndex = 16;
            this.inactivo_descuento.Text = "No Activo";
            this.inactivo_descuento.UseVisualStyleBackColor = true;
            this.inactivo_descuento.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // activo_descuento
            // 
            this.activo_descuento.AutoSize = true;
            this.activo_descuento.Checked = true;
            this.activo_descuento.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activo_descuento.Location = new System.Drawing.Point(156, 212);
            this.activo_descuento.Name = "activo_descuento";
            this.activo_descuento.Size = new System.Drawing.Size(56, 17);
            this.activo_descuento.TabIndex = 15;
            this.activo_descuento.Text = "Activo";
            this.activo_descuento.UseVisualStyleBackColor = true;
            this.activo_descuento.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Estado:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(269, 273);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(81, 273);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // BFalta_vaciarcampos
            // 
            this.BFalta_vaciarcampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFalta_vaciarcampos.Location = new System.Drawing.Point(260, 264);
            this.BFalta_vaciarcampos.Name = "BFalta_vaciarcampos";
            this.BFalta_vaciarcampos.Size = new System.Drawing.Size(158, 62);
            this.BFalta_vaciarcampos.TabIndex = 3;
            this.BFalta_vaciarcampos.Text = "VACIAR CAMPOS";
            this.BFalta_vaciarcampos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BFalta_vaciarcampos.UseVisualStyleBackColor = true;
            this.BFalta_vaciarcampos.Click += new System.EventHandler(this.BFalta_vaciarcampos_Click);
            // 
            // BFalta_ingresarcli
            // 
            this.BFalta_ingresarcli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFalta_ingresarcli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BFalta_ingresarcli.Location = new System.Drawing.Point(69, 264);
            this.BFalta_ingresarcli.Name = "BFalta_ingresarcli";
            this.BFalta_ingresarcli.Size = new System.Drawing.Size(134, 62);
            this.BFalta_ingresarcli.TabIndex = 2;
            this.BFalta_ingresarcli.Text = "ACEPTAR";
            this.BFalta_ingresarcli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BFalta_ingresarcli.UseVisualStyleBackColor = true;
            this.BFalta_ingresarcli.Click += new System.EventHandler(this.BFalta_ingresarcli_Click);
            // 
            // porcentaje_descuento
            // 
            this.porcentaje_descuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.porcentaje_descuento.Location = new System.Drawing.Point(156, 165);
            this.porcentaje_descuento.Name = "porcentaje_descuento";
            this.porcentaje_descuento.Size = new System.Drawing.Size(308, 20);
            this.porcentaje_descuento.TabIndex = 9;
            // 
            // descripcion_descuento
            // 
            this.descripcion_descuento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.descripcion_descuento.Location = new System.Drawing.Point(156, 101);
            this.descripcion_descuento.Name = "descripcion_descuento";
            this.descripcion_descuento.Size = new System.Drawing.Size(308, 20);
            this.descripcion_descuento.TabIndex = 8;
            // 
            // LFalta_apellido
            // 
            this.LFalta_apellido.AutoSize = true;
            this.LFalta_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFalta_apellido.Location = new System.Drawing.Point(23, 153);
            this.LFalta_apellido.Name = "LFalta_apellido";
            this.LFalta_apellido.Size = new System.Drawing.Size(116, 40);
            this.LFalta_apellido.TabIndex = 3;
            this.LFalta_apellido.Text = "Porcentaje \r\nDe Descuento:";
            // 
            // LFalta_nombre
            // 
            this.LFalta_nombre.AutoSize = true;
            this.LFalta_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFalta_nombre.Location = new System.Drawing.Point(22, 101);
            this.LFalta_nombre.Name = "LFalta_nombre";
            this.LFalta_nombre.Size = new System.Drawing.Size(96, 20);
            this.LFalta_nombre.TabIndex = 2;
            this.LFalta_nombre.Text = "Descripcion:";
            // 
            // Lfarm_tituloalt
            // 
            this.Lfarm_tituloalt.AutoSize = true;
            this.Lfarm_tituloalt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Lfarm_tituloalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lfarm_tituloalt.Location = new System.Drawing.Point(40, 16);
            this.Lfarm_tituloalt.Name = "Lfarm_tituloalt";
            this.Lfarm_tituloalt.Size = new System.Drawing.Size(403, 39);
            this.Lfarm_tituloalt.TabIndex = 1;
            this.Lfarm_tituloalt.Text = "ALTA DE DESCUENTO";
            this.Lfarm_tituloalt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AltaDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 370);
            this.Controls.Add(this.Pfarm_altacliente);
            this.Name = "AltaDescuentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Descuento";
            this.Pfarm_altacliente.ResumeLayout(false);
            this.Pfarm_altacliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pfarm_altacliente;
        private System.Windows.Forms.Label Lfarm_tituloalt;
        private System.Windows.Forms.Label LFalta_nombre;
        private System.Windows.Forms.Label LFalta_apellido;
        private System.Windows.Forms.TextBox porcentaje_descuento;
        private System.Windows.Forms.TextBox descripcion_descuento;
        private System.Windows.Forms.Button BFalta_ingresarcli;
        private System.Windows.Forms.Button BFalta_vaciarcampos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox inactivo_descuento;
        private System.Windows.Forms.CheckBox activo_descuento;
    }
}