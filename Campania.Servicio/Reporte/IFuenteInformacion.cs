//IPerfil.cs
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
   
    [ServiceContract]
    public interface IFuenteInformacion
    {
        [OperationContract]
        long Insertar(nFuenteInformacion fuenteinformacion);
        [OperationContract]
        bool Actualizar(nFuenteInformacion fuenteinformacion);
        [OperationContract]
        object Eliminar(nFuenteInformacion fuenteinformacion);
        [OperationContract]
        object Consultar(nFuenteInformacion fuenteinformacion);
        [OperationContract]
        List<mFuenteInformacion> Listar(int Inicio, int Final);
    }
}