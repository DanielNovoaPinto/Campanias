using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Administracion
{
    public class Pantalla : Campania.Modelo.BaseDatos.Pantalla, INegocio

    {
        private readonly serTI.Campania.AccesoDatos.Administracion.Pantalla dPantalla = new serTI.Campania.AccesoDatos.Administracion.Pantalla();

        #region INegocio Members

        public bool Insertar()
        {
            dPantalla.Insertar(this);
            return true;
        }
        public bool Actualizar()
        {
            dPantalla.Actualizar(this);
            return true;
        }
        public bool Eliminar()
        {
            dPantalla.Eliminar(this);
            return true;
        }
        public bool Consultar()
        {
            dPantalla.Consultar(this);
            return true;
        }

        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    
}
