using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nUsuario = serTI.Campania.Negocio.Administracion.Usuario;
using mUsuario = serTI.Campania.Modelo.BaseDatos.Usuario;

namespace serTI.Campania.Servicio.Administracion
{
   
    public class Usuario : IUsuario
    {
        #region IUsuario Members

        public long Insertar(nUsuario usuario)
        {
            return (long)usuario.Insertar();
        }
        public bool Actualizar(nUsuario usuario)
        {
           return (bool)usuario.Actualizar();
        }
        public object Eliminar(nUsuario usuario)
        {
           return (object) usuario.Eliminar();
        }
        public object Consultar(nUsuario usuario)
        {
            return (object)usuario.Consultar();
        }

        public short ValidarUsuario(nUsuario usuario)
        {
            return usuario.ValidarUsuario();
        }
        public List<mUsuario> Listar(int Inicio, int Final)
        {
            nUsuario usuario= new nUsuario();
            return (List<mUsuario>)usuario.Listar(Inicio, Final);
        }
        #endregion
    }
}
