using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Reporte
{
    public class Contacto : serTI.Campania.Modelo.BaseDatos.Contacto, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public bool Insertar(object contacto)
        {
            try
            {
                oBaseDatos.AddToContacto((serTI.Campania.Modelo.BaseDatos.Contacto)contacto);
                oBaseDatos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Actualizar(object contacto)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.Contacto();

                item.Nombre = ((serTI.Campania.Modelo.BaseDatos.Contacto)contacto).Nombre;
                item.ApellidoPaterno = ((serTI.Campania.Modelo.BaseDatos.Contacto)contacto).ApellidoPaterno;
                item.ApellidoMaterno = ((serTI.Campania.Modelo.BaseDatos.Contacto)contacto).ApellidoMaterno;
                item.TelefonoCelular = ((serTI.Campania.Modelo.BaseDatos.Contacto)contacto).TelefonoCelular;
                item.Fax = ((serTI.Campania.Modelo.BaseDatos.Contacto)contacto).Fax;
                item.Extension = ((serTI.Campania.Modelo.BaseDatos.Contacto)contacto).Extension;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.Contacto)contacto).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.Contacto)contacto).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.Contacto)contacto).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.Contacto)contacto).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.Contacto)contacto).FechaCreacion;
                var upd = (from camp in oBaseDatos.Contacto
                           //   where arc.Archivo1 == 40
                           select camp).First();
                upd.Nombre = item.Nombre;
                upd.ApellidoPaterno = item.ApellidoPaterno;
                upd.ApellidoMaterno = item.ApellidoMaterno;
                upd.TelefonoCelular = item.TelefonoCelular;
                upd.Fax = item.Fax;
                upd.Extension = item.Extension;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.Contacto.ToList();

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
                var eli = (from con in oBaseDatos.Contacto
                           //         where arc.Clave == 40
                           select con).First();

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
                //gvLista.DataSource = oBaseDatos.Archivo.ToList().Where(i => i.Nombre.Contains(txtBusNombre.Text));
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
