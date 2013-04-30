using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Modelo.BaseDatos;
using serTI.Campania.General.Interface;

namespace serTI.Campania.AccesoDatos.Administracion
{
   public class Archivo : serTI.Campania.Modelo.BaseDatos.Archivo, IDatos
    {
        private readonly CampaniaEntidades oBaseDatos = new CampaniaEntidades();

        #region IDatos Members

        public object Insertar(object archivo)
        {
            try
            {

                oBaseDatos.AddToArchivo((serTI.Campania.Modelo.BaseDatos.Archivo)archivo);
                oBaseDatos.SaveChanges();
                return ((serTI.Campania.Modelo.BaseDatos.Archivo)archivo).Clave;
            }
            catch (Exception)
            {
                return 0;

            }
        }
        public bool Actualizar(object archivo)
        {
            try
            {

                var item = new serTI.Campania.Modelo.BaseDatos.Archivo();
                item.Descripcion = ((serTI.Campania.Modelo.BaseDatos.Archivo)archivo).Descripcion;
                item.Archivo1 = ((serTI.Campania.Modelo.BaseDatos.Archivo)archivo).Archivo1;
                item.ClaveFuenteInformacion = ((serTI.Campania.Modelo.BaseDatos.Archivo)archivo).ClaveFuenteInformacion;
                item.Estatus = ((serTI.Campania.Modelo.BaseDatos.Archivo)archivo).Estatus;
                item.UsuarioActualizacion = ((serTI.Campania.Modelo.BaseDatos.Archivo)archivo).UsuarioActualizacion;
                item.FechaActualizacion = ((serTI.Campania.Modelo.BaseDatos.Archivo)archivo).FechaActualizacion;
                item.UsuarioCreacion = ((serTI.Campania.Modelo.BaseDatos.Archivo)archivo).UsuarioCreacion;
                item.FechaCreacion = ((serTI.Campania.Modelo.BaseDatos.Archivo)archivo).FechaCreacion;
                var upd = (from arc in oBaseDatos.Archivo
                              where arc.Archivo1 == ((serTI.Campania.Modelo.BaseDatos.Archivo)archivo).Archivo1
                           select arc).First();
                upd.Descripcion = item.Descripcion;
                upd.Archivo1 = item.Archivo1;
                upd.ClaveFuenteInformacion = item.ClaveFuenteInformacion;
                upd.Estatus = item.Estatus;
                upd.UsuarioActualizacion = item.UsuarioActualizacion;
                upd.FechaActualizacion = item.FechaActualizacion;
                upd.UsuarioCreacion = item.UsuarioCreacion;
                upd.FechaCreacion = item.FechaCreacion;
                oBaseDatos.SaveChanges();
                oBaseDatos.Archivo.ToList();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Eliminar(object archivo)
        {
            try
            {
                var eli = (from arc in oBaseDatos.Archivo
                                   where arc.Clave == ((serTI.Campania.Modelo.BaseDatos.Archivo)archivo).Clave
                           select arc).First();

                oBaseDatos.DeleteObject(eli);
                oBaseDatos.SaveChanges();

                return ((serTI.Campania.Modelo.BaseDatos.Archivo)archivo).Clave;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Consultar(object archivo)
        {
            var arc = (serTI.Campania.Modelo.BaseDatos.Archivo)archivo;
            try
            {
                var Con = (from a in oBaseDatos.Archivo
                           where a.ClaveFuenteInformacion == arc.ClaveFuenteInformacion
                           select a).First();

                return oBaseDatos.Archivo;
                //var Con = (from a in oBaseDatos.Archivo
                //           where a.Clave == arc.Clave
                //           select a).First();
                //return Con;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public object Listar(int Inicio, int Final)
        {
            return oBaseDatos.Archivo.ToList();
        }

        #endregion





    }
}
