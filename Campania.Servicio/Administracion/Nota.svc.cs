using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nNota = serTI.Campania.Negocio.Administracion.Nota;

namespace serTI.Campania.Servicio.Administracion
{
   
    public class Nota : INota
    {
        #region INota Members

        public void Insertar(nNota nota)
        {
            nota.Insertar();
        }
        public void Actualizar(nNota nota)
        {
            nota.Actualizar();
        }
        public void Eliminar(nNota nota)
        {
            nota.Eliminar();
        }
        public void Consultar(nNota nota)
        {
            nota.Consultar();
        }
        #endregion
    }
}
