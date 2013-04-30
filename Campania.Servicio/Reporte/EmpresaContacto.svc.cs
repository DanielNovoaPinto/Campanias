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
  
    public class EmpresaContacto : IEmpresaContacto
    {
        #region IEmpresaContacto Members

        public void Insertar(nEmpresaContacto empresacontacto)
        {
            empresacontacto.Insertar();
        }
        public void Actualizar(nEmpresaContacto empresacontacto)
        {
            empresacontacto.Actualizar();
        }
        public void Eliminar(nEmpresaContacto empresacontacto)
        {
            empresacontacto.Eliminar();
        }
        public void Consultar(nEmpresaContacto empresacontacto)
        {
            empresacontacto.Consultar();
        }
        #endregion
    }
}
