//IPerfil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nTipoCampania = serTI.Campania.Negocio.Administracion.TipoCampania;

namespace serTI.Campania.Servicio.Administracion
{
  
    [ServiceContract]
    public interface ITipoCampania
    {
        [OperationContract]
        void Insertar(nTipoCampania tipocampania);
        [OperationContract]
        void Actualizar(nTipoCampania tipocampania);
        [OperationContract]
        void Eliminar(nTipoCampania tipocampania);
        [OperationContract]
        void Consultar(nTipoCampania tipocampania);
    }
}