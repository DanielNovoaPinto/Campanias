using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nTipoCampania = serTI.Campania.Negocio.Administracion.TipoCampania;

namespace serTI.Campania.Servicio.Administracion
{
  
    public class TipoCampania : ITipoCampania
    {
        #region ITipoCampania Members

        public void Insertar(nTipoCampania tipocampania)
        {
            tipocampania.Insertar();
        }
        public void Actualizar(nTipoCampania tipocampania)
        {
            tipocampania.Actualizar();
        }
        public void Eliminar(nTipoCampania tipocampania)
        {
            tipocampania.Eliminar();
        }
        public void Consultar(nTipoCampania tipocampania)
        {
            tipocampania.Consultar();
        }
        #endregion
    }
}
