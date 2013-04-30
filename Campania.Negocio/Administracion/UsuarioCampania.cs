using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Administracion
{
    public class UsuarioCampania : serTI.Campania.Modelo.BaseDatos.UsuarioCampania, INegocio
    {
        private readonly serTI.Campania.AccesoDatos.Administracion.UsuarioCampania dUsuarioCampania = new serTI.Campania.AccesoDatos.Administracion.UsuarioCampania();

        #region INegocio Members

        public bool Insertar()
        {
            dUsuarioCampania.Insertar(this);
            return true;
        }
        public bool Actualizar()
        {
            dUsuarioCampania.Actualizar(this);
            return true;
        }
        public bool Eliminar()
        {
            dUsuarioCampania.Eliminar(this);
            return true;
        }
        public bool Consultar()
        {
            dUsuarioCampania.Consultar(this);
            return true;
        }

        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
