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
   
    public class ImportarCliente : IImportarCliente
    {
        #region IImportarCliente Members

        public long Insertar(nImportarCliente importarcliente)
        {
            return (long)importarcliente.Insertar();
        }
        public bool Actualizar(nImportarCliente importarcliente)
        {
            return (bool)importarcliente.Actualizar();
        }
        public object Eliminar(nImportarCliente importarcliente)
        {
            return (object) importarcliente.Eliminar();
        }
        public object Consultar(nImportarCliente importarcliente)
        {
            return (object)importarcliente.Consultar();
        }
        public List<mImportarCliente> Listar(int Inicio, int Final)
        {
            nImportarCliente importarcliente = new nImportarCliente();
            return (List<mImportarCliente>)importarcliente.Listar(Inicio, Final);
        }
        #endregion
    }
}
