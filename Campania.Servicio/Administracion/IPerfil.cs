//IPerfil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nPerfil = serTI.Campania.Negocio.Administracion.Perfil;

namespace serTI.Campania.Servicio.Administracion
{
  
    [ServiceContract]
    public interface IPerfil
    {
        [OperationContract]
        void Insertar(nPerfil perfil);
        [OperationContract]
        void Actualizar(nPerfil perfil);
        [OperationContract]
        void Eliminar(nPerfil perfil);
        [OperationContract]
        void Consultar(nPerfil perfil);
    }
}