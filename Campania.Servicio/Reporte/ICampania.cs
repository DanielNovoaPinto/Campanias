//IPerfil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nCampania = serTI.Campania.Negocio.Reporte.Campania;

namespace serTI.Campania.Servicio.Reporte
{
   
    [ServiceContract]
    public interface ICampania
    {
        [OperationContract]
        void Insertar(nCampania campania);
        [OperationContract]
        void Actualizar(nCampania campania);
        [OperationContract]
        void Eliminar(nCampania campania);
        [OperationContract]
        void Consultar(nCampania campania);
    }
}