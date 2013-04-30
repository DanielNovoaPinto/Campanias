//IPerfil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nCita = serTI.Campania.Negocio.Administracion.Cita;

namespace serTI.Campania.Servicio.Administracion
{
  
    [ServiceContract]
    public interface ICita
    {
        [OperationContract]
        void Insertar(nCita cita);
        [OperationContract]
        void Actualizar(nCita cita);
        [OperationContract]
        void Eliminar(nCita cita);
        [OperationContract]
        void Consultar(nCita cita);
    }
}