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
            this.LAS_cate_titulo = new System.Windows.Forms.Label();
            this.CC_activo = new System.Windows.Forms.CheckBox();
            this.LAS_cate_estado = new System.Windows.Forms.Label();
            this.LAS_cate_descrip = new System.Windows.Forms.Label();
            this.Bagregar_categoria = new System.Windows.Forms.Button();
            this.Vaciar_campos_categoria = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TC_descripcion);
            this.panel1.Controls.Add(this.CC_inactivo);
            this.panel1.Controls.Add(this.LAS_cate_titulo);
            this.panel1.Controls.Add(this.CC_activo);
            this.panel1.Controls.Add(this.LAS_cate_estado);
            this.panel1.Controls.Add(this.LAS_cate_descrip);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(83, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 268);
            this.panel1.TabIndex = 0;
            // 
            // TC_descripcion
            // 
            this.TC_descripcion.Location = new System.Drawing.Point(38, 105);
            this.TC_descripcion.Name = "TC_descripcion";
            this.TC_descripcion.Size = new System.Drawing.Size(311, 20);
            this.TC_descripcion.TabIndex = 5;
            // 
            // CC_inactivo
            // 
            this.CC_inactivo.AutoSize = true;
            this.CC_inactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_inactivo.Location = new System.Drawing.Point(245, 212);
            this.CC_inactivo.Name = "CC_inactivo";
            this.CC_inactivo.Size = new System.Drawing.Size(84, 17);
            this.CC_inactivo.TabIndex = 4;
            this.CC_inactivo.Text = "INACTIVO";
            this.CC_inactivo.UseVisualStyleBackColor = true;
            // 
            // LAS_cate_titulo
            // 
            this.LAS_cate_titulo.AutoSize = true;
            this.LAS_cate_titulo.BackColor = System.Drawing.Color.Transparent;
            this.LAS_cate_titulo.CausesValidation = false;
            this.LAS_cate_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAS_cate_titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LAS_cate_titulo.Location = new System.Drawing.Point(49, 12);
            this.LAS_cate_titulo.Name = "LAS_cate_titulo";
            this.LAS_cate_titulo.Size = new System.Drawing.Size(290, 29);
            this.LAS_cate_titulo.TabIndex = 0;
            this.LAS_cate_titulo.Text = "ALTA DE CATEGORIAS";
            // 
            // CC_activo
            // 
            this.CC_activo.AutoSize = true;
            this.CC_activo.Checked = true;
            this.CC_activo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CC_activo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_activo.Location = new System.Drawing.Point(38, 212);
            this.CC_activo.Name = "CC_activo";
            this.CC_activo.Size = new System.Drawing.Size(71, 17);
            this.CC_activo.TabIndex = 3;
            this.CC_activo.Text = "ACTIVO";
            this.CC_activo.UseVisualStyleBackColor = true;
            // 
            // LAS_cate_estado
            // 
            this.LAS_cate_estado.AutoSize = true;
            this.LAS_cate_estado.BackColor = System.Drawing.Color.Transparent;
            this.LAS_cate_estado.CausesValidation = false;
            this.LAS_cate_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAS_cate_estado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LAS_cate_estado.Location = new System.Drawing.Point(126, 154);
            this.LAS_cate_estado.Name = "LAS_cate_estado";
            this.LAS_cate_estado.Size = new System.Drawing.Size(101, 29);
            this.LAS_cate_estado.TabIndex = 2;
            this.LAS_cate_estado.Text = "Estado:";
            // 
            // LAS_cate_descrip
            // 
            this.LAS_cate_descrip.AutoSize = true;
            this.LAS_cate_descrip.BackColor = System.Drawing.Color.Transparent;
            this.LAS_cate_descrip.CausesValidation = false;
            this.LAS_cate_descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAS_cate_descrip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LAS_cate_descrip.Location = new System.Drawing.Point(105, 60);
            this.LAS_cate_descrip.Name = "LAS_cate_descrip";
            this.LAS_cate_descrip.Size = new System.Drawing.Size(159, 29);
            this.LAS_cate_descrip.TabIndex = 1;
            this.LAS_cate_descrip.Text = "Descripcion:";
            // 
            // Bagregar_categoria
            // 
            this.Bagregar_categoria.BackColor = System.Drawing.Color.Silver;
            this.Bagregar_categoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bagregar_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bagregar_categoria.Image = ((System.Drawing.Image)(resources.GetObject("Bagregar_categoria.Image")));
            this.Bagregar_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bagregar_categoria.Location = new System.Drawing.Point(12, 283);
            this.Bagregar_categoria.Name = "Bagregar_categoria";
            this.Bagregar_categoria.Size = new System.Drawing.Size(213, 63);
            this.Bagregar_categoria.TabIndex = 6;
            this.Bagregar_categoria.Text = "AGREGAR CATEGORIA";
            this.Bagregar_categoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bagregar_categoria.UseVisualStyleBackColor = false;
            this.Bagregar_categoria.Click += new System.EventHandler(this.Bagregar_categoria_Click);
            // 
            // Vaciar_campos_categoria
            // 
            this.Vaciar_campos_categoria.BackColor = System.Drawing.Color.Silver;
            this.Vaciar_campos_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vaciar_campos_categoria.Image = ((System.Drawing.Image)(resources.GetObject("Vaciar_campos_categoria.Image")));
            this.Vaciar_campos_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Vaciar_campos_categoria.Location = new System.Drawing.Point(328, 283);
            this.Vaciar_campos_categoria.Name = "Vaciar_campos_categoria";
            this.Vaciar_campos_categoria.Size = new System.Drawing.Size(174, 65);
            this.Vaciar_campos_categoria.TabIndex = 26;
            this.Vaciar_campos_categoria.Text = "Vaciar campos";
            this.Vaciar_campos_categoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Vaciar_campos_categoria.UseVisualStyleBackColor = false;
            this.Vaciar_campos_categoria.Click += new System.EventHandler(this.Vaciar_campos_categoria_Click);
            // 
            // CategoriaAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(510, 355);
            this.Controls.Add(this.Vaciar_campos_categoria);
            this.Controls.Add(this.Bagregar_categoria);
            this.Controls.Add(this.panel1);
            this.Name = "CategoriaAdmi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriaAdmi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button Vaciar_campos_categoria;
    }
}