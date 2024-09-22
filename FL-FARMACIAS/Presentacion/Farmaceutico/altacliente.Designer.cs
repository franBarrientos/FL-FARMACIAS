namespace FL_FARMACIAS.Presentacion.Farmaceutico
{
    partial class AltaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCliente));
            this.Pfarm_altacliente = new System.Windows.Forms.Panel();
            this.DFalta_obrasocial = new System.Windows.Forms.ComboBox();
            this.Ttelefono_cliente = new System.Windows.Forms.TextBox();
            this.Tdni_cliente = new System.Windows.Forms.TextBox();
            this.Tapellido_cliente = new System.Windows.Forms.TextBox();
            this.Tnombre_cliente = new System.Windows.Forms.TextBox();
            this.LFalta_telefono = new System.Windows.Forms.Label();
            this.LFalta_obrasocial = new System.Windows.Forms.Label();
            this.LFalta_dni = new System.Windows.Forms.Label();
            this.LFalta_apellido = new System.Windows.Forms.Label();
            this.LFalta_nombre = new System.Windows.Forms.Label();
            this.Lfarm_tituloalt = new System.Windows.Forms.Label();
            this.BFalta_ingresarcli = new System.Windows.Forms.Button();
            this.BFalta_vaciarcampos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Pfarm_altacliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pfarm_altacliente
            // 
            this.Pfarm_altacliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pfarm_altacliente.Controls.Add(this.DFalta_obrasocial);
            this.Pfarm_altacliente.Controls.Add(this.pictureBox2);
            this.Pfarm_altacliente.Controls.Add(this.Ttelefono_cliente);
            this.Pfarm_altacliente.Controls.Add(this.Tdni_cliente);
            this.Pfarm_altacliente.Controls.Add(this.Tapellido_cliente);
            this.Pfarm_altacliente.Controls.Add(this.Tnombre_cliente);
            this.Pfarm_altacliente.Controls.Add(this.LFalta_telefono);
            this.Pfarm_altacliente.Controls.Add(this.LFalta_obrasocial);
            this.Pfarm_altacliente.Controls.Add(this.LFalta_dni);
            this.Pfarm_altacliente.Controls.Add(this.LFalta_apellido);
            this.Pfarm_altacliente.Controls.Add(this.LFalta_nombre);
            this.Pfarm_altacliente.Controls.Add(this.Lfarm_tituloalt);
            this.Pfarm_altacliente.Location = new System.Drawing.Point(41, 29);
            this.Pfarm_altacliente.Name = "Pfarm_altacliente";
            this.Pfarm_altacliente.Size = new System.Drawing.Size(513, 384);
            this.Pfarm_altacliente.TabIndex = 0;
            // 
            // DFalta_obrasocial
            // 
            this.DFalta_obrasocial.FormattingEnabled = true;
            this.DFalta_obrasocial.Items.AddRange(new object[] {
            "Pami",
            "SPS",
            "Galeno"});
            this.DFalta_obrasocial.Location = new System.Drawing.Point(156, 257);
            this.DFalta_obrasocial.Name = "DFalta_obrasocial";
            this.DFalta_obrasocial.Size = new System.Drawing.Size(308, 21);
            this.DFalta_obrasocial.TabIndex = 13;
            // 
            // Ttelefono_cliente
            // 
            this.Ttelefono_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ttelefono_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ttelefono_cliente.Location = new System.Drawing.Point(156, 308);
            this.Ttelefono_cliente.Name = "Ttelefono_cliente";
            this.Ttelefono_cliente.Size = new System.Drawing.Size(308, 19);
            this.Ttelefono_cliente.TabIndex = 12;
            // 
            // Tdni_cliente
            // 
            this.Tdni_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tdni_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tdni_cliente.Location = new System.Drawing.Point(156, 204);
            this.Tdni_cliente.Name = "Tdni_cliente";
            this.Tdni_cliente.Size = new System.Drawing.Size(308, 19);
            this.Tdni_cliente.TabIndex = 10;
            // 
            // Tapellido_cliente
            // 
            this.Tapellido_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tapellido_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tapellido_cliente.Location = new System.Drawing.Point(156, 155);
            this.Tapellido_cliente.Name = "Tapellido_cliente";
            this.Tapellido_cliente.Size = new System.Drawing.Size(308, 19);
            this.Tapellido_cliente.TabIndex = 9;
            // 
            // Tnombre_cliente
            // 
            this.Tnombre_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tnombre_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnombre_cliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Tnombre_cliente.Location = new System.Drawing.Point(156, 101);
            this.Tnombre_cliente.Name = "Tnombre_cliente";
            this.Tnombre_cliente.Size = new System.Drawing.Size(308, 19);
            this.Tnombre_cliente.TabIndex = 8;
            // 
            // LFalta_telefono
            // 
            this.LFalta_telefono.AutoSize = true;
            this.LFalta_telefono.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LFalta_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFalta_telefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LFalta_telefono.Location = new System.Drawing.Point(28, 308);
            this.LFalta_telefono.Name = "LFalta_telefono";
            this.LFalta_telefono.Size = new System.Drawing.Size(75, 20);
            this.LFalta_telefono.TabIndex = 7;
            this.LFalta_telefono.Text = "Telefono:";
            // 
            // LFalta_obrasocial
            // 
            this.LFalta_obrasocial.AutoSize = true;
            this.LFalta_obrasocial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LFalta_obrasocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFalta_obrasocial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LFalta_obrasocial.Location = new System.Drawing.Point(28, 255);
            this.LFalta_obrasocial.Name = "LFalta_obrasocial";
            this.LFalta_obrasocial.Size = new System.Drawing.Size(95, 20);
            this.LFalta_obrasocial.TabIndex = 6;
            this.LFalta_obrasocial.Text = "Obra Social:";
            // 
            // LFalta_dni
            // 
            this.LFalta_dni.AutoSize = true;
            this.LFalta_dni.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LFalta_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFalta_dni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LFalta_dni.Location = new System.Drawing.Point(28, 204);
            this.LFalta_dni.Name = "LFalta_dni";
            this.LFalta_dni.Size = new System.Drawing.Size(49, 20);
            this.LFalta_dni.TabIndex = 4;
            this.LFalta_dni.Text = "D.N.I:";
            // 
            // LFalta_apellido
            // 
            this.LFalta_apellido.AutoSize = true;
            this.LFalta_apellido.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LFalta_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFalta_apellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LFalta_apellido.Location = new System.Drawing.Point(28, 148);
            this.LFalta_apellido.Name = "LFalta_apellido";
            this.LFalta_apellido.Size = new System.Drawing.Size(69, 20);
            this.LFalta_apellido.TabIndex = 3;
            this.LFalta_apellido.Text = "Apellido:";
            // 
            // LFalta_nombre
            // 
            this.LFalta_nombre.AutoSize = true;
            this.LFalta_nombre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LFalta_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFalta_nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LFalta_nombre.Location = new System.Drawing.Point(28, 100);
            this.LFalta_nombre.Name = "LFalta_nombre";
            this.LFalta_nombre.Size = new System.Drawing.Size(69, 20);
            this.LFalta_nombre.TabIndex = 2;
            this.LFalta_nombre.Text = "Nombre:";
            // 
            // Lfarm_tituloalt
            // 
            this.Lfarm_tituloalt.AutoSize = true;
            this.Lfarm_tituloalt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lfarm_tituloalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lfarm_tituloalt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lfarm_tituloalt.Location = new System.Drawing.Point(47, 12);
            this.Lfarm_tituloalt.Name = "Lfarm_tituloalt";
            this.Lfarm_tituloalt.Size = new System.Drawing.Size(329, 39);
            this.Lfarm_tituloalt.TabIndex = 1;
            this.Lfarm_tituloalt.Text = "ALTA DE CLIENTE";
            this.Lfarm_tituloalt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BFalta_ingresarcli
            // 
            this.BFalta_ingresarcli.BackColor = System.Drawing.Color.Ivory;
            this.BFalta_ingresarcli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFalta_ingresarcli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BFalta_ingresarcli.Image = ((System.Drawing.Image)(resources.GetObject("BFalta_ingresarcli.Image")));
            this.BFalta_ingresarcli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BFalta_ingresarcli.Location = new System.Drawing.Point(41, 428);
            this.BFalta_ingresarcli.Name = "BFalta_ingresarcli";
            this.BFalta_ingresarcli.Size = new System.Drawing.Size(173, 62);
            this.BFalta_ingresarcli.TabIndex = 2;
            this.BFalta_ingresarcli.Text = "AGREGAR CLIENTE";
            this.BFalta_ingresarcli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BFalta_ingresarcli.UseVisualStyleBackColor = false;
            this.BFalta_ingresarcli.Click += new System.EventHandler(this.BFalta_ingresarcli_Click);
            // 
            // BFalta_vaciarcampos
            // 
            this.BFalta_vaciarcampos.BackColor = System.Drawing.Color.Ivory;
            this.BFalta_vaciarcampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFalta_vaciarcampos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BFalta_vaciarcampos.Image = ((System.Drawing.Image)(resources.GetObject("BFalta_vaciarcampos.Image")));
            this.BFalta_vaciarcampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BFalta_vaciarcampos.Location = new System.Drawing.Point(381, 428);
            this.BFalta_vaciarcampos.Name = "BFalta_vaciarcampos";
            this.BFalta_vaciarcampos.Size = new System.Drawing.Size(173, 62);
            this.BFalta_vaciarcampos.TabIndex = 3;
            this.BFalta_vaciarcampos.Text = "VACIAR CAMPOS";
            this.BFalta_vaciarcampos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BFalta_vaciarcampos.UseVisualStyleBackColor = false;
            this.BFalta_vaciarcampos.Click += new System.EventHandler(this.BFalta_vaciarcampos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(402, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 66);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(617, 514);
            this.Controls.Add(this.BFalta_vaciarcampos);
            this.Controls.Add(this.BFalta_ingresarcli);
            this.Controls.Add(this.Pfarm_altacliente);
            this.Name = "AltaCliente";
            this.Text = "altacliente";
            this.Pfarm_altacliente.ResumeLayout(false);
            this.Pfarm_altacliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pfarm_altacliente;
        private System.Windows.Forms.Label Lfarm_tituloalt;
        private System.Windows.Forms.Label LFalta_nombre;
        private System.Windows.Forms.Label LFalta_telefono;
        private System.Windows.Forms.Label LFalta_obrasocial;
        private System.Windows.Forms.Label LFalta_dni;
        private System.Windows.Forms.Label LFalta_apellido;
        private System.Windows.Forms.TextBox Ttelefono_cliente;
        private System.Windows.Forms.TextBox Tdni_cliente;
        private System.Windows.Forms.TextBox Tapellido_cliente;
        private System.Windows.Forms.TextBox Tnombre_cliente;
        private System.Windows.Forms.Button BFalta_ingresarcli;
        private System.Windows.Forms.Button BFalta_vaciarcampos;
        private System.Windows.Forms.ComboBox DFalta_obrasocial;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}