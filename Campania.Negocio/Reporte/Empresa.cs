using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Reporte
{
    public class Empresa : serTI.Campania.Modelo.BaseDatos.Empresa, INegocio
    {
        private readonly serTI.Campania.AccesoDatos.Reporte.Empresa dEmpresa = new serTI.Campania.AccesoDatos.Reporte.Empresa();

        #region INegocio Members

        public bool Insertar()
        {
            dEmpresa.Insertar(this);
            return true;
        }
        public bool Actualizar()
        {
            dEmpresa.Actualizar(this);
            return true;
        }
        public bool Eliminar()
        {
            dEmpresa.Eliminar(this);
            return true;
        }
        public bool Consultar()
        {
            dEmpresa.Consultar(this);
            return true;
        }

        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
