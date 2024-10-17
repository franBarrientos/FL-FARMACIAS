using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FL_FARMACIAS.Presentacion.Admin
{
    partial class EmpleadoSubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoSubMenu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3w = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BFalta_ingresarcli = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new PlaceholderTextBox();
            this.IDEMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMG = new System.Windows.Forms.DataGridViewImageColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXOEMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIL_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARGOEMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARIO_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MODIFICAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEMPLEADO,
            this.IMG,
            this.NOMBRE,
            this.APELLIDO,
            this.SEXOEMPLEADO,
            this.DNI,
            this.CUIL_EMPLEADO,
            this.TELEFONO,
            this.CARGOEMPLEADO,
            this.SALARIO_EMPLEADO,
            this.FECHAINGRESO,
            this.ESTADO,
            this.USUARIO,
            this.MODIFICAR,
            this.ELIMINAR});
            this.dataGridView1.Location = new System.Drawing.Point(14, 218);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(1219, 364);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(970, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "BUSCAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1101, 139);
            this.button2.Margin = new System.Windows.Forms.Padding(64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "LIMPIAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(372, 151);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(311, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cargo";
            // 
            // label3w
            // 
            this.label3w.AutoSize = true;
            this.label3w.BackColor = System.Drawing.Color.Transparent;
            this.label3w.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3w.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3w.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3w.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3w.Location = new System.Drawing.Point(463, 78);
            this.label3w.Margin = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.label3w.Name = "label3w";
            this.label3w.Size = new System.Drawing.Size(290, 26);
            this.label3w.TabIndex = 9;
            this.label3w.Text = "BUSQUEDA DE EMPLEADOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "EMPLEADOS";
            // 
            // BFalta_ingresarcli
            // 
            this.BFalta_ingresarcli.BackColor = System.Drawing.Color.White;
            this.BFalta_ingresarcli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFalta_ingresarcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFalta_ingresarcli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BFalta_ingresarcli.Image = ((System.Drawing.Image)(resources.GetObject("BFalta_ingresarcli.Image")));
            this.BFalta_ingresarcli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BFalta_ingresarcli.Location = new System.Drawing.Point(38, 61);
            this.BFalta_ingresarcli.Name = "BFalta_ingresarcli";
            this.BFalta_ingresarcli.Size = new System.Drawing.Size(239, 62);
            this.BFalta_ingresarcli.TabIndex = 12;
            this.BFalta_ingresarcli.Text = "DAR DE ALTA NUEVO EMPLEADO";
            this.BFalta_ingresarcli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BFalta_ingresarcli.UseVisualStyleBackColor = false;
            this.BFalta_ingresarcli.Click += new System.EventHandler(this.BFalta_ingresarcli_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(631, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(714, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(567, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(755, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hasta:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(813, 153);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.IsPassword = false;
            this.textBox1.Location = new System.Drawing.Point(14, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Placeholder = "INGRESE DNI O APELLIDO";
            this.textBox1.Size = new System.Drawing.Size(281, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "INGRESE DNI O APELLIDO";
            // 
            // IDEMPLEADO
            // 
            this.IDEMPLEADO.HeaderText = "ID";
            this.IDEMPLEADO.Name = "IDEMPLEADO";
            this.IDEMPLEADO.Visible = false;
            // 
            // IMG
            // 
            this.IMG.HeaderText = "IMG";
            this.IMG.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.IMG.Name = "IMG";
            this.IMG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IMG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 8;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 150;
            // 
            // APELLIDO
            // 
            this.APELLIDO.HeaderText = "APELLIDO";
            this.APELLIDO.MinimumWidth = 8;
            this.APELLIDO.Name = "APELLIDO";
            this.APELLIDO.ReadOnly = true;
            this.APELLIDO.Width = 150;
            // 
            // SEXOEMPLEADO
            // 
            this.SEXOEMPLEADO.HeaderText = "SEXO";
            this.SEXOEMPLEADO.Name = "SEXOEMPLEADO";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 8;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 150;
            // 
            // CUIL_EMPLEADO
            // 
            this.CUIL_EMPLEADO.HeaderText = "CUIL";
            this.CUIL_EMPLEADO.Name = "CUIL_EMPLEADO";
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.MinimumWidth = 8;
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            this.TELEFONO.Width = 150;
            // 
            // CARGOEMPLEADO
            // 
            this.CARGOEMPLEADO.HeaderText = "CARGO";
            this.CARGOEMPLEADO.Name = "CARGOEMPLEADO";
            // 
            // SALARIO_EMPLEADO
            // 
            this.SALARIO_EMPLEADO.HeaderText = "SALARIO";
            this.SALARIO_EMPLEADO.Name = "SALARIO_EMPLEADO";
            // 
            // FECHAINGRESO
            // 
            this.FECHAINGRESO.HeaderText = "FECHA INGRESO";
            this.FECHAINGRESO.MinimumWidth = 8;
            this.FECHAINGRESO.Name = "FECHAINGRESO";
            this.FECHAINGRESO.ReadOnly = true;
            this.FECHAINGRESO.Width = 150;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Visible = false;
            // 
            // USUARIO
            // 
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.USUARIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // EmpleadoSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1255, 588);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BFalta_ingresarcli);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3w);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(64);
            this.MaximizeBox = false;
            this.Name = "EmpleadoSubMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3w;
        private PlaceholderTextBox textBox1;
        private Button BFalta_ingresarcli;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private DataGridViewTextBoxColumn IDEMPLEADO;
        private DataGridViewImageColumn IMG;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn SEXOEMPLEADO;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn CUIL_EMPLEADO;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn CARGOEMPLEADO;
        private DataGridViewTextBoxColumn SALARIO_EMPLEADO;
        private DataGridViewTextBoxColumn FECHAINGRESO;
        private DataGridViewTextBoxColumn ESTADO;
        private DataGridViewButtonColumn USUARIO;
        private DataGridViewButtonColumn MODIFICAR;
        private DataGridViewButtonColumn ELIMINAR;
    }
}