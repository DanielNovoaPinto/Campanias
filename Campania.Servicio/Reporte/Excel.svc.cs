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
   
    public class Excel : IExcel
    {
        #region Iexcel Members

        public long Insertar(nExcel excel)
        {
           return (long) excel.Insertar();
        }
        public bool Actualizar(nExcel excel)
        {
           return (bool) excel.Actualizar();
        }
        public object Eliminar(nExcel excel)
        {
            return (object)excel.Eliminar();
        }
        public object Consultar(nExcel excel)
        {
            return (object)excel.Consultar();
        }
        public List<object> List(int Inicio, int Final)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
