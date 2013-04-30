using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nPerfil = serTI.Campania.Negocio.Administracion.Perfil;

namespace serTI.Campania.Servicio.Administracion
{
   
    public class Perfil : IPerfil
    {
        #region IPerfil Members

        public void Insertar(nPerfil perfil)
        {
            perfil.Insertar();
        }
        public void Actualizar(nPerfil perfil)
        {
            perfil.Actualizar();
        }
        public void Eliminar(nPerfil perfil)
        {
            perfil.Eliminar();
        }
        public void Consultar(nPerfil perfil)
        {
            perfil.Consultar();
        }
        #endregion
    }
}
