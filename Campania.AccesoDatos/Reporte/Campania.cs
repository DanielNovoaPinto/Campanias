using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Reporte
{
    public class Campania : serTI.Campania.Modelo.BaseDatos.Campania, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public bool Insertar(object campania)
        {
            try
            {
                oBaseDatos.AddToCampania((serTI.Campania.Modelo.BaseDatos.Campania)campania);
                oBaseDatos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Actualizar(object campania)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.Campania();

                item.Nombre = ((serTI.Campania.Modelo.BaseDatos.Campania)campania).Nombre;
                item.ClaveTipoCampania = ((serTI.Campania.Modelo.BaseDatos.Campania)campania).ClaveTipoCampania;
                item.ClaveEmpresa = ((serTI.Campania.Modelo.BaseDatos.Campania)campania).ClaveEmpresa;
                item.Descripcion = ((serTI.Campania.Modelo.BaseDatos.Campania)campania).Descripcion;
                item.FechaInicio = ((serTI.Campania.Modelo.BaseDatos.Campania)campania).FechaInicio;
                item.FechaFin = ((serTI.Campania.Modelo.BaseDatos.Campania)campania).FechaFin;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.Campania)campania).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.Campania)campania).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.Campania)campania).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.Campania)campania).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.Campania)campania).FechaCreacion;
                var upd = (from camp in oBaseDatos.Campania
                           //   where arc.Archivo1 == 40
                           select camp).First();
                upd.Nombre = item.Nombre;
                upd.ClaveTipoCampania = item.ClaveTipoCampania;
                upd.ClaveEmpresa = item.ClaveEmpresa;
                upd.Descripcion = item.Descripcion;
                upd.FechaInicio = item.FechaInicio;
                upd.FechaFin = item.FechaFin;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.Campania.ToList();

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
                var eli = (from camp in oBaseDatos.Campania
                           //         where arc.Clave == 40
                           select camp).First();

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
