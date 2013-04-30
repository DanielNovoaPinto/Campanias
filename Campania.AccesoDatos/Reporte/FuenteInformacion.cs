using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Reporte
{
    public class FuenteInformacion : serTI.Campania.Modelo.BaseDatos.FuenteInformacion, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public object Insertar(object fuenteinformacion)
        {
            try
            {
                oBaseDatos.AddToFuenteInformacion((serTI.Campania.Modelo.BaseDatos.FuenteInformacion)fuenteinformacion);
                oBaseDatos.SaveChanges();
                return ((serTI.Campania.Modelo.BaseDatos.FuenteInformacion)fuenteinformacion).Clave;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public bool Actualizar(object fuenteinformacion)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.FuenteInformacion();

                item.ClaveCampania = ((serTI.Campania.Modelo.BaseDatos.FuenteInformacion)fuenteinformacion).ClaveCampania;
                item.ClaveImportarCliente = ((serTI.Campania.Modelo.BaseDatos.FuenteInformacion)fuenteinformacion).ClaveImportarCliente;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.FuenteInformacion)fuenteinformacion).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.FuenteInformacion)fuenteinformacion).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.FuenteInformacion)fuenteinformacion).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.FuenteInformacion)fuenteinformacion).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.FuenteInformacion)fuenteinformacion).FechaCreacion;
                var upd = (from fueinf in oBaseDatos.FuenteInformacion
                           where fueinf.Clave == ((serTI.Campania.Modelo.BaseDatos.FuenteInformacion)fuenteinformacion).Clave
                           select fueinf).First();
                upd.ClaveCampania = item.ClaveCampania;
                upd.ClaveImportarCliente = item.ClaveImportarCliente;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.FuenteInformacion.ToList();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Eliminar(object objetoModelo)
        {
            try
            {
                var eli = (from fueinf in oBaseDatos.FuenteInformacion
                           where fueinf.Clave == ((serTI.Campania.Modelo.BaseDatos.FuenteInformacion)objetoModelo).Clave
                           select fueinf).First();

                oBaseDatos.DeleteObject(eli);
                oBaseDatos.SaveChanges();

                return ((serTI.Campania.Modelo.BaseDatos.FuenteInformacion)objetoModelo).Clave;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Consultar(object objetoModelo)
        {
            try
            {
                oBaseDatos.ImportarCliente.ToList().Where(i => i.Nombre.Contains(((serTI.Campania.Modelo.BaseDatos.ImportarCliente)objetoModelo).Nombre));
                oBaseDatos.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object Listar(int Inicio, int Final)
        {
            return oBaseDatos.FuenteInformacion.ToList();
        }

        #endregion
    }
}
