using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Reporte
{
    public class Excel : serTI.Campania.Modelo.BaseDatos.Excel, INegocio
    {
        private readonly serTI.Campania.AccesoDatos.Reporte.Excel dExcel = new serTI.Campania.AccesoDatos.Reporte.Excel();

        #region INegocio Members

        public object Insertar()
        {
            return dExcel.Insertar(this);
        }
        public bool Actualizar()
        {
            return dExcel.Actualizar(this);
        }
        public object Eliminar()
        {
            return dExcel.Eliminar(this);
        }
        public object Consultar()
        {
            return dExcel.Consultar(this);
        }

        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
