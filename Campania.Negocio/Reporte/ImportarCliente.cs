using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Reporte
{
    public class ImportarCliente : serTI.Campania.Modelo.BaseDatos.ImportarCliente, INegocio
    {
        private readonly serTI.Campania.AccesoDatos.Reporte.ImportarCliente dImportarCliente = new serTI.Campania.AccesoDatos.Reporte.ImportarCliente();

        #region INegocio Members

        public Object Insertar()
        {
           return dImportarCliente.Insertar(this);
            
        }
        public bool Actualizar()
        {
          return dImportarCliente.Actualizar(this);
        }
        public Object Eliminar()
        {
            return dImportarCliente.Eliminar(this);
        }
        public Object Consultar()
        {
            return dImportarCliente.Consultar(this);
        }

        public object Listar(int Inicio, int Final)
        {
            return dImportarCliente.Listar(Inicio, Final);
        }


        #endregion
    }

}
