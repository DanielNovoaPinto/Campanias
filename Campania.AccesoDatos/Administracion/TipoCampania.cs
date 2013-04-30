using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Administracion
{
    public class TipoCampania : serTI.Campania.Modelo.BaseDatos.TipoCampania, IDatos
    {
        private  CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members


        public bool Insertar(object tipocampania)
        {
            try
            {
                oBaseDatos.AddToTipoCampania((serTI.Campania.Modelo.BaseDatos.TipoCampania)tipocampania);
                oBaseDatos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Actualizar(object tipocampania)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.TipoCampania();
                item.TipoCampania1 = ((serTI.Campania.Modelo.BaseDatos.TipoCampania)tipocampania).TipoCampania1;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.TipoCampania)tipocampania).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.TipoCampania)tipocampania).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.TipoCampania)tipocampania).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.TipoCampania)tipocampania).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.TipoCampania)tipocampania).FechaCreacion;
                var upd = (from tipcamp in oBaseDatos.TipoCampania
                        //    where per.Nombre == ""
                           select tipcamp).First();
                upd.TipoCampania1 = item.TipoCampania1;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.TipoCampania.ToList();

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
                var eli = (from tipcamp in oBaseDatos.TipoCampania
                           //          where per.Nombre == ""
                           select tipcamp).First();

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
