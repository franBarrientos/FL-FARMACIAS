namespace FL_FARMACIAS.Presentacion.Admin
{
    partial class CategoriaAdmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaAdmi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TC_descripcion = new System.Windows.Forms.TextBox();
            this.CC_inactivo = new System.Windows.Forms.CheckBox();
            this.CC_activo = new System.Windows.Forms.CheckBox();
            this.LAS_cate_estado = new System.Windows.Forms.Label();
            this.LAS_cate_descrip = new System.Windows.Forms.Label();
            this.LAS_cate_titulo = new System.Windows.Forms.Label();
            this.Bagregar_categoria = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TC_descripcion);
            this.panel1.Controls.Add(this.CC_inactivo);
            this.panel1.Controls.Add(this.CC_activo);
            this.panel1.Controls.Add(this.LAS_cate_estado);
            this.panel1.Controls.Add(this.LAS_cate_descrip);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(52, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 240);
            this.panel1.TabIndex = 0;
            // 
            // TC_descripcion
            // 
            this.TC_descripcion.Location = new System.Drawing.Point(20, 91);
            this.TC_descripcion.Name = "TC_descripcion";
            this.TC_descripcion.Size = new System.Drawing.Size(238, 20);
            this.TC_descripcion.TabIndex = 5;
            // 
            // CC_inactivo
            // 
            this.CC_inactivo.AutoSize = true;
            this.CC_inactivo.Checked = true;
            this.CC_inactivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CC_inactivo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_inactivo.Location = new System.Drawing.Point(159, 180);
            this.CC_inactivo.Name = "CC_inactivo";
            this.CC_inactivo.Size = new System.Drawing.Size(84, 17);
            this.CC_inactivo.TabIndex = 4;
            this.CC_inactivo.Text = "INACTIVO";
            this.CC_inactivo.UseVisualStyleBackColor = true;
            // 
            // CC_activo
            // 
            this.CC_activo.AutoSize = true;
            this.CC_activo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_activo.Location = new System.Drawing.Point(20, 180);
            this.CC_activo.Name = "CC_activo";
            this.CC_activo.Size = new System.Drawing.Size(71, 17);
            this.CC_activo.TabIndex = 3;
            this.CC_activo.Text = "ACTIVO";
            this.CC_activo.UseVisualStyleBackColor = true;
            // 
            // LAS_cate_estado
            // 
            this.LAS_cate_estado.AutoSize = true;
            this.LAS_cate_estado.BackColor = System.Drawing.Color.Silver;
            this.LAS_cate_estado.CausesValidation = false;
            this.LAS_cate_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAS_cate_estado.ForeColor = System.Drawing.Color.White;
            this.LAS_cate_estado.Location = new System.Drawing.Point(81, 128);
            this.LAS_cate_estado.Name = "LAS_cate_estado";
            this.LAS_cate_estado.Size = new System.Drawing.Size(101, 29);
            this.LAS_cate_estado.TabIndex = 2;
            this.LAS_cate_estado.Text = "Estado:";
            // 
            // LAS_cate_descrip
            // 
            this.LAS_cate_descrip.AutoSize = true;
            this.LAS_cate_descrip.BackColor = System.Drawing.Color.Silver;
            this.LAS_cate_descrip.CausesValidation = false;
            this.LAS_cate_descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAS_cate_descrip.ForeColor = System.Drawing.Color.White;
            this.LAS_cate_descrip.Location = new System.Drawing.Point(56, 41);
            this.LAS_cate_descrip.Name = "LAS_cate_descrip";
            this.LAS_cate_descrip.Size = new System.Drawing.Size(159, 29);
            this.LAS_cate_descrip.TabIndex = 1;
            this.LAS_cate_descrip.Text = "Descripcion:";
            // 
            // LAS_cate_titulo
            // 
            this.LAS_cate_titulo.AutoSize = true;
            this.LAS_cate_titulo.BackColor = System.Drawing.Color.Silver;
            this.LAS_cate_titulo.CausesValidation = false;
            this.LAS_cate_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAS_cate_titulo.ForeColor = System.Drawing.Color.White;
            this.LAS_cate_titulo.Location = new System.Drawing.Point(35, 9);
            this.LAS_cate_titulo.Name = "LAS_cate_titulo";
            this.LAS_cate_titulo.Size = new System.Drawing.Size(351, 33);
            this.LAS_cate_titulo.TabIndex = 0;
            this.LAS_cate_titulo.Text = "ALTA DE CATEGORIAS";
            // 
            // Bagregar_categoria
            // 
            this.Bagregar_categoria.Location = new System.Drawing.Point(107, 286);
            this.Bagregar_categoria.Name = "Bagregar_categoria";
            this.Bagregar_categoria.Size = new System.Drawing.Size(181, 50);
            this.Bagregar_categoria.TabIndex = 6;
            this.Bagregar_categoria.Text = "AGREGAR CATEGORIA";
            this.Bagregar_categoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bagregar_categoria.UseVisualStyleBackColor = true;
            this.Bagregar_categoria.Click += new System.EventHandler(this.Bagregar_categoria_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(107, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // CategoriaAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(385, 365);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bagregar_categoria);
            this.Controls.Add(this.LAS_cate_titulo);
            this.Controls.Add(this.panel1);
            this.Name = "CategoriaAdmi";
            this.Text = "CategoriaAdmi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LAS_cate_titulo;
        private System.Windows.Forms.Label LAS_cate_descrip;
        private System.Windows.Forms.CheckBox CC_inactivo;
        private System.Windows.Forms.CheckBox CC_activo;
        private System.Windows.Forms.Label LAS_cate_estado;
        private System.Windows.Forms.Button Bagregar_categoria;
        private System.Windows.Forms.TextBox TC_descripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}