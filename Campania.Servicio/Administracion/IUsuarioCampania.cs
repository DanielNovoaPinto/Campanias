using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nUsuarioCampania = serTI.Campania.Negocio.Administracion.UsuarioCampania;

namespace serTI.Campania.Servicio.Administracion
{

    [ServiceContract]
    public interface IUsuarioCampania
    {
        [OperationContract]
        void Insertar(nUsuarioCampania usuariocampania);
        [OperationContract]
        void Actualizar(nUsuarioCampania usuariocampania);
        [OperationContract]
        void Eliminar(nUsuarioCampania usuariocampania);
        [OperationContract]
        void Consultar(nUsuarioCampania usuariocampania);
    }
}