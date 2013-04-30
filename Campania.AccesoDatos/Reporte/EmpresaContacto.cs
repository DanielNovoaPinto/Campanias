using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Reporte
{
    public class EmpresaContacto : serTI.Campania.Modelo.BaseDatos.EmpresaContacto, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public bool Insertar(object empresacontacto)
        {
            try
            {
                oBaseDatos.AddToEmpresaContacto((serTI.Campania.Modelo.BaseDatos.EmpresaContacto)empresacontacto);
                oBaseDatos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Actualizar(object empresacontacto)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.EmpresaContacto();

                item.ClaveEmpresa = ((serTI.Campania.Modelo.BaseDatos.EmpresaContacto)empresacontacto).ClaveEmpresa;
                item.ClaveContacto = ((serTI.Campania.Modelo.BaseDatos.EmpresaContacto)empresacontacto).ClaveContacto;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.EmpresaContacto)empresacontacto).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.EmpresaContacto)empresacontacto).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.EmpresaContacto)empresacontacto).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.EmpresaContacto)empresacontacto).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.EmpresaContacto)empresacontacto).FechaCreacion;
                var upd = (from empcon in oBaseDatos.EmpresaContacto
                           //   where arc.Archivo1 == 40
                           select empcon).First();
                upd.ClaveEmpresa = item.ClaveEmpresa;
                upd.ClaveContacto = item.ClaveContacto;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.EmpresaContacto.ToList();

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
                var eli = (from empcon in oBaseDatos.EmpresaContacto
                           //         where arc.Clave == 40
                           select empcon).First();

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
