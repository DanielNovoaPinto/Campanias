using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nPerfilPantalla = serTI.Campania.Negocio.Administracion.PerfilPantalla;

namespace serTI.Campania.Servicio.Administracion
{
  
    public class PerfilPantalla : IPerfilPantalla
    {
        #region IPerfilPantalla Members

        public void Insertar(nPerfilPantalla perfilpantalla)
        {
            perfilpantalla.Insertar();
        }
        public void Actualizar(nPerfilPantalla perfilpantalla)
        {
            perfilpantalla.Actualizar();
        }
        public void Eliminar(nPerfilPantalla perfilpantalla)
        {
            perfilpantalla.Eliminar();
        }
        public void Consultar(nPerfilPantalla perfilpantalla)
        {
            perfilpantalla.Consultar();
        }
        #endregion
    }
}
