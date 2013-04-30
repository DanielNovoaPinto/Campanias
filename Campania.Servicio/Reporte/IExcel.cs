//IPerfil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nExcel = serTI.Campania.Negocio.Reporte.Excel;

namespace serTI.Campania.Servicio.Reporte
{
   
    [ServiceContract]
    public interface IExcel
    {
        [OperationContract]
        long Insertar(nExcel excel);
        [OperationContract]
        bool Actualizar(nExcel excel);
        [OperationContract]
        object Eliminar(nExcel excel);
        [OperationContract]
        object Consultar(nExcel excel);
        [OperationContract]
        List<Object> List(int Inicio, int Final);
    }
}