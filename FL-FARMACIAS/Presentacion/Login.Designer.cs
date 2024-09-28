namespace FL_FARMACIAS.Presentacion.Login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Bingresar_login = new System.Windows.Forms.Button();
            this.Beliminar_login = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usuario_login = new PlaceholderTextBox();
            this.contraseña_login = new PlaceholderTextBox(true);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Bingresar_login
            // 
            this.Bingresar_login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bingresar_login.FlatAppearance.BorderSize = 0;
            this.Bingresar_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Bingresar_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bingresar_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bingresar_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bingresar_login.ForeColor = System.Drawing.Color.ForestGreen;
            this.Bingresar_login.Image = ((System.Drawing.Image)(resources.GetObject("Bingresar_login.Image")));
            this.Bingresar_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bingresar_login.Location = new System.Drawing.Point(294, 297);
            this.Bingresar_login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Bingresar_login.Name = "Bingresar_login";
            this.Bingresar_login.Size = new System.Drawing.Size(180, 60);
            this.Bingresar_login.TabIndex = 3;
            this.Bingresar_login.Text = "INGRESAR";
            this.Bingresar_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bingresar_login.UseVisualStyleBackColor = false;
            this.Bingresar_login.Click += new System.EventHandler(this.Bingresar_login_Click);
            // 
            // Beliminar_login
            // 
            this.Beliminar_login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Beliminar_login.FlatAppearance.BorderSize = 0;
            this.Beliminar_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Beliminar_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Beliminar_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Beliminar_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beliminar_login.ForeColor = System.Drawing.Color.Red;
            this.Beliminar_login.Image = ((System.Drawing.Image)(resources.GetObject("Beliminar_login.Image")));
            this.Beliminar_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Beliminar_login.Location = new System.Drawing.Point(12, 297);
            this.Beliminar_login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Beliminar_login.Name = "Beliminar_login";
            this.Beliminar_login.Size = new System.Drawing.Size(180, 60);
            this.Beliminar_login.TabIndex = 4;
            this.Beliminar_login.Text = "ELIMINAR";
            this.Beliminar_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beliminar_login.UseVisualStyleBackColor = false;
            this.Beliminar_login.Click += new System.EventHandler(this.Beliminar_login_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FL_FARMACIAS.Properties.Resources.f__1___1___1_;
            this.pictureBox2.Location = new System.Drawing.Point(156, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // usuario_login
            // 
            this.usuario_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_login.ForeColor = System.Drawing.Color.Gray;
            this.usuario_login.Location = new System.Drawing.Point(46, 206);
            this.usuario_login.Name = "usuario_login";
            this.usuario_login.Placeholder = "NOMBRE DE USUARIO";
            this.usuario_login.Size = new System.Drawing.Size(414, 26);
            this.usuario_login.TabIndex = 7;
            this.usuario_login.Text = "NOMBRE DE USUARIO";
            // 
            // contraseña_login
            // 
            this.contraseña_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña_login.ForeColor = System.Drawing.Color.Gray;
            this.contraseña_login.Location = new System.Drawing.Point(46, 245);
            this.contraseña_login.Name = "contraseña_login";
            this.contraseña_login.Placeholder = "CLAVE";
            this.contraseña_login.Size = new System.Drawing.Size(414, 26);
            this.contraseña_login.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 381);
            this.Controls.Add(this.contraseña_login);
            this.Controls.Add(this.usuario_login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Beliminar_login);
            this.Controls.Add(this.Bingresar_login);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Bingresar_login;
        private System.Windows.Forms.Button Beliminar_login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private PlaceholderTextBox usuario_login;
        private PlaceholderTextBox contraseña_login;
    }
}