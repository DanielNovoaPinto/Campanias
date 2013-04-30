using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Reporte
{
    public class ImportarCliente : serTI.Campania.Modelo.BaseDatos.ImportarCliente, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public object Insertar(object importarcliente)
        {
            try
            {
                oBaseDatos.AddToImportarCliente((serTI.Campania.Modelo.BaseDatos.ImportarCliente)importarcliente);
                oBaseDatos.SaveChanges();
                return ((serTI.Campania.Modelo.BaseDatos.ImportarCliente)importarcliente).Clave;
            }
            catch (Exception)
            {
                return  0;
            }
        }
        public bool Actualizar(object importarcliente)
        {
            try
            {
               var item =  (serTI.Campania.Modelo.BaseDatos.ImportarCliente)importarcliente;




                item.Nombre = ((serTI.Campania.Modelo.BaseDatos.ImportarCliente)importarcliente).Nombre;
                item.Direccion = ((serTI.Campania.Modelo.BaseDatos.ImportarCliente)importarcliente).Direccion;
                item.Contacto = ((serTI.Campania.Modelo.BaseDatos.ImportarCliente)importarcliente).Contacto;
                item.Email = ((serTI.Campania.Modelo.BaseDatos.ImportarCliente)importarcliente).Email;
                item.Telefono = ((serTI.Campania.Modelo.BaseDatos.ImportarCliente)importarcliente).Telefono;
                item.FechaHora = ((serTI.Campania.Modelo.BaseDatos.ImportarCliente)importarcliente).FechaHora;
                //var upd = (from i in oBaseDatos.ImportarCliente
                //           where i.Clave == item.Clave
                //           select i).First();
                var upd = (from i in oBaseDatos.ImportarCliente
                           where i.Clave == item.Clave
                           select i).First();

                upd.Nombre = item.Nombre;
                upd.Direccion = item.Direccion;
                upd.Contacto = item.Contacto;
                upd.Email = item.Email;
                upd.Telefono = item.Telefono;
                upd.FechaHora = item.FechaHora;
                upd.ClaveExcel = item.ClaveExcel;
                oBaseDatos.SaveChanges();
                oBaseDatos.ImportarCliente.ToList();

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
                var eli = (from impc in oBaseDatos.ImportarCliente
                           where impc.Clave == ((serTI.Campania.Modelo.BaseDatos.ImportarCliente)objetoModelo).Clave
                           select impc).First();

                oBaseDatos.DeleteObject(eli);
                oBaseDatos.SaveChanges();

                return true;
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
            return oBaseDatos.ImportarCliente.ToList();
        }


        #endregion
    }
}
