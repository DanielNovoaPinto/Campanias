using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Reporte
{
    public class FuenteInformacion : serTI.Campania.Modelo.BaseDatos.FuenteInformacion, INegocio
    {
        private readonly serTI.Campania.AccesoDatos.Reporte.FuenteInformacion dFuenteInformacion = new serTI.Campania.AccesoDatos.Reporte.FuenteInformacion();

        #region INegocio Members

        public object Insertar()
        {
            return dFuenteInformacion.Insertar(this);
            
        }
        public bool Actualizar()
        {
            return dFuenteInformacion.Actualizar(this);
            
        }
        public Object Eliminar()
        {
            return dFuenteInformacion.Eliminar(this);
            
        }
        public Object Consultar()
        {
            return dFuenteInformacion.Consultar(this);
        }

        public object Listar(int Inicio, int Final)
        {
            return dFuenteInformacion.Listar(Inicio, Final);
        }

        #endregion
    }

}
