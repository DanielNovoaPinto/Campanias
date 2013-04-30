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
    
    public class Empresa : IEmpresa
    {
        #region IEmpresa Members

        public void Insertar(nEmpresa empresa)
        {
            empresa.Insertar();
        }
        public void Actualizar(nEmpresa empresa)
        {
            empresa.Actualizar();
        }
        public void Eliminar(nEmpresa empresa)
        {
            empresa.Eliminar();
        }
        public void Consultar(nEmpresa empresa)
        {
            empresa.Consultar();
        }
        #endregion
    }
}
