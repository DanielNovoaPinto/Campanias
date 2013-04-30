using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Reporte
{
    public class ImportarClienteContacto : serTI.Campania.Modelo.BaseDatos.ImportarClienteContacto, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public bool Insertar(object importarempresacontacto)
        {
            try
            {
                oBaseDatos.AddToImportarClienteContacto((serTI.Campania.Modelo.BaseDatos.ImportarClienteContacto)importarempresacontacto);
                oBaseDatos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Actualizar(object importarempresacontacto)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.ImportarClienteContacto();

                item.ClaveImportarCliente = ((serTI.Campania.Modelo.BaseDatos.ImportarClienteContacto)importarempresacontacto).ClaveImportarCliente;
                item.ClaveContacto = ((serTI.Campania.Modelo.BaseDatos.ImportarClienteContacto)importarempresacontacto).ClaveContacto;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.ImportarClienteContacto)importarempresacontacto).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.ImportarClienteContacto)importarempresacontacto).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.ImportarClienteContacto)importarempresacontacto).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.ImportarClienteContacto)importarempresacontacto).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.ImportarClienteContacto)importarempresacontacto).FechaCreacion;
                var upd = (from impempcon in oBaseDatos.ImportarClienteContacto
                           //   where arc.Archivo1 == 40
                           select impempcon).First();
                upd.ClaveImportarCliente = item.ClaveImportarCliente;
                upd.ClaveContacto = item.ClaveContacto;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.ImportarClienteContacto.ToList();

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
                var eli = (from impempcon in oBaseDatos.ImportarClienteContacto
                           //         where arc.Clave == 40
                           select impempcon).First();

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
