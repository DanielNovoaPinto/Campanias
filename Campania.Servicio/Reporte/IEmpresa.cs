//IPerfil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nEmpresa = serTI.Campania.Negocio.Reporte.Empresa;

namespace serTI.Campania.Servicio.Reporte
{
   
    [ServiceContract]
    public interface IEmpresa
    {
        [OperationContract]
        void Insertar(nEmpresa empresa);
        [OperationContract]
        void Actualizar(nEmpresa empresa);
        [OperationContract]
        void Eliminar(nEmpresa empresa);
        [OperationContract]
        void Consultar(nEmpresa empresa);
    }
}