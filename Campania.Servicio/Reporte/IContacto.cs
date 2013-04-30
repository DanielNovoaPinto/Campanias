//IPerfil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nContacto = serTI.Campania.Negocio.Reporte.Contacto;

namespace serTI.Campania.Servicio.Reporte
{
   
    [ServiceContract]
    public interface IContacto
    {
        [OperationContract]
        void Insertar(nContacto contacto);
        [OperationContract]
        void Actualizar(nContacto contacto);
        [OperationContract]
        void Eliminar(nContacto contacto);
        [OperationContract]
        void Consultar(nContacto contacto);
    }
}