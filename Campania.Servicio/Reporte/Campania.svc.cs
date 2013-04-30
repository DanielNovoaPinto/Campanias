using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nCampania = serTI.Campania.Negocio.Reporte.Campania;

namespace serTI.Campania.Servicio.Reporte
{
   
    public class Campania : ICampania
    {
        #region ICampania Members

        public void Insertar(nCampania campania)
        {
            campania.Insertar();
        }
        public void Actualizar(nCampania campania)
        {
            campania.Actualizar();
        }
        public void Eliminar(nCampania campania)
        {
            campania.Eliminar();
        }
        public void Consultar(nCampania campania)
        {
            campania.Consultar();
        }
        #endregion
    }
}
