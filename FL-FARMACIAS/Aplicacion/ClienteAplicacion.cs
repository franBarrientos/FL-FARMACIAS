﻿using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Aplicacion
{
    public  class ClienteAplicacion
    {


        public ClienteAplicacion()
        {
        }

        public List<ClienteDominio> ObtenerTodos()
        {
            using (var db = new DBConnect())
            {
                return db.Cliente.Include(c => c.desc).Where(d => d.dni != "11111111").ToList();
            }
        }

        public ClienteDominio ObtenerClienteConsumidorFinal()
        {
            using (var db = new DBConnect())
            {
                return db.Cliente.FirstOrDefault(x => x.dni == "11111111");
            }
        }

        //save new 
        public void AgregarCliente(ClienteDominio d)
        {
            using (var db = new DBConnect())
            {
                try
                {
                    db.Entry(d.desc).State = EntityState.Unchanged;
                    db.Cliente.Add(d);
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException != null && ex.InnerException.InnerException is SqlException sqlEx)
                    {
                        if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                        {
                            throw new ApplicationException("El cliente con el DNI proporcionado ya existe.");
                        }
                        else
                        {
                            throw new ApplicationException("Error al agregar el cliente. " + sqlEx.Message);
                        }
                    }
                }
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


        public List<ClienteDominio> BuscarCliente(string dni = null,
                                                         string apellido = null,
                                                         bool? estado = null,
                                                         string desc = null)
        {
            Console.WriteLine("DNI: " + dni + ", Descripción: " + apellido + ", Estado: " + estado);
            using (var db = new DBConnect())
            {
                return db.Cliente.Include(c => c.desc).Where(d =>
                (string.IsNullOrEmpty(dni) || d.dni == dni) &&
                (string.IsNullOrEmpty(desc) || (d.desc == null) || d.desc.descripcion == desc) &&
                (string.IsNullOrEmpty(apellido) || d.apellido.ToLower().StartsWith(apellido.ToLower())) &&
                (!estado.HasValue || d.activo == estado) && d.dni != "11111111")
                .ToList();
            }
        }

    }
}
