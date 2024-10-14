﻿using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Aplicacion
{
    public class ProductoAplicacion
    {
    
        public ProductoAplicacion() { }
           

        public List<ProductoDominio> ObtenerTodos()
        {
            using (var db = new DBConnect())
            {
                return db.Producto
                   .Include(p => p.categoria)
                   .Include(p => p.marca)
                   .Include(p => p.laboratorio)
                   .ToList();
            }
        }


        public List<ProductoDominio> ObtenerTodosActivo()
        {
            using (var db = new DBConnect())
            {
                return db.Producto.Include(p => p.categoria)
                   .Include(p => p.marca)
                   .Include(p => p.laboratorio)
                   .Where(p => p.estado == true)
                   .ToList();
            }
        }

        public void AgregarProducto(ProductoDominio p)
        {
            using (var db = new DBConnect())
            {
                db.Entry(p.categoria).State = EntityState.Unchanged;
                db.Entry(p.marca).State = EntityState.Unchanged;
                if (p.laboratorio != null) 
                {
                    db.Entry(p.laboratorio).State = EntityState.Unchanged;
                }
                db.Producto.Add(p);
                db.SaveChanges();
            }
        }

        public void ActualizarProducto(ProductoDominio p)
        {
            using (var db = new DBConnect())
            {
                var o = db.Producto.First(g => g.codProducto == p.codProducto);

                o.precio = p.precio;
                o.stock = p.stock;
                o.codProducto = p.codProducto;
                o.nombre = p.nombre;
                o.estado = p.estado;
                if (p.categoria != null) { 
                    o.idCategoria = p.categoria.id;
                }
                if (p.laboratorio != null)
                {
                    o.idLaboratorio = p.laboratorio.id;
                }
                else
                {
                    o.idLaboratorio = null;
                }
                if (p.marca != null)
                {
                    o.idMarca = p.marca.id;
                }
                db.SaveChanges();
            }
        }

        public List<ProductoDominio> BuscarProductos(string cod = null,
                                                 string nombre = null,
                                                 string categoria = null)
        {
            using (var db = new DBConnect())
            {
                return db.Producto
                   .Include(p => p.marca)
                   .Include(p => p.laboratorio)
                   .Include(p => p.categoria)
                   .Where(p => (string.IsNullOrEmpty(cod) || p.codProducto.ToLower().StartsWith(cod.ToLower())) &&
                               (string.IsNullOrEmpty(nombre) || p.nombre.ToLower().StartsWith(nombre.ToLower())) &&
                               (string.IsNullOrEmpty(categoria) || p.categoria.descripcion.ToLower().StartsWith(categoria.ToLower())))
                   .ToList();
            }
        }

        public List<MarcaDominio> ObtenerMarcas()
        {
            using (var db = new DBConnect())
            {
                return db.Marca.ToList();
            }    

        }

        public MarcaDominio ObtenerMarcaPorNombre(string marca)
        {
            using (var db = new DBConnect())
            {
                return db.Marca.First(m => m.nombre == marca);
            }
        }

        public List<LaboratorioDominio> ObtenerLaboratorios()
        {
            using (var db = new DBConnect())
            {
                return db.Laboratorio.ToList();
            }
        }

        public LaboratorioDominio ObtenerLaboratorioPorNombre(string laboratorio)
        {
            using (var db = new DBConnect())
            {
                return db.Laboratorio.First(l => l.nombre == laboratorio);
            }
        }
    }
}