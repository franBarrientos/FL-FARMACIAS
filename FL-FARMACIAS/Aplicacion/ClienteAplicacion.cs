using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Aplicacion
{
    public  class ClienteAplicacion
    {
        private  DBConnect db;


        public ClienteAplicacion()
        {
            db = new DBConnect();
        }

        public List<ClienteDominio> ObtenerTodos()
        {
            return db.Cliente.ToList();
        }

        //save new 
        public void AgregarCliente(ClienteDominio d)
        {
            using (var db = new DBConnect())
            {
                db.Cliente.Add(d);
                db.SaveChanges();
            }
        }

        public void ActualizarCliente(ClienteDominio d)
        {
            using (var db = new DBConnect())
            {
                
                var clienteExistente = db.Cliente.FirstOrDefault(x => x.id == d.id);

                if (clienteExistente != null)
                {
                    // Actualizar los valores de la entidad existente
                    clienteExistente.nombre = d.nombre;
                    clienteExistente.apellido = d.apellido; 
                    clienteExistente.dni = d.dni;
                    clienteExistente.telefono = d.telefono;
                    clienteExistente.activo = d.activo;
                    clienteExistente.idDescuento = d.idDescuento;

                    // Guardar los cambios en la base de datos
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Cliente no encontrado.");
                }
            }
        }


        public List<ClienteDominio> BuscarCliente(int? dni = null,
                                                         string apellido = null,
                                                         bool? estado = null)
        {
            //haz un log
            Console.WriteLine("DNI: " + dni + ", Descripción: " + apellido + ", Estado: " + estado);
            using (var db = new DBConnect())
            {
                return db.Cliente.Where(d =>
                (!dni.HasValue || d.id == dni) &&
                (string.IsNullOrEmpty(apellido) || d.apellido.Contains(apellido)) &&  // Aquí está la corrección
                (!estado.HasValue || d.activo == estado))
                .ToList();
            }
        }

    }
}
