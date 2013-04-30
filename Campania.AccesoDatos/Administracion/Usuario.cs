using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Administracion
{
   public class Usuario : serTI.Campania.Modelo.BaseDatos.Usuario, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public object Insertar(object usuario)
        {
            try
            {
                oBaseDatos.AddToUsuario((serTI.Campania.Modelo.BaseDatos.Usuario)usuario);
                oBaseDatos.SaveChanges();
                return ((serTI.Campania.Modelo.BaseDatos.Usuario)usuario).Clave;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public bool Actualizar(object usuario)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.Usuario();
                item.Nombre = ((serTI.Campania.Modelo.BaseDatos.Usuario)usuario).Nombre;
                item.ApellidoPaterno = ((serTI.Campania.Modelo.BaseDatos.Usuario)usuario).ApellidoPaterno;
                item.ApellidoMaterno = ((serTI.Campania.Modelo.BaseDatos.Usuario)usuario).ApellidoMaterno;
                item.Usuario1 = ((serTI.Campania.Modelo.BaseDatos.Usuario)usuario).Usuario1;
                item.Contrasenia = ((serTI.Campania.Modelo.BaseDatos.Usuario)usuario).Contrasenia;
                item.ClavePerfil = ((serTI.Campania.Modelo.BaseDatos.Usuario)usuario).ClavePerfil;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.Usuario)usuario).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.Usuario)usuario).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.Usuario)usuario).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.Usuario)usuario).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.Usuario)usuario).FechaCreacion;
                var upd = (from usu in oBaseDatos.Usuario
                           where usu.Clave == ((serTI.Campania.Modelo.BaseDatos.Usuario)usuario).Clave
                           select usu).First();
                upd.Nombre = item.Nombre;
                upd.ApellidoPaterno = item.ApellidoPaterno;
                upd.ApellidoMaterno = item.ApellidoMaterno;
                upd.Usuario1 = item.Usuario1;
                upd.Contrasenia = item.Contrasenia;
                upd.ClavePerfil = item.ClavePerfil;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.Usuario.ToList();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Eliminar(object objetoModelo)
        {
            try
            {
                var eli = (from usu in oBaseDatos.Usuario
                           where usu.Clave == ((serTI.Campania.Modelo.BaseDatos.Usuario)objetoModelo).Clave
                           select usu).First();

                oBaseDatos.DeleteObject(eli);
                oBaseDatos.SaveChanges();

                return ((serTI.Campania.Modelo.BaseDatos.Usuario)objetoModelo).Clave;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Consultar(object objetoModelo)
        {
            try
            {
                oBaseDatos.Usuario.ToList().Where(i => i.Usuario1.Contains(((serTI.Campania.Modelo.BaseDatos.Usuario)objetoModelo).Usuario1));
                oBaseDatos.Usuario.ToList();

                oBaseDatos.SaveChanges();
               return objetoModelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public short ValidarUsuario(object objetoModelo)
        {
            //0  - usuario valido
            //1- usuario no encontrado en la base de datos
            // 2.- contrasenia erronea
            // 3.- desconocido

            var usuario = (serTI.Campania.Modelo.BaseDatos.Usuario)objetoModelo;
          
            try
            {
               var resultado=   oBaseDatos.Usuario.ToList().Count();

               var usuarioConteo = (from u in oBaseDatos.Usuario
                                 where u.Usuario1 == usuario.Usuario1 && u.Contrasenia == usuario.Contrasenia
                                 select u.Usuario1).Count();

             if (usuarioConteo == 1)
                    return 0;
                else
                    return 3;
            }
            catch (Exception)
            {
                return 3;
            }
        }

        public object Listar(int Inicio, int Final)
        {
           return  oBaseDatos.Usuario.ToList();
        }

        #endregion
    }
}
