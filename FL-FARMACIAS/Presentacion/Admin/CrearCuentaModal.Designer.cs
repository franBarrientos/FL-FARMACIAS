namespace FL_FARMACIAS.Presentacion.Admin
{
    partial class CrearCuentaModal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BFalta_ingresarcli = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BFalta_ingresarcli);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(86, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 546);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ASIGNAR CUENTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTE EMPLEADO AUN NO POSEE UNA CUENTA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 31);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "CLAVE";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(317, 345);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 31);
            this.textBox2.TabIndex = 4;
            // 
            // BFalta_ingresarcli
            // 
            this.BFalta_ingresarcli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BFalta_ingresarcli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFalta_ingresarcli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BFalta_ingresarcli.Location = new System.Drawing.Point(347, 418);
            this.BFalta_ingresarcli.Margin = new System.Windows.Forms.Padding(6);
            this.BFalta_ingresarcli.Name = "BFalta_ingresarcli";
            this.BFalta_ingresarcli.Size = new System.Drawing.Size(240, 60);
            this.BFalta_ingresarcli.TabIndex = 6;
            this.BFalta_ingresarcli.Text = "ASIGNAR";
            this.BFalta_ingresarcli.UseVisualStyleBackColor = false;
            this.BFalta_ingresarcli.Click += new System.EventHandler(this.BFalta_ingresarcli_Click);
            // 
            // CrearCuentaModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 694);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1113, 765);
            this.MinimumSize = new System.Drawing.Size(1113, 765);
            this.Name = "CrearCuentaModal";
            this.Text = "CuentaModal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BFalta_ingresarcli;
    }
}