using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Administracion
{
    public class Pantalla : serTI.Campania.Modelo.BaseDatos.Pantalla, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public bool Insertar(object pantalla)
        {
            try
            {
                oBaseDatos.AddToPantalla((serTI.Campania.Modelo.BaseDatos.Pantalla)pantalla);
                oBaseDatos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Actualizar(object pantalla)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.Pantalla();
                item.Nombre = ((serTI.Campania.Modelo.BaseDatos.Pantalla)pantalla).Nombre;
                item.URL = ((serTI.Campania.Modelo.BaseDatos.Pantalla)pantalla).URL;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.Pantalla)pantalla).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.Pantalla)pantalla).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.Pantalla)pantalla).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.Pantalla)pantalla).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.Pantalla)pantalla).FechaCreacion;
                var upd = (from pant in oBaseDatos.Pantalla
                           //   where arc.Archivo1 == 40
                           select pant).First();
                upd.Nombre = item.Nombre;
                upd.URL = item.URL;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.Pantalla.ToList();

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
                var eli = (from arc in oBaseDatos.Pantalla
                           //         where arc.Clave == 40
                           select arc).First();

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
