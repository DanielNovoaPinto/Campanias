using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nContacto = serTI.Campania.Negocio.Reporte.Contacto;

namespace serTI.Campania.Servicio.Reporte
{
   
    public class Contacto : IContacto
    {
        #region IContacto Members

        public void Insertar(nContacto contacto)
        {
            contacto.Insertar();
        }
        public void Actualizar(nContacto contacto)
        {
            contacto.Actualizar();
        }
        public void Eliminar(nContacto contacto)
        {
            contacto.Eliminar();
        }
        public void Consultar(nContacto contacto)
        {
            contacto.Consultar();
        }
        #endregion
    }
}
