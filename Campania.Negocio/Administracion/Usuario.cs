using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.General.Interface;

namespace serTI.Campania.Negocio.Administracion
{
    public class Usuario : Campania.Modelo.BaseDatos.Usuario, INegocio

    {
        
        private readonly serTI.Campania.AccesoDatos.Administracion.Usuario dUsuario = new serTI.Campania.AccesoDatos.Administracion.Usuario();

        #region INegocio Members

        public object Insertar()
        {
            return  dUsuario.Insertar(this);   
        }
        public bool Actualizar()
        {
           return dUsuario.Actualizar(this);
        }
        public object Eliminar()
        {
            return dUsuario.Eliminar(this);
        }
        public object Consultar()
        {
           return dUsuario.Consultar(this);
        }
        public short ValidarUsuario()
        {
            return dUsuario.ValidarUsuario(this);
        }
        public object Listar(int Inicio, int Final)
        {
          return   dUsuario.Listar(Inicio, Final);
        }

        #endregion
    }
    
}
