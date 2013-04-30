using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Reporte
{
    public class Contacto : serTI.Campania.Modelo.BaseDatos.Contacto, INegocio
    {
        private readonly serTI.Campania.AccesoDatos.Reporte.Contacto dContacto = new serTI.Campania.AccesoDatos.Reporte.Contacto();

        #region INegocio Members

        public bool Insertar()
        {
            dContacto.Insertar(this);
            return true;
        }
        public bool Actualizar()
        {
            dContacto.Actualizar(this);
            return true;
        }
        public bool Eliminar()
        {
            dContacto.Eliminar(this);
            return true;
        }
        public bool Consultar()
        {
            dContacto.Consultar(this);
            return true;
        }

        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
