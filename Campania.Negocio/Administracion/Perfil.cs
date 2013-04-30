using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Administracion
{
    public class Perfil : Campania.Modelo.BaseDatos.Perfil, INegocio

    {
        private readonly serTI.Campania.AccesoDatos.Administracion.Perfil dPerfil = new serTI.Campania.AccesoDatos.Administracion.Perfil();

        #region INegocio Members

        public bool Insertar()
        {
            dPerfil.Insertar(this);
            return true;
        }
        public bool Actualizar()
        {
            dPerfil.Actualizar(this);
            return true;
        }
        public bool Eliminar()
        {
            dPerfil.Eliminar(this);
            return true;
        }
        public bool Consultar()
        {
            dPerfil.Consultar(this);
            return true;
        }

        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion       
    }
   }

