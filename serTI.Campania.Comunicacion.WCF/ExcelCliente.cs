using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Comunicacion.WCF.Archivo;
using System.ServiceModel;

namespace serTI.Campania.Comunicacion.WCF
{
    public class ExcelCliente
    {
        public static serTI.Campania.Comunicacion.WCF.Excel.ExcelClient ObtenerExcelClient()
        {
            try
            {
                //Dirección Absoluta del servicio web publico.
                string uri = serTI.Campania.Comunicacion.WCF.Core.GetServicePath("servicesPath") + "Administracion/Excel.svc";
                //Creación de Punto de acceso.
                var enpAdress = new EndpointAddress(uri);
                var cliente = new serTI.Campania.Comunicacion.WCF.Excel.ExcelClient(serTI.Campania.Comunicacion.WCF.Core.GetBinding(), enpAdress);
                cliente.Open();
                return cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
