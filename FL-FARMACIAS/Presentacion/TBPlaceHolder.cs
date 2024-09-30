using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class PlaceholderTextBox : TextBox
{
    private string _placeholder;
    private Color _placeholderColor = Color.Gray; // Color del placeholder
    private Color _textColor = Color.Black; // Color del texto normal
    private bool _isPassword;

    // Constructor sin parámetros (requerido por el diseñador de Visual Studio)
    public PlaceholderTextBox() : this(false) // Llama al otro constructor con valor por defecto
    {
    }

    // Constructor con un parámetro opcional
    public PlaceholderTextBox(bool isPassword)
    {
        this.GotFocus += PlaceholderTextBox_GotFocus;
        this.Enter += PlaceholderTextBox_Enter;
        this.Leave += PlaceholderTextBox_Leave;
        _isPassword = isPassword;
        InitializePlaceholder();
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

    [Browsable(true)]
    [Category("Behavior")]
    [Description("Indicates whether the TextBox is used to input passwords.")]
    public bool IsPassword
    {
        get { return _isPassword; }
        set
        {
            _isPassword = value;
            if (this.Text != _placeholder)
            {
                this.UseSystemPasswordChar = _isPassword; // Si no está mostrando el placeholder, aplica el enmascaramiento
            }
        }
    }

    // Método para inicializar el placeholder
    private void InitializePlaceholder()
    {
        if (string.IsNullOrEmpty(this.Text))
        {
            this.UseSystemPasswordChar = false; // No enmascarar cuando se muestra el placeholder
            this.Text = _placeholder;
            this.ForeColor = _placeholderColor; // Cambia el color del placeholder
        }
    }


    private void PlaceholderTextBox_GotFocus(object sender, EventArgs e)
    {
        // Limpia el texto cuando el control recibe el foco
        if (this.Text == _placeholder)
        {
            this.UseSystemPasswordChar = false;

            this.Text = string.Empty;
            this.ForeColor = _textColor; // Cambia el color del texto

           // this.UseSystemPasswordChar = _isPassword; // Enmascara si es un password box
            this.Invalidate();
        }
    }

    private void PlaceholderTextBox_Leave(object sender, EventArgs e)
    {
        // Muestra el placeholder si está vacío
        if (string.IsNullOrEmpty(this.Text))
        {
            this.UseSystemPasswordChar = false; // No enmascarar cuando se muestra el placeholder
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
            this.UseSystemPasswordChar = _isPassword; // Enmascara si es un password box
        }
    }
}