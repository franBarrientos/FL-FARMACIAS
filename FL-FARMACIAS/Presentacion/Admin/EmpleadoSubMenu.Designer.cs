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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCIONES0old = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ACCIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FL_FARMACIAS.Properties.Resources.Copia_de_f;
            this.pictureBox1.Location = new System.Drawing.Point(818, 595);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.ACCIONES0old,
            this.ACCIONES});
            this.dataGridView1.Location = new System.Drawing.Point(24, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 471);
            this.dataGridView1.TabIndex = 1;
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
            // ACCIONES0old
            // 
            this.ACCIONES0old.HeaderText = "ACCIONESOLD";
            this.ACCIONES0old.MinimumWidth = 8;
            this.ACCIONES0old.Name = "ACCIONES0old";
            this.ACCIONES0old.ReadOnly = true;
            this.ACCIONES0old.Width = 150;
            // 
            // ACCIONES
            // 
            this.ACCIONES.HeaderText = "ACCIONES";
            this.ACCIONES.MinimumWidth = 8;
            this.ACCIONES.Name = "ACCIONES";
            this.ACCIONES.ReadOnly = true;
            this.ACCIONES.Width = 150;
            // 
            // EmpleadoSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FL_FARMACIAS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1154, 759);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EmpleadoSubMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

            this.dataGridView1.CellPainting += DataGridView_CellPainting;
            this.dataGridView1.CellClick += DataGridView_CellClick;


            dataGridView1.Rows.Add("1", "Juan", "Pérez", "M", "12345678", "20-12345678-9", "555-1234", "Cajero", "30000");
            dataGridView1.Rows.Add("2", "Ana", "Gómez", "F", "87654321", "27-87654321-5", "555-5678", "Vendedora", "32000");

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

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn SEXO;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn CUIL;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn PUESTO;
        private DataGridViewTextBoxColumn SALARIO;
        private DataGridViewButtonColumn ACCIONES0old;
        private DataGridViewTextBoxColumn ACCIONES;
    }
}