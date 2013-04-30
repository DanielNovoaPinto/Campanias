
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
  
    [ServiceContract]
    public interface IArchivo
    {
        [OperationContract]
        long Insertar(nArchivo archivo);
        [OperationContract]
        bool Actualizar(nArchivo archivo);
        [OperationContract]
        object Eliminar(nArchivo archivo);
        [OperationContract]
        object Consultar(nArchivo archivo);
        [OperationContract]
        List<mArchivo> Listar(int Inicio, int Final);
        
    }
}