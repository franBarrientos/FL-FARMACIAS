using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Aplicacion
{
    public class EmpleadoAplicacion
    {
        public EmpleadoAplicacion() { }

        public List<Empleadodominio> ObtenerTodos()
        {
            using (var db = new DBConnect())
            {
                return db.Empleado.Include(c => c.usuario).Include(c => c.cargo).ToList();
            }
        }

        public List<CargoDominio> ObtenerCargos()
        {
            using (var db = new DBConnect())
            {
                return db.Cargo.ToList();
            }
        }

        public List<Rol> ObtenerRoles()
        {
            using (var db = new DBConnect())
            {
                return db.Rol.Where(x => x.descripcion != "Admin").ToList();
            }
        }

        public CargoDominio ObtenerCargoPorDescripcion(string d)
        {
            using (var db = new DBConnect())
            {
                return db.Cargo.FirstOrDefault(x => x.descripcion == d);
            }
        }


        public void AgregarEmpleado(Empleadodominio d)
        {
            using (var db = new DBConnect())
            {
                db.Entry(d.cargo).State = EntityState.Unchanged;
                db.Empleado.Add(d);
                db.SaveChanges();
            }

        }

        public void BorrarEmpleado(int id)
        {

            using (var db = new DBConnect())
            {

                var empleadoExistente = db.Empleado.Include(c => c.usuario).FirstOrDefault(x => x.id == id);

                empleadoExistente.estado = false;

                db.SaveChanges();


            }
        }

                public void ActualizarEmpleado(Empleadodominio d)
            {
            Type type = d.GetType();
            foreach (var property in type.GetProperties())
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(d)}");
            }

          
            using (var db = new DBConnect())
            {

                var empleadoExistente = db.Empleado.Include(c => c.usuario).FirstOrDefault(x => x.id == d.id);

                if (empleadoExistente != null)
                {

                    // Actualizar los valores de la entidad existente
                    empleadoExistente.nombre = d.nombre;
                    empleadoExistente.apellido = d.apellido;
                    empleadoExistente.sexo = d.sexo;
                    empleadoExistente.dni = d.dni;
                    empleadoExistente.cuil = d.cuil;
                    empleadoExistente.telefono = d.telefono;
                    empleadoExistente.idCargo = d.idCargo;
                    empleadoExistente.salario = d.salario;
                    empleadoExistente.fechaingreso = d.fechaingreso;
                    empleadoExistente.foto = d.foto;
                    empleadoExistente.estado = d.estado;
                    if (d.usuario != null)
                    {
                        if (empleadoExistente.usuario == null)
                        {
                            // Crear y asignar nuevo usuario
                            //var nuevoUsuario = new UsuarioDominio
                            //{
                            //   usuario = d.usuario.usuario,
                            //  clave = d.usuario.clave,
                            /// rolId = d.usuario.rolId
                            //};

                            // Agregar el nuevo usuario a la base de datos
                            //db.Usuario.Add(nuevoUsuario);
                            //db.SaveChanges();  // Guardar primero el usuario para obtener su id

                            // Asignar el id del nuevo usuario al empleado
                            //empleadoExistente.idUsuario = nuevoUsuario.id; 


                            empleadoExistente.usuario = new UsuarioDominio
                            {
                                usuario = d.usuario.usuario,
                                clave = d.usuario.clave,
                                rolId = d.usuario.rolId
                            };

                            db.Usuario.Add(empleadoExistente.usuario);
                        }
                        else
                        {
                            empleadoExistente.usuario.usuario = d.usuario.usuario;
                            empleadoExistente.usuario.clave = d.usuario.clave;
                            empleadoExistente.usuario.rolId = d.usuario.rolId;
                        }
                   
                    }

                    // Guardar los cambios en la base de datos
                    db.SaveChanges();
                }
            }
        }


        public Empleadodominio BuscarEmpleado(string dni, string apellido, string cargo)
        {
            Console.WriteLine("DNI: " + dni + ", Apellido: " + apellido + ", Cargo: " + cargo);
            using (var db = new DBConnect())
            {
                return db.Empleado.Include(c => c.cargo)
                    .Include(c => c.usuario)
                    .Include(c => c.usuario.rol)
                    .Where(d => (string.IsNullOrEmpty(dni) || d.dni == dni) &&
                    (string.IsNullOrEmpty(apellido) || d.apellido.ToLower().StartsWith(apellido.ToLower())) &&
                    (string.IsNullOrEmpty(cargo) || d.cargo.descripcion == cargo))
                    .FirstOrDefault();
            }

        }

        public List<Empleadodominio> BuscarEmpleados(string dni, string apellido, string cargo, DateTime desde, DateTime hasta)
        {
            Console.WriteLine("DNI: " + dni + ", Apellido: " + apellido + ", Cargo: " + cargo + ", Desde: " + desde + ", Hasta: " + hasta);
            using (var db = new DBConnect())
            {
                return db.Empleado.Include(c => c.cargo)
                    .Include(c => c.usuario)
                    .Include(c => c.usuario.rol)
                    .Where(d => (string.IsNullOrEmpty(dni) || d.dni == dni) &&
                    (string.IsNullOrEmpty(apellido) || d.apellido.ToLower().StartsWith(apellido.ToLower())) &&
                    (string.IsNullOrEmpty(cargo) || d.cargo.descripcion == cargo) &&
                    (desde <= d.fechaingreso && hasta >= d.fechaingreso))
                    .ToList();
            }
            
        }
    }
}
