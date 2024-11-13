using FL_FARMACIAS.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Drawing; // Necesario para usar Image

namespace FL_FARMACIAS.Dominio
{

    public class CargoDominio
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public CargoDominio() { }

        public CargoDominio(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

    }
    public class Empleadodominio
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public bool sexo { get; set; }
        public string dni { get; set; }
        public string cuil { get; set; }
        public String telefono { get; set; }


        public CargoDominio cargo { get; set; } 
        public int idCargo { get; set; }
        public float salario { get; set; }
        public DateTime fechaingreso { get; set; }

        [Column(TypeName = "varbinary(max)")] // Especifica que se usará un campo binario en SQL Server
        public byte[] foto { get; set; }

        public UsuarioDominio usuario { get; set; }
        public int? idUsuario { get; set; }

        public bool estado { get; set; } // estado

        public Empleadodominio() { }

        public Empleadodominio( string nombre, string apellido, bool sexo, string dni, string cuil, String telefono, CargoDominio cargo, float salario, DateTime fechaingreso, byte[] foto)// Image foto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.dni = dni;
            this.cuil = cuil;
            this.telefono = telefono;
            this.cargo = cargo; // Cargo
            this.idCargo = cargo.id;
            this.salario = salario;
            this.fechaingreso = fechaingreso;
            this.foto = foto;
            this.estado = true;
        }

        public Empleadodominio(int id, string nombre, string apellido, bool sexo, string dni, string cuil, String telefono, CargoDominio cargo, float salario, DateTime fechaingreso, byte[] foto)// Image foto)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.dni = dni;
            this.cuil = cuil;
            this.telefono = telefono;
            this.cargo = cargo; // Cargo
            this.idCargo = cargo.id;
            this.salario = salario;
            this.fechaingreso = fechaingreso;
            this.foto = foto;
            this.estado = true;
        }
    }
}
