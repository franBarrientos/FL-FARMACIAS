namespace FL_FARMACIAS.Presentacion.Admin
{
    partial class AltaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaEmpleado));
            this.Lnombre_farmaceutico = new System.Windows.Forms.Label();
            this.Lapellido_farmaceutico = new System.Windows.Forms.Label();
            this.Ldni_farmaceutico = new System.Windows.Forms.Label();
            this.Lsexo_farmaceutico = new System.Windows.Forms.Label();
            this.Ltelefono_farmaceutico = new System.Windows.Forms.Label();
            this.Lcuil_farmaceutico = new System.Windows.Forms.Label();
            this.Lsalario_farmaceutico = new System.Windows.Forms.Label();
            this.Lpuesto_farmaceutico = new System.Windows.Forms.Label();
            this.Tnombre_emple = new System.Windows.Forms.TextBox();
            this.Tcuil_emple = new System.Windows.Forms.TextBox();
            this.Tsalario_empleado = new System.Windows.Forms.TextBox();
            this.Tdni_emple = new System.Windows.Forms.TextBox();
            this.Ttelefono_empleado = new System.Windows.Forms.TextBox();
            this.Tapellido_emple = new System.Windows.Forms.TextBox();
            this.Cmasculino = new System.Windows.Forms.CheckBox();
            this.Cmujer = new System.Windows.Forms.CheckBox();
            this.Cpuesto_empleado = new System.Windows.Forms.ComboBox();
            this.agregarimagenempleado = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fotoempleado = new System.Windows.Forms.PictureBox();
            this.fecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.Lfechaingreso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ltitulo_nuevofarma = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Vaciar_campos_nuevo_farmaceutico = new System.Windows.Forms.Button();
            this.Bagregar_empleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotoempleado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lnombre_farmaceutico
            // 
            this.Lnombre_farmaceutico.AutoSize = true;
            this.Lnombre_farmaceutico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lnombre_farmaceutico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnombre_farmaceutico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lnombre_farmaceutico.Location = new System.Drawing.Point(12, 81);
            this.Lnombre_farmaceutico.Name = "Lnombre_farmaceutico";
            this.Lnombre_farmaceutico.Size = new System.Drawing.Size(69, 20);
            this.Lnombre_farmaceutico.TabIndex = 0;
            this.Lnombre_farmaceutico.Text = "Nombre:";
            // 
            // Lapellido_farmaceutico
            // 
            this.Lapellido_farmaceutico.AutoSize = true;
            this.Lapellido_farmaceutico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lapellido_farmaceutico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lapellido_farmaceutico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lapellido_farmaceutico.Location = new System.Drawing.Point(12, 44);
            this.Lapellido_farmaceutico.Name = "Lapellido_farmaceutico";
            this.Lapellido_farmaceutico.Size = new System.Drawing.Size(69, 20);
            this.Lapellido_farmaceutico.TabIndex = 1;
            this.Lapellido_farmaceutico.Text = "Apellido:";
            // 
            // Ldni_farmaceutico
            // 
            this.Ldni_farmaceutico.AutoSize = true;
            this.Ldni_farmaceutico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Ldni_farmaceutico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ldni_farmaceutico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Ldni_farmaceutico.Location = new System.Drawing.Point(12, 120);
            this.Ldni_farmaceutico.Name = "Ldni_farmaceutico";
            this.Ldni_farmaceutico.Size = new System.Drawing.Size(49, 20);
            this.Ldni_farmaceutico.TabIndex = 3;
            this.Ldni_farmaceutico.Text = "D.N.I:";
            // 
            // Lsexo_farmaceutico
            // 
            this.Lsexo_farmaceutico.AutoSize = true;
            this.Lsexo_farmaceutico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lsexo_farmaceutico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lsexo_farmaceutico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lsexo_farmaceutico.Location = new System.Drawing.Point(12, 287);
            this.Lsexo_farmaceutico.Name = "Lsexo_farmaceutico";
            this.Lsexo_farmaceutico.Size = new System.Drawing.Size(49, 20);
            this.Lsexo_farmaceutico.TabIndex = 2;
            this.Lsexo_farmaceutico.Text = "Sexo:";
            this.Lsexo_farmaceutico.Click += new System.EventHandler(this.Lsexo_farmaceutico_Click);
            // 
            // Ltelefono_farmaceutico
            // 
            this.Ltelefono_farmaceutico.AutoSize = true;
            this.Ltelefono_farmaceutico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Ltelefono_farmaceutico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltelefono_farmaceutico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Ltelefono_farmaceutico.Location = new System.Drawing.Point(15, 192);
            this.Ltelefono_farmaceutico.Name = "Ltelefono_farmaceutico";
            this.Ltelefono_farmaceutico.Size = new System.Drawing.Size(75, 20);
            this.Ltelefono_farmaceutico.TabIndex = 5;
            this.Ltelefono_farmaceutico.Text = "Telefono:";
            // 
            // Lcuil_farmaceutico
            // 
            this.Lcuil_farmaceutico.AutoSize = true;
            this.Lcuil_farmaceutico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lcuil_farmaceutico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcuil_farmaceutico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lcuil_farmaceutico.Location = new System.Drawing.Point(15, 153);
            this.Lcuil_farmaceutico.Name = "Lcuil_farmaceutico";
            this.Lcuil_farmaceutico.Size = new System.Drawing.Size(50, 20);
            this.Lcuil_farmaceutico.TabIndex = 4;
            this.Lcuil_farmaceutico.Text = "CUIL:";
            // 
            // Lsalario_farmaceutico
            // 
            this.Lsalario_farmaceutico.AutoSize = true;
            this.Lsalario_farmaceutico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lsalario_farmaceutico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lsalario_farmaceutico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lsalario_farmaceutico.Location = new System.Drawing.Point(15, 256);
            this.Lsalario_farmaceutico.Name = "Lsalario_farmaceutico";
            this.Lsalario_farmaceutico.Size = new System.Drawing.Size(62, 20);
            this.Lsalario_farmaceutico.TabIndex = 7;
            this.Lsalario_farmaceutico.Text = "Salario:";
            // 
            // Lpuesto_farmaceutico
            // 
            this.Lpuesto_farmaceutico.AutoSize = true;
            this.Lpuesto_farmaceutico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lpuesto_farmaceutico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpuesto_farmaceutico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lpuesto_farmaceutico.Location = new System.Drawing.Point(15, 224);
            this.Lpuesto_farmaceutico.Name = "Lpuesto_farmaceutico";
            this.Lpuesto_farmaceutico.Size = new System.Drawing.Size(56, 20);
            this.Lpuesto_farmaceutico.TabIndex = 6;
            this.Lpuesto_farmaceutico.Text = "Cargo:";
            // 
            // Tnombre_emple
            // 
            this.Tnombre_emple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tnombre_emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnombre_emple.Location = new System.Drawing.Point(149, 81);
            this.Tnombre_emple.Name = "Tnombre_emple";
            this.Tnombre_emple.Size = new System.Drawing.Size(281, 19);
            this.Tnombre_emple.TabIndex = 8;
            // 
            // Tcuil_emple
            // 
            this.Tcuil_emple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tcuil_emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tcuil_emple.Location = new System.Drawing.Point(149, 154);
            this.Tcuil_emple.Name = "Tcuil_emple";
            this.Tcuil_emple.Size = new System.Drawing.Size(281, 19);
            this.Tcuil_emple.TabIndex = 9;
            // 
            // Tsalario_empleado
            // 
            this.Tsalario_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tsalario_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tsalario_empleado.Location = new System.Drawing.Point(149, 256);
            this.Tsalario_empleado.Name = "Tsalario_empleado";
            this.Tsalario_empleado.Size = new System.Drawing.Size(281, 19);
            this.Tsalario_empleado.TabIndex = 11;
            // 
            // Tdni_emple
            // 
            this.Tdni_emple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tdni_emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tdni_emple.Location = new System.Drawing.Point(149, 121);
            this.Tdni_emple.Name = "Tdni_emple";
            this.Tdni_emple.Size = new System.Drawing.Size(281, 19);
            this.Tdni_emple.TabIndex = 10;
            // 
            // Ttelefono_empleado
            // 
            this.Ttelefono_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ttelefono_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ttelefono_empleado.Location = new System.Drawing.Point(149, 192);
            this.Ttelefono_empleado.Name = "Ttelefono_empleado";
            this.Ttelefono_empleado.Size = new System.Drawing.Size(281, 19);
            this.Ttelefono_empleado.TabIndex = 13;
            // 
            // Tapellido_emple
            // 
            this.Tapellido_emple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tapellido_emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tapellido_emple.Location = new System.Drawing.Point(149, 44);
            this.Tapellido_emple.Name = "Tapellido_emple";
            this.Tapellido_emple.Size = new System.Drawing.Size(281, 19);
            this.Tapellido_emple.TabIndex = 12;
            // 
            // Cmasculino
            // 
            this.Cmasculino.AutoSize = true;
            this.Cmasculino.Location = new System.Drawing.Point(149, 287);
            this.Cmasculino.Name = "Cmasculino";
            this.Cmasculino.Size = new System.Drawing.Size(89, 17);
            this.Cmasculino.TabIndex = 14;
            this.Cmasculino.Text = "MASCULINO";
            this.Cmasculino.UseVisualStyleBackColor = true;
            this.Cmasculino.CheckedChanged += new System.EventHandler(this.Cmasculino_CheckedChanged);
            // 
            // Cmujer
            // 
            this.Cmujer.AutoSize = true;
            this.Cmujer.Location = new System.Drawing.Point(348, 287);
            this.Cmujer.Name = "Cmujer";
            this.Cmujer.Size = new System.Drawing.Size(82, 17);
            this.Cmujer.TabIndex = 15;
            this.Cmujer.Text = "FEMENINO";
            this.Cmujer.UseVisualStyleBackColor = true;
            this.Cmujer.CheckedChanged += new System.EventHandler(this.Cmujer_CheckedChanged);
            // 
            // Cpuesto_empleado
            // 
            this.Cpuesto_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cpuesto_empleado.FormattingEnabled = true;
            this.Cpuesto_empleado.Location = new System.Drawing.Point(149, 223);
            this.Cpuesto_empleado.Name = "Cpuesto_empleado";
            this.Cpuesto_empleado.Size = new System.Drawing.Size(281, 21);
            this.Cpuesto_empleado.TabIndex = 16;
            // 
            // agregarimagenempleado
            // 
            this.agregarimagenempleado.BackColor = System.Drawing.SystemColors.Control;
            this.agregarimagenempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarimagenempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarimagenempleado.Image = ((System.Drawing.Image)(resources.GetObject("agregarimagenempleado.Image")));
            this.agregarimagenempleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarimagenempleado.Location = new System.Drawing.Point(519, 257);
            this.agregarimagenempleado.Name = "agregarimagenempleado";
            this.agregarimagenempleado.Size = new System.Drawing.Size(170, 71);
            this.agregarimagenempleado.TabIndex = 18;
            this.agregarimagenempleado.Text = "AGREGAR IMAGEN";
            this.agregarimagenempleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarimagenempleado.UseVisualStyleBackColor = false;
            this.agregarimagenempleado.Click += new System.EventHandler(this.agregarimagenempleado_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fotoempleado
            // 
            this.fotoempleado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fotoempleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotoempleado.Location = new System.Drawing.Point(471, 33);
            this.fotoempleado.Name = "fotoempleado";
            this.fotoempleado.Size = new System.Drawing.Size(281, 219);
            this.fotoempleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoempleado.TabIndex = 19;
            this.fotoempleado.TabStop = false;
            this.fotoempleado.Tag = "";
            // 
            // fecha_ingreso
            // 
            this.fecha_ingreso.Location = new System.Drawing.Point(149, 319);
            this.fecha_ingreso.Name = "fecha_ingreso";
            this.fecha_ingreso.Size = new System.Drawing.Size(281, 20);
            this.fecha_ingreso.TabIndex = 20;
            // 
            // Lfechaingreso
            // 
            this.Lfechaingreso.AutoSize = true;
            this.Lfechaingreso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lfechaingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lfechaingreso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lfechaingreso.Location = new System.Drawing.Point(12, 320);
            this.Lfechaingreso.Name = "Lfechaingreso";
            this.Lfechaingreso.Size = new System.Drawing.Size(116, 20);
            this.Lfechaingreso.TabIndex = 21;
            this.Lfechaingreso.Text = "Fecha Ingreso:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Ltitulo_nuevofarma);
            this.panel1.Controls.Add(this.Cpuesto_empleado);
            this.panel1.Controls.Add(this.Lfechaingreso);
            this.panel1.Controls.Add(this.Lpuesto_farmaceutico);
            this.panel1.Controls.Add(this.fecha_ingreso);
            this.panel1.Controls.Add(this.Cmasculino);
            this.panel1.Controls.Add(this.Cmujer);
            this.panel1.Controls.Add(this.Lsexo_farmaceutico);
            this.panel1.Controls.Add(this.Lsalario_farmaceutico);
            this.panel1.Controls.Add(this.Tsalario_empleado);
            this.panel1.Controls.Add(this.Ldni_farmaceutico);
            this.panel1.Controls.Add(this.Tdni_emple);
            this.panel1.Controls.Add(this.Ttelefono_empleado);
            this.panel1.Controls.Add(this.Ltelefono_farmaceutico);
            this.panel1.Controls.Add(this.Tcuil_emple);
            this.panel1.Controls.Add(this.Lcuil_farmaceutico);
            this.panel1.Controls.Add(this.Tapellido_emple);
            this.panel1.Controls.Add(this.Tnombre_emple);
            this.panel1.Controls.Add(this.Lnombre_farmaceutico);
            this.panel1.Controls.Add(this.Lapellido_farmaceutico);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 367);
            this.panel1.TabIndex = 22;
            // 
            // Ltitulo_nuevofarma
            // 
            this.Ltitulo_nuevofarma.AutoSize = true;
            this.Ltitulo_nuevofarma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Ltitulo_nuevofarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltitulo_nuevofarma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Ltitulo_nuevofarma.Location = new System.Drawing.Point(39, -2);
            this.Ltitulo_nuevofarma.Name = "Ltitulo_nuevofarma";
            this.Ltitulo_nuevofarma.Size = new System.Drawing.Size(355, 39);
            this.Ltitulo_nuevofarma.TabIndex = 22;
            this.Ltitulo_nuevofarma.Text = "NUEVO EMPLEADO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(519, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 66);
            this.button1.TabIndex = 24;
            this.button1.Text = "ELIMINAR IMAGEN";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(259, 412);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(71, 412);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Vaciar_campos_nuevo_farmaceutico
            // 
            this.Vaciar_campos_nuevo_farmaceutico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vaciar_campos_nuevo_farmaceutico.Location = new System.Drawing.Point(250, 403);
            this.Vaciar_campos_nuevo_farmaceutico.Name = "Vaciar_campos_nuevo_farmaceutico";
            this.Vaciar_campos_nuevo_farmaceutico.Size = new System.Drawing.Size(158, 62);
            this.Vaciar_campos_nuevo_farmaceutico.TabIndex = 27;
            this.Vaciar_campos_nuevo_farmaceutico.Text = "VACIAR CAMPOS";
            this.Vaciar_campos_nuevo_farmaceutico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Vaciar_campos_nuevo_farmaceutico.UseVisualStyleBackColor = true;
            this.Vaciar_campos_nuevo_farmaceutico.Click += new System.EventHandler(this.Vaciar_campos_nuevo_farmaceutico_Click_1);
            // 
            // Bagregar_empleado
            // 
            this.Bagregar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bagregar_empleado.Location = new System.Drawing.Point(59, 403);
            this.Bagregar_empleado.Name = "Bagregar_empleado";
            this.Bagregar_empleado.Size = new System.Drawing.Size(134, 62);
            this.Bagregar_empleado.TabIndex = 26;
            this.Bagregar_empleado.Text = "ACEPTAR";
            this.Bagregar_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bagregar_empleado.UseVisualStyleBackColor = true;
            this.Bagregar_empleado.Click += new System.EventHandler(this.Bagregar_empleado_Click_1);
            // 
            // AltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(767, 479);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Vaciar_campos_nuevo_farmaceutico);
            this.Controls.Add(this.Bagregar_empleado);
            this.Controls.Add(this.fotoempleado);
            this.Controls.Add(this.agregarimagenempleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AltaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.fotoempleado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lnombre_farmaceutico;
        private System.Windows.Forms.Label Lapellido_farmaceutico;
        private System.Windows.Forms.Label Ldni_farmaceutico;
        private System.Windows.Forms.Label Lsexo_farmaceutico;
        private System.Windows.Forms.Label Ltelefono_farmaceutico;
        private System.Windows.Forms.Label Lcuil_farmaceutico;
        private System.Windows.Forms.Label Lsalario_farmaceutico;
        private System.Windows.Forms.Label Lpuesto_farmaceutico;
        private System.Windows.Forms.TextBox Tnombre_emple;
        private System.Windows.Forms.TextBox Tcuil_emple;
        private System.Windows.Forms.TextBox Tsalario_empleado;
        private System.Windows.Forms.TextBox Tdni_emple;
        private System.Windows.Forms.TextBox Ttelefono_empleado;
        private System.Windows.Forms.TextBox Tapellido_emple;
        private System.Windows.Forms.CheckBox Cmasculino;
        private System.Windows.Forms.CheckBox Cmujer;
        private System.Windows.Forms.ComboBox Cpuesto_empleado;
        private System.Windows.Forms.Button agregarimagenempleado;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox fotoempleado;
        private System.Windows.Forms.DateTimePicker fecha_ingreso;
        private System.Windows.Forms.Label Lfechaingreso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Ltitulo_nuevofarma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Vaciar_campos_nuevo_farmaceutico;
        private System.Windows.Forms.Button Bagregar_empleado;
    }
}