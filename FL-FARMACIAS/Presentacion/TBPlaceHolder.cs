using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class PlaceholderTextBox : TextBox
{
    private string _placeholder;
    private Color _placeholderColor = Color.Gray; // Color del placeholder
    private Color _textColor = Color.Black; // Color del texto normal

    public PlaceholderTextBox()
    {
        this.GotFocus += PlaceholderTextBox_GotFocus;
        this.LostFocus += PlaceholderTextBox_LostFocus;
        this.Enter += PlaceholderTextBox_Enter;
        this.Leave += PlaceholderTextBox_Leave;
      
    }

    [Browsable(true)]
    [Category("Appearance")]
    [Description("Text displayed when the TextBox is empty.")]
    public string Placeholder
    {
        get { return _placeholder; }
        set
        {
            _placeholder = value;
            InitializePlaceholder(); // Llama al método para inicializar el placeholder
            this.Invalidate(); // Fuerza el redibujo del control
        }
    }

    // Método para inicializar el placeholder
    private void InitializePlaceholder()
    {
        if (string.IsNullOrEmpty(this.Text))
        {
            this.Text = _placeholder;
            this.ForeColor = _placeholderColor; // Cambia el color del placeholder
        }
    }


    private void PlaceholderTextBox_GotFocus(object sender, EventArgs e)
    {
        // Limpia el texto cuando el control recibe el foco
        if (this.Text == _placeholder)
        {
            this.Text = string.Empty;
            this.ForeColor = _textColor; // Cambia el color del texto
            this.Invalidate();
        }
    }

    private void PlaceholderTextBox_LostFocus(object sender, EventArgs e)
    {
        // Si no hay texto, muestra el placeholder
        if (string.IsNullOrEmpty(this.Text))
        {
            this.Text = _placeholder;
            this.ForeColor = _placeholderColor; // Cambia el color del placeholder
           
        }
    }

    private void PlaceholderTextBox_Leave(object sender, EventArgs e)
    {
        // Muestra el placeholder si está vacío
        if (string.IsNullOrEmpty(this.Text))
        {
            this.Text = _placeholder;
            this.ForeColor = _placeholderColor; // Cambia el color del placeholder
        }
    }

    private void PlaceholderTextBox_Enter(object sender, EventArgs e)
    {
        // Si el texto es el placeholder, lo limpia
        if (this.Text == _placeholder)
        {
            this.Text = string.Empty;
            this.ForeColor = _textColor; // Cambia el color del texto
        }
    }
}
