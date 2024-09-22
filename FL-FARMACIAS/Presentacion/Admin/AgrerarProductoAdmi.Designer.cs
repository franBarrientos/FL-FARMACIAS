namespace FL_FARMACIAS.Presentacion.Admin
{
    partial class AgrerarProductoAdmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgrerarProductoAdmi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TP_descripcion = new System.Windows.Forms.TextBox();
            this.LP_categoria = new System.Windows.Forms.Label();
            this.TP_codproducto = new System.Windows.Forms.TextBox();
            this.LP_codigoproduc = new System.Windows.Forms.Label();
            this.CBP_inactivo = new System.Windows.Forms.CheckBox();
            this.CBP_activo = new System.Windows.Forms.CheckBox();
            this.CB_productocat = new System.Windows.Forms.ComboBox();
            this.TP_stock = new System.Windows.Forms.TextBox();
            this.TP_precio = new System.Windows.Forms.TextBox();
            this.TP_nombre = new System.Windows.Forms.TextBox();
            this.LP_estadoproduc = new System.Windows.Forms.Label();
            this.LP_stockproduc = new System.Windows.Forms.Label();
            this.LP_precioproduc = new System.Windows.Forms.Label();
            this.LP_descirpproduc = new System.Windows.Forms.Label();
            this.LP_nombreproduc = new System.Windows.Forms.Label();
            this.LAS_cate_titulo = new System.Windows.Forms.Label();
            this.botonAgregarProducto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vaciar_productos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TP_descripcion);
            this.panel1.Controls.Add(this.LP_categoria);
            this.panel1.Controls.Add(this.LAS_cate_titulo);
            this.panel1.Controls.Add(this.TP_codproducto);
            this.panel1.Controls.Add(this.LP_codigoproduc);
            this.panel1.Controls.Add(this.CBP_inactivo);
            this.panel1.Controls.Add(this.CBP_activo);
            this.panel1.Controls.Add(this.CB_productocat);
            this.panel1.Controls.Add(this.TP_stock);
            this.panel1.Controls.Add(this.TP_precio);
            this.panel1.Controls.Add(this.TP_nombre);
            this.panel1.Controls.Add(this.LP_estadoproduc);
            this.panel1.Controls.Add(this.LP_stockproduc);
            this.panel1.Controls.Add(this.LP_precioproduc);
            this.panel1.Controls.Add(this.LP_descirpproduc);
            this.panel1.Controls.Add(this.LP_nombreproduc);
            this.panel1.Location = new System.Drawing.Point(32, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 440);
            this.panel1.TabIndex = 0;
            // 
            // TP_descripcion
            // 
            this.TP_descripcion.Location = new System.Drawing.Point(225, 152);
            this.TP_descripcion.Name = "TP_descripcion";
            this.TP_descripcion.Size = new System.Drawing.Size(185, 20);
            this.TP_descripcion.TabIndex = 17;
            // 
            // LP_categoria
            // 
            this.LP_categoria.AutoSize = true;
            this.LP_categoria.BackColor = System.Drawing.Color.Silver;
            this.LP_categoria.CausesValidation = false;
            this.LP_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LP_categoria.ForeColor = System.Drawing.Color.White;
            this.LP_categoria.Location = new System.Drawing.Point(3, 193);
            this.LP_categoria.Name = "LP_categoria";
            this.LP_categoria.Size = new System.Drawing.Size(134, 29);
            this.LP_categoria.TabIndex = 16;
            this.LP_categoria.Text = "Categoria:";
            // 
            // TP_codproducto
            // 
            this.TP_codproducto.Location = new System.Drawing.Point(225, 53);
            this.TP_codproducto.Name = "TP_codproducto";
            this.TP_codproducto.Size = new System.Drawing.Size(185, 20);
            this.TP_codproducto.TabIndex = 15;
            // 
            // LP_codigoproduc
            // 
            this.LP_codigoproduc.AutoSize = true;
            this.LP_codigoproduc.BackColor = System.Drawing.Color.Silver;
            this.LP_codigoproduc.CausesValidation = false;
            this.LP_codigoproduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LP_codigoproduc.ForeColor = System.Drawing.Color.White;
            this.LP_codigoproduc.Location = new System.Drawing.Point(3, 53);
            this.LP_codigoproduc.Name = "LP_codigoproduc";
            this.LP_codigoproduc.Size = new System.Drawing.Size(217, 29);
            this.LP_codigoproduc.TabIndex = 14;
            this.LP_codigoproduc.Text = "Codigo Producto:";
            // 
            // CBP_inactivo
            // 
            this.CBP_inactivo.AutoSize = true;
            this.CBP_inactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBP_inactivo.Location = new System.Drawing.Point(204, 383);
            this.CBP_inactivo.Name = "CBP_inactivo";
            this.CBP_inactivo.Size = new System.Drawing.Size(84, 17);
            this.CBP_inactivo.TabIndex = 13;
            this.CBP_inactivo.Text = "INACTIVO";
            this.CBP_inactivo.UseVisualStyleBackColor = true;
            // 
            // CBP_activo
            // 
            this.CBP_activo.AutoSize = true;
            this.CBP_activo.Checked = true;
            this.CBP_activo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBP_activo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBP_activo.Location = new System.Drawing.Point(72, 383);
            this.CBP_activo.Name = "CBP_activo";
            this.CBP_activo.Size = new System.Drawing.Size(71, 17);
            this.CBP_activo.TabIndex = 12;
            this.CBP_activo.Text = "ACTIVO";
            this.CBP_activo.UseVisualStyleBackColor = true;
            // 
            // CB_productocat
            // 
            this.CB_productocat.FormattingEnabled = true;
            this.CB_productocat.Items.AddRange(new object[] {
            "Perfumeria",
            "Limpieza",
            "Drogueria"});
            this.CB_productocat.Location = new System.Drawing.Point(225, 193);
            this.CB_productocat.Name = "CB_productocat";
            this.CB_productocat.Size = new System.Drawing.Size(185, 21);
            this.CB_productocat.TabIndex = 11;
            // 
            // TP_stock
            // 
            this.TP_stock.Location = new System.Drawing.Point(225, 293);
            this.TP_stock.Name = "TP_stock";
            this.TP_stock.Size = new System.Drawing.Size(185, 20);
            this.TP_stock.TabIndex = 10;
            // 
            // TP_precio
            // 
            this.TP_precio.Location = new System.Drawing.Point(225, 244);
            this.TP_precio.Name = "TP_precio";
            this.TP_precio.Size = new System.Drawing.Size(185, 20);
            this.TP_precio.TabIndex = 9;
            // 
            // TP_nombre
            // 
            this.TP_nombre.Location = new System.Drawing.Point(225, 118);
            this.TP_nombre.Name = "TP_nombre";
            this.TP_nombre.Size = new System.Drawing.Size(185, 20);
            this.TP_nombre.TabIndex = 7;
            // 
            // LP_estadoproduc
            // 
            this.LP_estadoproduc.AutoSize = true;
            this.LP_estadoproduc.BackColor = System.Drawing.Color.Silver;
            this.LP_estadoproduc.CausesValidation = false;
            this.LP_estadoproduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LP_estadoproduc.ForeColor = System.Drawing.Color.White;
            this.LP_estadoproduc.Location = new System.Drawing.Point(128, 327);
            this.LP_estadoproduc.Name = "LP_estadoproduc";
            this.LP_estadoproduc.Size = new System.Drawing.Size(101, 29);
            this.LP_estadoproduc.TabIndex = 6;
            this.LP_estadoproduc.Text = "Estado:";
            // 
            // LP_stockproduc
            // 
            this.LP_stockproduc.AutoSize = true;
            this.LP_stockproduc.BackColor = System.Drawing.Color.Silver;
            this.LP_stockproduc.CausesValidation = false;
            this.LP_stockproduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LP_stockproduc.ForeColor = System.Drawing.Color.White;
            this.LP_stockproduc.Location = new System.Drawing.Point(3, 293);
            this.LP_stockproduc.Name = "LP_stockproduc";
            this.LP_stockproduc.Size = new System.Drawing.Size(85, 29);
            this.LP_stockproduc.TabIndex = 5;
            this.LP_stockproduc.Text = "Stock:";
            // 
            // LP_precioproduc
            // 
            this.LP_precioproduc.AutoSize = true;
            this.LP_precioproduc.BackColor = System.Drawing.Color.Silver;
            this.LP_precioproduc.CausesValidation = false;
            this.LP_precioproduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LP_precioproduc.ForeColor = System.Drawing.Color.White;
            this.LP_precioproduc.Location = new System.Drawing.Point(3, 236);
            this.LP_precioproduc.Name = "LP_precioproduc";
            this.LP_precioproduc.Size = new System.Drawing.Size(96, 29);
            this.LP_precioproduc.TabIndex = 4;
            this.LP_precioproduc.Text = "Precio:";
            // 
            // LP_descirpproduc
            // 
            this.LP_descirpproduc.AutoSize = true;
            this.LP_descirpproduc.BackColor = System.Drawing.Color.Silver;
            this.LP_descirpproduc.CausesValidation = false;
            this.LP_descirpproduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LP_descirpproduc.ForeColor = System.Drawing.Color.White;
            this.LP_descirpproduc.Location = new System.Drawing.Point(3, 152);
            this.LP_descirpproduc.Name = "LP_descirpproduc";
            this.LP_descirpproduc.Size = new System.Drawing.Size(159, 29);
            this.LP_descirpproduc.TabIndex = 3;
            this.LP_descirpproduc.Text = "Descripcion:";
            // 
            // LP_nombreproduc
            // 
            this.LP_nombreproduc.AutoSize = true;
            this.LP_nombreproduc.BackColor = System.Drawing.Color.Silver;
            this.LP_nombreproduc.CausesValidation = false;
            this.LP_nombreproduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LP_nombreproduc.ForeColor = System.Drawing.Color.White;
            this.LP_nombreproduc.Location = new System.Drawing.Point(3, 110);
            this.LP_nombreproduc.Name = "LP_nombreproduc";
            this.LP_nombreproduc.Size = new System.Drawing.Size(114, 29);
            this.LP_nombreproduc.TabIndex = 2;
            this.LP_nombreproduc.Text = "Nombre:";
            // 
            // LAS_cate_titulo
            // 
            this.LAS_cate_titulo.AutoSize = true;
            this.LAS_cate_titulo.BackColor = System.Drawing.Color.Silver;
            this.LAS_cate_titulo.CausesValidation = false;
            this.LAS_cate_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAS_cate_titulo.ForeColor = System.Drawing.Color.White;
            this.LAS_cate_titulo.Location = new System.Drawing.Point(35, 0);
            this.LAS_cate_titulo.Name = "LAS_cate_titulo";
            this.LAS_cate_titulo.Size = new System.Drawing.Size(346, 33);
            this.LAS_cate_titulo.TabIndex = 1;
            this.LAS_cate_titulo.Text = "ALTA DE PRODUCTOS";
            // this.LAS_cate_titulo.Click += new System.EventHandler(this.LAS_cate_titulo_Click);
            // 
            // botonAgregarProducto
            // 
            this.botonAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregarProducto.Location = new System.Drawing.Point(123, 492);
            this.botonAgregarProducto.Name = "botonAgregarProducto";
            this.botonAgregarProducto.Size = new System.Drawing.Size(271, 70);
            this.botonAgregarProducto.TabIndex = 2;
            this.botonAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.botonAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonAgregarProducto.UseVisualStyleBackColor = true;
            this.botonAgregarProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 501);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // vaciar_productos
            // 
            this.vaciar_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaciar_productos.Location = new System.Drawing.Point(123, 568);
            this.vaciar_productos.Name = "vaciar_productos";
            this.vaciar_productos.Size = new System.Drawing.Size(271, 70);
            this.vaciar_productos.TabIndex = 4;
            this.vaciar_productos.Text = "VACIAR CAMPOS";
            this.vaciar_productos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vaciar_productos.UseVisualStyleBackColor = true;
            this.vaciar_productos.Click += new System.EventHandler(this.vaciar_productos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(135, 568);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 69);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // AgrerarProductoAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(481, 649);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.vaciar_productos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonAgregarProducto);
            this.Controls.Add(this.panel1);
            this.Name = "AgrerarProductoAdmi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgrerarProductoAdmi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LAS_cate_titulo;
        private System.Windows.Forms.Label LP_estadoproduc;
        private System.Windows.Forms.Label LP_stockproduc;
        private System.Windows.Forms.Label LP_precioproduc;
        private System.Windows.Forms.Label LP_descirpproduc;
        private System.Windows.Forms.Label LP_nombreproduc;
        private System.Windows.Forms.ComboBox CB_productocat;
        private System.Windows.Forms.TextBox TP_stock;
        private System.Windows.Forms.TextBox TP_precio;
        private System.Windows.Forms.TextBox TP_nombre;
        private System.Windows.Forms.CheckBox CBP_inactivo;
        private System.Windows.Forms.CheckBox CBP_activo;
        private System.Windows.Forms.Button botonAgregarProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LP_codigoproduc;
        private System.Windows.Forms.TextBox TP_codproducto;
        private System.Windows.Forms.TextBox TP_descripcion;
        private System.Windows.Forms.Label LP_categoria;
        private System.Windows.Forms.Button vaciar_productos;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}