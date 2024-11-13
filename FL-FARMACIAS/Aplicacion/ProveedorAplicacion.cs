using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Aplicacion
{
    public class ProveedorAplicacion
    {
        public ProveedorAplicacion()        
        {
        }

        public void AgregarProveedor(ProveedorDominio d)
        {
            using (var db = new DBConnect())
            {
                db.Proveedor.Add(d);
                db.SaveChanges();
            }
        }

        public void ActualizarProveedor(ProveedorDominio d)
        {
            using (var db = new DBConnect())
            {
                var proveedorExistente = db.Proveedor.FirstOrDefault(x => x.id == d.id);

                if (proveedorExistente != null)
                {
                    // Actualizar los valores de la entidad existente
                    proveedorExistente.nombre = d.nombre;
                    proveedorExistente.cuit = d.cuit;
                    proveedorExistente.telefono = d.telefono;
                    proveedorExistente.correo = d.correo;
                    proveedorExistente.activo = d.activo;
                    proveedorExistente.provincia = d.provincia;
                    proveedorExistente.localidad = d.localidad;
                    proveedorExistente.direccion = d.direccion;
                    // Guardar los cambios en la base de datos
                    db.SaveChanges();

                }
                
                }
            
        }

        public ProveedorDominio BuscarProveedorId(int id)
        {
            using (var db = new DBConnect())
            {
                return db.Proveedor.FirstOrDefault(x => x.id == id);
            }
        }

        public void EliminarProveedor(int id)
        {
            using (var db = new DBConnect())
            {
                var proveedorExistente = db.Proveedor.FirstOrDefault(x => x.id == id);

                if (proveedorExistente != null)
                {
                proveedorExistente.activo = false;
                db.SaveChanges();
                }
            }
        }

        public List<ProveedorDominio> ObtenerTodosActivo()
        {
           
            using (var db = new DBConnect())
            {
                return db.Proveedor.Where(c => c.activo == true).ToList();
            }
        }

        public List<ProveedorDominio> ObtenerTodos()
        {
            using (var db = new DBConnect())
            {
                return db.Proveedor.ToList();
            }
        }

        public ProveedorDominio ObtenerPorCuit(string cuit)
        {
            using (var db = new DBConnect())
            {
                return db.Proveedor.First(c => c.cuit == cuit);
            }
        }


        public List<ProveedorDominio> BuscarProveedor(string cuit, string apellido)
        {
            using (var db = new DBConnect()) {  
                return db.Proveedor
                    .Where(c => ((string.IsNullOrEmpty(cuit) || c.cuit == cuit) && (string.IsNullOrEmpty(apellido) || c.nombre.ToLower().StartsWith(apellido.ToLower()))))
                    .ToList();
            }
        }
    }
}
