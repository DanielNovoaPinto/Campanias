using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Administracion
{
   public class Nota : serTI.Campania.Modelo.BaseDatos.Nota, IDatos
    {
       private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public bool Insertar(object nota)
        {
            try
            {
                oBaseDatos.AddToNota((serTI.Campania.Modelo.BaseDatos.Nota)nota);
                oBaseDatos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Actualizar(object nota)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.Nota();
                item.Descripcion = ((serTI.Campania.Modelo.BaseDatos.Nota)nota).Descripcion;
                item.ClaveFuenteInformacion = ((serTI.Campania.Modelo.BaseDatos.Nota)nota).ClaveFuenteInformacion;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.Nota)nota).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.Nota)nota).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.Nota)nota).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.Nota)nota).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.Nota)nota).FechaCreacion;
                var upd = (from nta in oBaseDatos.Nota
                           //   where nota.Archivo1 == 40
                           select nta).First();
                upd.Descripcion = item.Descripcion;
                upd.ClaveFuenteInformacion = item.ClaveFuenteInformacion;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.Nota.ToList();

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
                var eli = (from nota in oBaseDatos.Nota
                           //         where arc.Clave == 40
                           select nota).First();

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
                //gvLista.DataSource = oBaseDatos.Nota.ToList().Where(i => i.Nombre.Contains(txtBusNombre.Text));
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

