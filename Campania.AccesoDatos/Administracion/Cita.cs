using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Administracion
{
  public  class Cita : serTI.Campania.Modelo.BaseDatos.Cita, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public bool Insertar(object cita)
        {
            try
            {
                oBaseDatos.AddToCita((serTI.Campania.Modelo.BaseDatos.Cita)cita);
                oBaseDatos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Actualizar(object cita)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.Cita();
                item.Lugar = ((serTI.Campania.Modelo.BaseDatos.Cita)cita).Lugar;
                item.FechaHora = ((serTI.Campania.Modelo.BaseDatos.Cita)cita).FechaHora;
                item.ClaveFuenteInformacion = ((serTI.Campania.Modelo.BaseDatos.Cita)cita).ClaveFuenteInformacion;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.Cita)cita).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.Cita)cita).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.Cita)cita).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.Cita)cita).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.Cita)cita).FechaCreacion;
                var upd = (from cit in oBaseDatos.Cita
                           //   where nota.Archivo1 == 40
                           select cit).First();
                upd.Lugar = item.Lugar;
                upd.FechaHora = item.FechaHora;
                upd.ClaveFuenteInformacion = item.ClaveFuenteInformacion;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.Cita.ToList();
                oBaseDatos.SaveChanges();

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
                var eli = (from cit in oBaseDatos.Cita
                           //         where arc.Clave == 40
                           select cit).First();

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

