using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Administracion
{
    public class Nota : Campania.Modelo.BaseDatos.Nota, INegocio

    {
        private readonly serTI.Campania.AccesoDatos.Administracion.Nota dNotas = new serTI.Campania.AccesoDatos.Administracion.Nota();

        #region INegocio Members

        public bool Insertar()
        {
            dNotas.Insertar(this);
            return true;
        }
        public bool Actualizar()
        {
            dNotas.Actualizar(this);
            return true;
        }
        public bool Eliminar()
        {
            dNotas.Eliminar(this);
            return true;
        }
        public bool Consultar()
        {
            dNotas.Consultar(this);
            return true;
        }

        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}

