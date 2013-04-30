using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Administracion
{
    public class UsuarioCampania : serTI.Campania.Modelo.BaseDatos.UsuarioCampania, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public bool Insertar(object usuariocampania)
        {
            try
            {
                oBaseDatos.AddToUsuarioCampania((serTI.Campania.Modelo.BaseDatos.UsuarioCampania)usuariocampania);
                oBaseDatos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Actualizar(object usuariocampania)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.UsuarioCampania();

                item.ClaveCampania = ((serTI.Campania.Modelo.BaseDatos.UsuarioCampania)usuariocampania).ClaveCampania;
                item.ClaveUsuario = ((serTI.Campania.Modelo.BaseDatos.UsuarioCampania)usuariocampania).ClaveUsuario;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.UsuarioCampania)usuariocampania).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.UsuarioCampania)usuariocampania).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.UsuarioCampania)usuariocampania).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.UsuarioCampania)usuariocampania).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.UsuarioCampania)usuariocampania).FechaCreacion;
                var upd = (from usucamp in oBaseDatos.UsuarioCampania
                           //   where arc.Archivo1 == 40
                           select usucamp).First();
                upd.ClaveCampania = item.ClaveCampania;
                upd.ClaveUsuario = item.ClaveUsuario;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.UsuarioCampania.ToList();

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
                var eli = (from usucamp in oBaseDatos.UsuarioCampania
                           //         where arc.Clave == 40
                           select usucamp).First();

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
