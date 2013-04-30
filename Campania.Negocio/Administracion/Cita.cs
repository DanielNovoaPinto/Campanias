using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Administracion
{
    public class Cita : Campania.Modelo.BaseDatos.Cita, INegocio
    {
        private readonly serTI.Campania.AccesoDatos.Administracion.Cita dCita = new serTI.Campania.AccesoDatos.Administracion.Cita();

        #region INegocio Members

        public bool Insertar()
        {
            dCita.Insertar(this);
            return true;
        }
        public bool Actualizar()
        {
            dCita.Actualizar(this);
            return true;
        }
        public bool Eliminar()
        {
            dCita.Eliminar(this);
            return true;
        }
        public bool Consultar()
        {
            dCita.Consultar(this);
            return true;
        }

        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}

