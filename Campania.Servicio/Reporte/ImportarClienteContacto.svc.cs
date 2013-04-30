using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nImportarClienteContacto = serTI.Campania.Negocio.Reporte.ImportarClienteContacto;

namespace serTI.Campania.Servicio.Reporte
{
    
    public class ImportarClienteContacto : IImportarClienteContacto
    {
        #region IImportarClienteContacto Members

        public void Insertar(nImportarClienteContacto importarempresacontacto)
        {
            importarempresacontacto.Insertar();
        }
        public void Actualizar(nImportarClienteContacto importarempresacontacto)
        {
            importarempresacontacto.Actualizar();
        }
        public void Eliminar(nImportarClienteContacto importarempresacontacto)
        {
            importarempresacontacto.Eliminar();
        }
        public void Consultar(nImportarClienteContacto importarempresacontacto)
        {
            importarempresacontacto.Consultar();
        }
        #endregion
    }
}
