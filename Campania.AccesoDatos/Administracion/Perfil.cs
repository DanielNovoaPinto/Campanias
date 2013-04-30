using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Administracion
{
   public class Perfil : serTI.Campania.Modelo.BaseDatos.Perfil, IDatos
    {
        private  CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members


        public bool Insertar(object perfil)
        {
            try
            {
                oBaseDatos.AddToPerfil((serTI.Campania.Modelo.BaseDatos.Perfil)perfil);
                oBaseDatos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Actualizar(object perfil)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.Perfil();
                item.Nombre = ((serTI.Campania.Modelo.BaseDatos.Perfil)perfil).Nombre;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.Perfil)perfil).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.Perfil)perfil).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.Perfil)perfil).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.Perfil)perfil).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.Perfil)perfil).FechaCreacion;
                var upd = (from per in oBaseDatos.Perfil
                        //    where per.Nombre == ""
                           select per).First();
                upd.Nombre = item.Nombre;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.Perfil.ToList();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Eliminar(object objetoModelo)
        {
            
            try
            {
                var eli = (from per in oBaseDatos.Perfil
                           //          where per.Nombre == ""
                           select per).First();

                oBaseDatos.DeleteObject(eli);
                oBaseDatos.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Consultar(object objetoModelo)
        {
            try
            {
               
                //gvLista.DataSource = oBaseDatos.Perfil.ToList().Where(i => i.Nombre.Contains(txtBusNombre.Text));
                //gvLista.DataBind();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
