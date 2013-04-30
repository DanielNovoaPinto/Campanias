//IPerfil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nImportarCliente = serTI.Campania.Negocio.Reporte.ImportarCliente;
using mImportarCliente = serTI.Campania.Modelo.BaseDatos.ImportarCliente;

namespace serTI.Campania.Servicio.Reporte
{
    
    [ServiceContract]
    public interface IImportarCliente
    {
        [OperationContract]
        long Insertar(nImportarCliente importarcliente);
        [OperationContract]
        bool Actualizar(nImportarCliente importarcliente);
        [OperationContract]
        object Eliminar(nImportarCliente importarcliente);
        [OperationContract]
        object Consultar(nImportarCliente importarcliente);
        [OperationContract]
        List<mImportarCliente> Listar(int Inicio, int Final);
    }
}