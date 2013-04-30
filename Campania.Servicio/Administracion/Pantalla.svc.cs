using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nPantalla = serTI.Campania.Negocio.Administracion.Pantalla;

namespace serTI.Campania.Servicio.Administracion
{
    
    public class Pantalla : IPantalla
    {
        #region IPantalla Members

        public void Insertar(nPantalla pantalla)
        {
            pantalla.Insertar();
        }
        public void Actualizar(nPantalla pantalla)
        {
            pantalla.Actualizar();
        }
        public void Eliminar(nPantalla pantalla)
        {
            pantalla.Eliminar();
        }
        public void Consultar(nPantalla pantalla)
        {
            pantalla.Consultar();
        }
        #endregion
    }
}
