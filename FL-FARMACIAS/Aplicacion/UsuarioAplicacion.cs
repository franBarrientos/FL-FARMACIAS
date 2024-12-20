﻿using FL_FARMACIAS.Dominio;
using FL_FARMACIAS.Presentacion;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_FARMACIAS.Aplicacion
{
    public class UsuarioAplicacion
    {
        public UsuarioDominio ObtenerUsuarioPorUserPassw(string user, string passw)
        {
            passw = SimpleEncryption.Encrypt(passw);
            using (var db = new DBConnect())
            {
                var userExistente = db.Usuario.Include(u => u.rol).FirstOrDefault(x => x.usuario == user && x.clave == passw);
                Console.WriteLine(userExistente);
                if (userExistente != null){
                    var empleado = db.Empleado.FirstOrDefault(x => x.idUsuario == userExistente.id);
                    userExistente.empleado = empleado;
                    if (userExistente.empleado != null && userExistente.empleado.estado == false)
                    {
                        throw new Exception("Usuario inactivo");
                            
                    }
                    Console.WriteLine(userExistente);
                    return userExistente; 
                }else{
                    throw new Exception("Usuario o contraseña incorrectos");
                }

            }
        }
    }
}
