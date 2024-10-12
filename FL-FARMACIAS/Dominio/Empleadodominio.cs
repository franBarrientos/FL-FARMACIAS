using FL_FARMACIAS.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Drawing; // Necesario para usar Image

namespace FL_FARMACIAS.Dominio
{
    public class Empleadodominio
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public bool sexo { get; set; }
        public string dni { get; set; }
        public string cuil { get; set; }
        public String telefono { get; set; }
        public string cargo { get; set; } // Cargo seleccionado del ComboBox
        public float salario { get; set; }
        public DateTime fechaingreso { get; set; }
        // public Image foto { get; set; } // Imagen del PictureBox

        public UsuarioDominio usuario { get; set; }
        public int? idUsuario { get; set; }
        public Empleadodominio() { }

        public Empleadodominio(int id, string nombre, string apellido, bool sexo, string dni, string cuil, String telefono, string cargo, float salario, DateTime fechaingreso)// Image foto)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.dni = dni;
            this.cuil = cuil;
            this.telefono = telefono;
            this.cargo = cargo; // Cargo
            this.salario = salario;
            this.fechaingreso = fechaingreso;
            //   this.foto = foto; // Imagen REVISAR EL TEMA DE LA IMAGEN CUANDO EL SUPERVISOR ALMACENA UNA IMAGEN
        }
    }
}
