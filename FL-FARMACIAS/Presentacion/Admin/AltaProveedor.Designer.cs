﻿namespace FL_FARMACIAS.Presentacion.Farmaceutico
{
    partial class AltaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaProveedor));
            this.Pfarm_altacliente = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.BFalta_vaciarcampos = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BFalta_ingresarcli = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LFalta_telefono = new System.Windows.Forms.Label();
            this.LFalta_obrasocial = new System.Windows.Forms.Label();
            this.LFalta_direccion = new System.Windows.Forms.Label();
            this.LFalta_dni = new System.Windows.Forms.Label();
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
            this.Pfarm_altacliente.Controls.Add(this.textBox6);
            this.Pfarm_altacliente.Controls.Add(this.comboBox2);
            this.Pfarm_altacliente.Controls.Add(this.comboBox1);
            this.Pfarm_altacliente.Controls.Add(this.label2);
            this.Pfarm_altacliente.Controls.Add(this.label1);
            this.Pfarm_altacliente.Controls.Add(this.pictureBox3);
            this.Pfarm_altacliente.Controls.Add(this.pictureBox2);
            this.Pfarm_altacliente.Controls.Add(this.textBox5);
            this.Pfarm_altacliente.Controls.Add(this.BFalta_vaciarcampos);
            this.Pfarm_altacliente.Controls.Add(this.textBox4);
            this.Pfarm_altacliente.Controls.Add(this.BFalta_ingresarcli);
            this.Pfarm_altacliente.Controls.Add(this.textBox3);
            this.Pfarm_altacliente.Controls.Add(this.textBox2);
            this.Pfarm_altacliente.Controls.Add(this.textBox1);
            this.Pfarm_altacliente.Controls.Add(this.LFalta_telefono);
            this.Pfarm_altacliente.Controls.Add(this.LFalta_obrasocial);
            this.Pfarm_altacliente.Controls.Add(this.LFalta_direccion);
            this.Pfarm_altacliente.Controls.Add(this.LFalta_dni);
            this.Pfarm_altacliente.Controls.Add(this.LFalta_apellido);
            this.Pfarm_altacliente.Controls.Add(this.LFalta_nombre);
            this.Pfarm_altacliente.Controls.Add(this.Lfarm_tituloalt);
            this.Pfarm_altacliente.Location = new System.Drawing.Point(12, 13);
            this.Pfarm_altacliente.Name = "Pfarm_altacliente";
            this.Pfarm_altacliente.Size = new System.Drawing.Size(513, 581);
            this.Pfarm_altacliente.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(156, 389);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(308, 20);
            this.textBox6.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(156, 298);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(308, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.Click += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.onChangeSelectedProv);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Localidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Provincia:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(277, 499);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 499);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(156, 432);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(308, 20);
            this.textBox5.TabIndex = 12;
            // 
            // BFalta_vaciarcampos
            // 
            this.BFalta_vaciarcampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFalta_vaciarcampos.Location = new System.Drawing.Point(267, 490);
            this.BFalta_vaciarcampos.Name = "BFalta_vaciarcampos";
            this.BFalta_vaciarcampos.Size = new System.Drawing.Size(166, 62);
            this.BFalta_vaciarcampos.TabIndex = 3;
            this.BFalta_vaciarcampos.Text = "VACIAR CAMPOS";
            this.BFalta_vaciarcampos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BFalta_vaciarcampos.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 340);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(308, 20);
            this.textBox4.TabIndex = 11;
            // 
            // BFalta_ingresarcli
            // 
            this.BFalta_ingresarcli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFalta_ingresarcli.Location = new System.Drawing.Point(35, 490);
            this.BFalta_ingresarcli.Name = "BFalta_ingresarcli";
            this.BFalta_ingresarcli.Size = new System.Drawing.Size(200, 62);
            this.BFalta_ingresarcli.TabIndex = 2;
            this.BFalta_ingresarcli.Text = "AGREGAR PROVEEDOR";
            this.BFalta_ingresarcli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BFalta_ingresarcli.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(308, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(156, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(156, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 20);
            this.textBox1.TabIndex = 8;
            // 
            // LFalta_telefono
            // 
            this.LFalta_telefono.AutoSize = true;
            this.LFalta_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFalta_telefono.Location = new System.Drawing.Point(22, 428);
            this.LFalta_telefono.Name = "LFalta_telefono";
            this.LFalta_telefono.Size = new System.Drawing.Size(90, 24);
            this.LFalta_telefono.TabIndex = 7;
            this.LFalta_telefono.Text = "Telefono:";
            // 
            // LFalta_obrasocial
            // 
            this.LFalta_obrasocial.AutoSize = true;
            this.LFalta_obrasocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFalta_obrasocial.Location = new System.Drawing.Point(22, 385);
            this.LFalta_obrasocial.Name = "LFalta_obrasocial";
            this.LFalta_obrasocial.Size = new System.Drawing.Size(73, 24);
            this.LFalta_obrasocial.TabIndex = 6;
            this.LFalta_obrasocial.Text = "Correo:";
            // 
            // LFalta_direccion
            // 
            this.LFalta_direccion.AutoSize = true;
            this.LFalta_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFalta_direccion.Location = new System.Drawing.Point(20, 340);
            this.LFalta_direccion.Name = "LFalta_direccion";
            this.LFalta_direccion.Size = new System.Drawing.Size(95, 24);
            this.LFalta_direccion.TabIndex = 5;
            this.LFalta_direccion.Text = "Direccion:";
            // 
            // LFalta_dni
            // 
            this.LFalta_dni.AutoSize = true;
            this.LFalta_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFalta_dni.Location = new System.Drawing.Point(22, 204);
            this.LFalta_dni.Name = "LFalta_dni";
            this.LFalta_dni.Size = new System.Drawing.Size(46, 24);
            this.LFalta_dni.TabIndex = 4;
            this.LFalta_dni.Text = "DNI:";
            // 
            // LFalta_apellido
            // 
            this.LFalta_apellido.AutoSize = true;
            this.LFalta_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFalta_apellido.Location = new System.Drawing.Point(20, 155);
            this.LFalta_apellido.Name = "LFalta_apellido";
            this.LFalta_apellido.Size = new System.Drawing.Size(57, 24);
            this.LFalta_apellido.TabIndex = 3;
            this.LFalta_apellido.Text = "CUIT:";
            // 
            // LFalta_nombre
            // 
            this.LFalta_nombre.AutoSize = true;
            this.LFalta_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFalta_nombre.Location = new System.Drawing.Point(22, 101);
            this.LFalta_nombre.Name = "LFalta_nombre";
            this.LFalta_nombre.Size = new System.Drawing.Size(84, 24);
            this.LFalta_nombre.TabIndex = 2;
            this.LFalta_nombre.Text = "Nombre:";
            // 
            // Lfarm_tituloalt
            // 
            this.Lfarm_tituloalt.AutoSize = true;
            this.Lfarm_tituloalt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Lfarm_tituloalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lfarm_tituloalt.Location = new System.Drawing.Point(57, 23);
            this.Lfarm_tituloalt.Name = "Lfarm_tituloalt";
            this.Lfarm_tituloalt.Size = new System.Drawing.Size(407, 39);
            this.Lfarm_tituloalt.TabIndex = 1;
            this.Lfarm_tituloalt.Text = "ALTA DE PROVEEDOR";
            this.Lfarm_tituloalt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AltaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 606);
            this.Controls.Add(this.Pfarm_altacliente);
            this.Name = "AltaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Proveedor";
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
        private System.Windows.Forms.Label LFalta_telefono;
        private System.Windows.Forms.Label LFalta_obrasocial;
        private System.Windows.Forms.Label LFalta_direccion;
        private System.Windows.Forms.Label LFalta_dni;
        private System.Windows.Forms.Label LFalta_apellido;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BFalta_ingresarcli;
        private System.Windows.Forms.Button BFalta_vaciarcampos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}