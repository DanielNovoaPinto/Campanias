using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nArchivo = serTI.Campania.Negocio.Administracion.Archivo;
using mArchivo = serTI.Campania.Modelo.BaseDatos.Archivo;

namespace serTI.Campania.Servicio.Administracion
{
   
    public class Archivo : IArchivo
    {
        #region IArchivo Members

        public long Insertar(nArchivo archivo)
        {
            return (long)archivo.Insertar();
        }
        public bool Actualizar(nArchivo archivo)
        {
            return (bool)archivo.Actualizar();
        }
        public object Eliminar(nArchivo archivo)
        {
            return (object)archivo.Eliminar();
        }
        public object Consultar(nArchivo archivo)
        {
            return (object)archivo.Consultar();
        }

        public List<mArchivo> Listar(int Inicio, int Final)
        {
            nArchivo archivo = new nArchivo();
            return (List<mArchivo>)archivo.Listar(Inicio, Final);
        }
      #endregion
    }
}
