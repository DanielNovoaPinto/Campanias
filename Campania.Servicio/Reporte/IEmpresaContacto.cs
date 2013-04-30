//IPerfil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nEmpresaContacto = serTI.Campania.Negocio.Reporte.EmpresaContacto;

namespace serTI.Campania.Servicio.Reporte
{
  
    [ServiceContract]
    public interface IEmpresaContacto
    {
        [OperationContract]
        void Insertar(nEmpresaContacto empresacontacto);
        [OperationContract]
        void Actualizar(nEmpresaContacto empresacontacto);
        [OperationContract]
        void Eliminar(nEmpresaContacto empresacontacto);
        [OperationContract]
        void Consultar(nEmpresaContacto empresacontacto);
    }
}