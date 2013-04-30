using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Reporte
{
    public class ImportarClienteContacto : serTI.Campania.Modelo.BaseDatos.ImportarClienteContacto, INegocio
    {
        private readonly serTI.Campania.AccesoDatos.Reporte.ImportarClienteContacto dImportarClienteContacto = new serTI.Campania.AccesoDatos.Reporte.ImportarClienteContacto();

        #region INegocio Members

        public bool Insertar()
        {
            dImportarClienteContacto.Insertar(this);
            return true;
        }
        public bool Actualizar()
        {
            dImportarClienteContacto.Actualizar(this);
            return true;
        }
        public bool Eliminar()
        {
            dImportarClienteContacto.Eliminar(this);
            return true;
        }
        public bool Consultar()
        {
            dImportarClienteContacto.Consultar(this);
            return true;
        }

        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
