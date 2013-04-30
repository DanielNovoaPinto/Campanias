using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Administracion
{
    public class PerfilPantalla : Campania.Modelo.BaseDatos.PerfilPantalla, INegocio

    {
        private readonly serTI.Campania.AccesoDatos.Administracion.PerfilPantalla dPerfilPantalla = new serTI.Campania.AccesoDatos.Administracion.PerfilPantalla();

        #region INegocio Members

        public bool Insertar()
        {
            dPerfilPantalla.Insertar(this);
            return true;
        }
        public bool Actualizar()
        {
            dPerfilPantalla.Actualizar(this);
            return true;
        }
        public bool Eliminar()
        {
            dPerfilPantalla.Eliminar(this);
            return true;
        }
        public bool Consultar()
        {
            dPerfilPantalla.Consultar(this);
            return true;
        }

        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    
}
