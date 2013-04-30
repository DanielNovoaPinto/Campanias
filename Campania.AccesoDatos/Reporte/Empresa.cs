using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Reporte
{
    public class Empresa : serTI.Campania.Modelo.BaseDatos.Empresa, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public bool Insertar(object empresa)
        {
            try
            {
                oBaseDatos.AddToEmpresa((serTI.Campania.Modelo.BaseDatos.Empresa)empresa);
                oBaseDatos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Actualizar(object empresa)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.Empresa();

                item.Nombre = ((serTI.Campania.Modelo.BaseDatos.Empresa)empresa).Nombre;
                item.Direccion = ((serTI.Campania.Modelo.BaseDatos.Empresa)empresa).Direccion;
                item.Contacto = ((serTI.Campania.Modelo.BaseDatos.Empresa)empresa).Contacto;
                item.Email = ((serTI.Campania.Modelo.BaseDatos.Empresa)empresa).Email;
                item.Telefono = ((serTI.Campania.Modelo.BaseDatos.Empresa)empresa).Telefono;
                item.FechaHora = ((serTI.Campania.Modelo.BaseDatos.Empresa)empresa).FechaHora;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.Empresa)empresa).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.Empresa)empresa).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.Empresa)empresa).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.Empresa)empresa).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.Empresa)empresa).FechaCreacion;
                var upd = (from emp in oBaseDatos.Empresa
                           //   where arc.Archivo1 == 40
                           select emp).First();
                upd.Nombre = item.Nombre;
                upd.Direccion = item.Direccion;
                upd.Contacto = item.Contacto;
                upd.Email = item.Email;
                upd.Telefono = item.Telefono;
                upd.FechaHora = item.FechaHora;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.Empresa.ToList();

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
                var eli = (from emp in oBaseDatos.Empresa
                           //         where arc.Clave == 40
                           select emp).First();

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
