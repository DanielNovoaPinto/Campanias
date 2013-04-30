using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Reporte
{
    public class EmpresaContacto : serTI.Campania.Modelo.BaseDatos.EmpresaContacto, INegocio
    {
        private readonly serTI.Campania.AccesoDatos.Reporte.EmpresaContacto dEmpresaContacto = new serTI.Campania.AccesoDatos.Reporte.EmpresaContacto();

        #region INegocio Members

        public bool Insertar()
        {
            dEmpresaContacto.Insertar(this);
            return true;
        }
        public bool Actualizar()
        {
            dEmpresaContacto.Actualizar(this);
            return true;
        }
        public bool Eliminar()
        {
            dEmpresaContacto.Eliminar(this);
            return true;
        }
        public bool Consultar()
        {
            dEmpresaContacto.Consultar(this);
            return true;
        }

        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
