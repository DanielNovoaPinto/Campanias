using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nCita = serTI.Campania.Negocio.Administracion.Cita;

namespace serTI.Campania.Servicio.Administracion
{
   
    public class Cita : ICita
    {
        #region ICita Members

        public void Insertar(nCita cita)
        {
            cita.Insertar();
        }
        public void Actualizar(nCita cita)
        {
            cita.Actualizar();
        }
        public void Eliminar(nCita cita)
        {
            cita.Eliminar();
        }
        public void Consultar(nCita cita)
        {
            cita.Consultar();
        }
        #endregion
    }
}
