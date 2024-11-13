using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Aplicacion
{
    public class CategoriaAplicacion
    {
        public CategoriaAplicacion()        
        {
        }

        public void AgregarCategoria(CategoriaDominio d)
        {
            using (var db = new DBConnect())
            {
                db.Categoria.Add(d);
                db.SaveChanges();
            }
        }

        public void ActualizarCategoria(CategoriaDominio d)
        {
            using (var db = new DBConnect())
            {
                var categoriaExistente = db.Categoria.FirstOrDefault(x => x.id == d.id);
                    // Actualizar los valores de la entidad existente
                    categoriaExistente.descripcion = d.descripcion;
                    categoriaExistente.estado = d.estado;

                    // Guardar los cambios en la base de datos
                    db.SaveChanges();
                }
            
        }

        public List<CategoriaDominio> ObtenerTodosActivo()
        {
           
            using (var db = new DBConnect())
            {
                return db.Categoria.Where(c => c.estado == true).ToList();
            }
        }

        public List<CategoriaDominio> ObtenerTodos()
        {
            using (var db = new DBConnect())
            {
                return db.Categoria.ToList();
            }
        }

        public CategoriaDominio ObtenerPorDescripcion(string categoria)
        {
            using (var db = new DBConnect())
            {
                return db.Categoria.First(c => c.descripcion == categoria);
            }
        }


        public List<CategoriaDominio> BuscarCategorias(int? id = null, string nombre = null)
        {
            using (var db = new DBConnect()) {  
                return db.Categoria
                    .Where(c => (!id.HasValue || c.id == id) && (string.IsNullOrEmpty(nombre) || c.descripcion.ToLower().StartsWith(nombre.ToLower())))
                    .ToList();
            }
        }
    }
}
