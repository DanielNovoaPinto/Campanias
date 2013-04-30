using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Administracion
{
    public class Archivo : Campania.Modelo.BaseDatos.Archivo, INegocio

    {
        private readonly serTI.Campania.AccesoDatos.Administracion.Archivo dArchivo = new serTI.Campania.AccesoDatos.Administracion.Archivo();

        #region INegocio Members

        public object Insertar()
        {
                   return dArchivo.Insertar(this);
        }
        public bool Actualizar()
        {
            return dArchivo.Actualizar(this);
        }
        public object Eliminar()
        {
            return dArchivo.Eliminar(this);
        }
        public object Consultar()
        {
            return dArchivo.Consultar(this);
        }
        public object Listar(int Inicio, int Final)
        {
            return dArchivo.Listar(Inicio, Final);
        }
     #endregion
    }
    
}
