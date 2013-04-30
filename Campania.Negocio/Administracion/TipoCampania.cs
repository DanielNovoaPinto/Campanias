using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Administracion
{
    public class TipoCampania : Campania.Modelo.BaseDatos.TipoCampania, INegocio

    {
        private readonly serTI.Campania.AccesoDatos.Administracion.TipoCampania dTipoCampania = new serTI.Campania.AccesoDatos.Administracion.TipoCampania();

        #region INegocio Members

        public bool Insertar()
        {
            dTipoCampania.Insertar(this);
            return true;
        }
        public bool Actualizar()
        {
            dTipoCampania.Actualizar(this);
            return true;
        }
        public bool Eliminar()
        {
            dTipoCampania.Eliminar(this);
            return true;
        }
        public bool Consultar()
        {
            dTipoCampania.Consultar(this);
            return true;
        }

        public List<object> List()
        {
            throw new NotImplementedException();
        }

        #endregion       
    }
   }

