using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Reporte
{
    public class Campania : serTI.Campania.Modelo.BaseDatos.Campania, INegocio
    {
        private readonly serTI.Campania.AccesoDatos.Reporte.Campania dCampania = new serTI.Campania.AccesoDatos.Reporte.Campania();

        #region INegocio Members

        public bool Insertar()
        {
            dCampania.Insertar(this);
            return true;
        }
        public bool Actualizar()
        {
            dCampania.Actualizar(this);
            return true;
        }
        public bool Eliminar()
        {
            dCampania.Eliminar(this);
            return true;
        }
        public bool Consultar()
        {
            dCampania.Consultar(this);
            return true;
        }

        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
