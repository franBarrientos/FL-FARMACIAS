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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3w = new System.Windows.Forms.Button();
            this.label3w = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MODIFICAR = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.APELLIDO,
            this.SEXO,
            this.DNI,
            this.CUIL,
            this.TELEFONO,
            this.PUESTO,
            this.SALARIO,
            this.FECHAINGRESO,
            this.USUARIO,
            this.ELIMINAR,
            this.MODIFICAR});
            this.dataGridView1.Location = new System.Drawing.Point(24, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 471);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(468, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMPLEADOS";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(24, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "INGRESE DNI O APELLIDO";
            this.textBox1.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.TabIndexChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.converTextBlack);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(972, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Farmaceutico",
            "Supervisor",
            "Gerente"});
            this.comboBox1.Location = new System.Drawing.Point(503, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Todos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(423, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "PUESTO";
            // 
            // button3w
            // 
            this.button3w.Location = new System.Drawing.Point(80, 51);
            this.button3w.Name = "button3w";
            this.button3w.Size = new System.Drawing.Size(176, 78);
            this.button3w.TabIndex = 8;
            this.button3w.Text = "DAR DE ALTA NUEVO EMPLEADO";
            this.button3w.UseVisualStyleBackColor = true;
            // 
            // label3w
            // 
            this.label3w.AutoSize = true;
            this.label3w.BackColor = System.Drawing.Color.Transparent;
            this.label3w.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3w.ForeColor = System.Drawing.Color.Black;
            this.label3w.Location = new System.Drawing.Point(527, 122);
            this.label3w.Name = "label3w";
            this.label3w.Size = new System.Drawing.Size(110, 26);
            this.label3w.TabIndex = 9;
            this.label3w.Text = "FILTROS";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
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
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.MinimumWidth = 8;
            this.SEXO.Name = "SEXO";
            this.SEXO.ReadOnly = true;
            this.SEXO.Width = 150;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 8;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 150;
            // 
            // CUIL
            // 
            this.CUIL.HeaderText = "CUIL";
            this.CUIL.MinimumWidth = 8;
            this.CUIL.Name = "CUIL";
            this.CUIL.ReadOnly = true;
            this.CUIL.Width = 150;
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.MinimumWidth = 8;
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            this.TELEFONO.Width = 150;
            // 
            // PUESTO
            // 
            this.PUESTO.HeaderText = "PUESTO";
            this.PUESTO.MinimumWidth = 8;
            this.PUESTO.Name = "PUESTO";
            this.PUESTO.ReadOnly = true;
            this.PUESTO.Width = 150;
            // 
            // SALARIO
            // 
            this.SALARIO.HeaderText = "SALARIO";
            this.SALARIO.MinimumWidth = 8;
            this.SALARIO.Name = "SALARIO";
            this.SALARIO.ReadOnly = true;
            this.SALARIO.Width = 150;
            // 
            // FECHAINGRESO
            // 
            this.FECHAINGRESO.HeaderText = "FECHA INGRESO";
            this.FECHAINGRESO.MinimumWidth = 8;
            this.FECHAINGRESO.Name = "FECHAINGRESO";
            this.FECHAINGRESO.ReadOnly = true;
            this.FECHAINGRESO.Width = 150;
            // 
            // USUARIO
            // 
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.MinimumWidth = 8;
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.ReadOnly = true;
            this.USUARIO.Width = 150;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.MinimumWidth = 8;
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            this.ELIMINAR.Width = 150;
            // 
            // MODIFICAR
            // 
            this.MODIFICAR.HeaderText = "MODIFICAR";
            this.MODIFICAR.MinimumWidth = 8;
            this.MODIFICAR.Name = "MODIFICAR";
            this.MODIFICAR.ReadOnly = true;
            this.MODIFICAR.Width = 150;
            // 
            // EmpleadoSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1154, 759);
            this.Controls.Add(this.label3w);
            this.Controls.Add(this.button3w);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmpleadoSubMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Empleados Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int indexActionsButton = dataGridView1.Columns["ACCIONES"].Index;
            if (e.ColumnIndex == indexActionsButton && e.RowIndex >= 0) // Columna de "Actions"
            {
                //e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.PaintBackground(e.CellBounds, true);

                // Calcular el ancho y la altura de los botones para que ocupen todo el ancho de la celda y se alineen uno debajo del otro
                int buttonWidth = e.CellBounds.Width - 10;
                int buttonHeight = ( e.CellBounds.Height - 15 )  / 2;  // Espacio para dos botones
                Rectangle modifyButton = new Rectangle(e.CellBounds.Left + 5, e.CellBounds.Top + 5, buttonWidth, buttonHeight);
                Rectangle deleteButton = new Rectangle(e.CellBounds.Left + 5, e.CellBounds.Top + buttonHeight + 10, buttonWidth, buttonHeight);

                //// Verificar si el puntero está sobre uno de los botones
                //Point mousePosition = dataGridView1.PointToClient(Cursor.Position);
                //bool isHoveringModifyButton = modifyButton.Contains(mousePosition);
                //bool isHoveringDeleteButton = deleteButton.Contains(mousePosition);

                //// Cambiar el color del botón al pasar el puntero (hover)
                //Color modifyButtonColor = isHoveringModifyButton ? Color.LightBlue : SystemColors.Control;
                //Color deleteButtonColor = isHoveringDeleteButton ? Color.LightCoral : SystemColors.Control;

                //// Dibujar los botones con el color apropiado
                //ButtonRenderer.DrawButton(e.Graphics, modifyButton, isHoveringModifyButton ? PushButtonState.Hot : PushButtonState.Normal);
                //ButtonRenderer.DrawButton(e.Graphics, deleteButton, isHoveringDeleteButton ? PushButtonState.Hot : PushButtonState.Normal);

                //// Dibujar el texto de los botones
                //TextRenderer.DrawText(e.Graphics, "Modificar", this.Font, modifyButton, SystemColors.ControlText, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                //TextRenderer.DrawText(e.Graphics, "Eliminar", this.Font, deleteButton, SystemColors.ControlText, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);


                // Verificar si el puntero está sobre uno de los botones
                Point mousePosition = dataGridView1.PointToClient(Cursor.Position);
                bool isHoveringModifyButton = modifyButton.Contains(mousePosition);
                bool isHoveringDeleteButton = deleteButton.Contains(mousePosition);

                // Cambiar el color del botón al pasar el puntero (hover)
                Color modifyButtonColor = isHoveringModifyButton ? Color.LightBlue : SystemColors.Control;
                Color deleteButtonColor = isHoveringDeleteButton ? Color.LightCoral : SystemColors.Control;

                // Dibujar los botones sin contorno
                using (SolidBrush brush = new SolidBrush(modifyButtonColor))
                {
                    e.Graphics.FillRectangle(brush, modifyButton);
                }

                using (SolidBrush brush = new SolidBrush(deleteButtonColor))
                {
                    e.Graphics.FillRectangle(brush, deleteButton);
                }

                // Dibujar el texto de los botones
                TextRenderer.DrawText(e.Graphics, "Modificar", this.Font, modifyButton, SystemColors.ControlText, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                TextRenderer.DrawText(e.Graphics, "Eliminar", this.Font, deleteButton, SystemColors.ControlText, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);


                e.Handled = true;   
            }
        }

            private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                int indexActionsButton = dataGridView1.Columns["ACCIONES"].Index;
                if (e.ColumnIndex == indexActionsButton && e.RowIndex >= 0) // Columna de "Actions"
            {
                DataGridView dataGridView = sender as DataGridView;
                Rectangle cellBounds = dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                int buttonWidth = cellBounds.Width - 10;
                int buttonHeight = (cellBounds.Height - 15) / 2;
                Rectangle modifyButton = new Rectangle(cellBounds.Left + 5, cellBounds.Top + 5, buttonWidth, buttonHeight);
                Rectangle deleteButton = new Rectangle(cellBounds.Left + 5, cellBounds.Top + buttonHeight + 10, buttonWidth, buttonHeight);

                Point clickPosition = dataGridView.PointToClient(Cursor.Position);

                if (modifyButton.Contains(clickPosition))
                {
                    MessageBox.Show($"Modificar fila {e.RowIndex}");
                }
                else if (deleteButton.Contains(clickPosition))
                {
                    MessageBox.Show($"Eliminar fila {e.RowIndex}");
                }
            }
            }
        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label2;
        private Button button3w;
        private Label label3w;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn SEXO;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn CUIL;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn PUESTO;
        private DataGridViewTextBoxColumn SALARIO;
        private DataGridViewTextBoxColumn FECHAINGRESO;
        private DataGridViewButtonColumn USUARIO;
        private DataGridViewButtonColumn ELIMINAR;
        private DataGridViewButtonColumn MODIFICAR;
    }
}