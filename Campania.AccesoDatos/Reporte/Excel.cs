using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Reporte
{
    public class Excel : serTI.Campania.Modelo.BaseDatos.Excel, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public object Insertar(object excel)
        {
            try
            {
                oBaseDatos.AddToExcel((serTI.Campania.Modelo.BaseDatos.Excel)excel);
                oBaseDatos.SaveChanges();
                return ((serTI.Campania.Modelo.BaseDatos.Excel)excel).Clave;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public bool Actualizar(object excel)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.Excel();

                item.Nombre = ((serTI.Campania.Modelo.BaseDatos.Excel)excel).Nombre;
                item.Ruta = ((serTI.Campania.Modelo.BaseDatos.Excel)excel).Ruta;
                item.ClaveUsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.Excel)excel).ClaveUsuarioActualizacion;
                item.FechaHora = ((serTI.Campania.Modelo.BaseDatos.Excel)excel).FechaHora;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.Excel)excel).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.Excel)excel).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.Excel)excel).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.Excel)excel).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.Excel)excel).FechaCreacion;
                var upd = (from exce in oBaseDatos.Excel
                              where exce.Clave == ((serTI.Campania.Modelo.BaseDatos.Excel)excel).Clave
                           select exce).First();
                upd.Nombre = item.Nombre;
                upd.Ruta = item.Ruta;
                upd.ClaveUsuarioActualizacion = item.ClaveUsuarioActualizacion;
                upd.FechaHora = item.FechaHora;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.Excel.ToList();

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
                var eli = (from emp in oBaseDatos.Excel
                           where emp.Clave == ((serTI.Campania.Modelo.BaseDatos.Excel)objetoModelo).Clave
                           select emp).First();

                oBaseDatos.DeleteObject(eli);
                oBaseDatos.SaveChanges();

                return ((serTI.Campania.Modelo.BaseDatos.Excel)objetoModelo).Clave;
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
                oBaseDatos.Excel.ToList().Where(i => i.Nombre.Contains(((serTI.Campania.Modelo.BaseDatos.Excel)objetoModelo).Nombre));
                oBaseDatos.SaveChanges();
                return ((serTI.Campania.Modelo.BaseDatos.Excel)objetoModelo).Clave;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> List(int Inicio, int Final)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
