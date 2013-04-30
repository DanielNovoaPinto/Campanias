using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nUsuarioCampania = serTI.Campania.Negocio.Administracion.UsuarioCampania;

namespace serTI.Campania.Servicio.Administracion
{

    public class UsuarioCampania : IUsuarioCampania
    {
        #region IUsuarioCampania Members

        public void Insertar(nUsuarioCampania usuariocampania)
        {
            usuariocampania.Insertar();
        }
        public void Actualizar(nUsuarioCampania usuariocampania)
        {
            usuariocampania.Actualizar();
        }
        public void Eliminar(nUsuarioCampania usuariocampania)
        {
            usuariocampania.Eliminar();
        }
        public void Consultar(nUsuarioCampania usuariocampania)
        {
            usuariocampania.Consultar();
        }
        #endregion
    }
}
