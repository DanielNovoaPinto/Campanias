//IPerfil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nImportarClienteContacto = serTI.Campania.Negocio.Reporte.ImportarClienteContacto;

namespace serTI.Campania.Servicio.Reporte
{
  
    [ServiceContract]
    public interface IImportarClienteContacto
    {
        [OperationContract]
        void Insertar(nImportarClienteContacto empresacontacto);
        [OperationContract]
        void Actualizar(nImportarClienteContacto empresacontacto);
        [OperationContract]
        void Eliminar(nImportarClienteContacto empresacontacto);
        [OperationContract]
        void Consultar(nImportarClienteContacto empresacontacto);
    }
}