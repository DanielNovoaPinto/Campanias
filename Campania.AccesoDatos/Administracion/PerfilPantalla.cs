using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Administracion
{
    public class PerfilPantalla : serTI.Campania.Modelo.BaseDatos.PerfilPantalla, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public bool Insertar(object perfilpantalla)
        {
            try
            {
                oBaseDatos.AddToPerfilPantalla((serTI.Campania.Modelo.BaseDatos.PerfilPantalla)perfilpantalla);
                oBaseDatos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Actualizar(object perfilpantalla)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.PerfilPantalla();
                item.ClavePerfil = ((serTI.Campania.Modelo.BaseDatos.PerfilPantalla)perfilpantalla).ClavePerfil;
                item.ClavePantalla = ((serTI.Campania.Modelo.BaseDatos.PerfilPantalla)perfilpantalla).ClavePantalla;
                item.Visible = ((serTI.Campania.Modelo.BaseDatos.PerfilPantalla)perfilpantalla).Visible;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.PerfilPantalla)perfilpantalla).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.PerfilPantalla)perfilpantalla).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.PerfilPantalla)perfilpantalla).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.PerfilPantalla)perfilpantalla).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.PerfilPantalla)perfilpantalla).FechaCreacion;
                var upd = (from perpan in oBaseDatos.PerfilPantalla
                           //   where arc.Archivo1 == 40
                           select perpan).First();
                upd.ClavePerfil = item.ClavePerfil;
                upd.ClavePantalla = item.ClavePantalla;
                upd.Visible = item.Visible;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.PerfilPantalla.ToList();

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
                var eli = (from perpan in oBaseDatos.PerfilPantalla
                           //         where arc.Clave == 40
                           select perpan).First();

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
