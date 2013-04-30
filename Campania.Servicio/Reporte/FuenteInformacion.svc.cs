using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nFuenteInformacion = serTI.Campania.Negocio.Reporte.FuenteInformacion;
using mFuenteInformacion = serTI.Campania.Modelo.BaseDatos.FuenteInformacion;

namespace serTI.Campania.Servicio.Reporte
{
   
    public class FuenteInformacion : IFuenteInformacion
    {
        #region IFuenteInformacion Members

        public long Insertar(nFuenteInformacion fuenteinformacion)
        {
            return (long) fuenteinformacion.Insertar();
        }
        public bool Actualizar(nFuenteInformacion fuenteinformacion)
        {
           return (bool) fuenteinformacion.Actualizar();
        }
        public object Eliminar(nFuenteInformacion fuenteinformacion)
        {
           return (object) fuenteinformacion.Eliminar();
        }
        public object Consultar(nFuenteInformacion fuenteinformacion)
        {
            return (object)fuenteinformacion.Consultar();
        }
        public List<mFuenteInformacion> Listar(int Inicio, int Final)
        {
            nFuenteInformacion fuenteinformacion = new nFuenteInformacion();
            return (List<mFuenteInformacion>)fuenteinformacion.Listar(Inicio, Final);
        }
        #endregion
    }
}
