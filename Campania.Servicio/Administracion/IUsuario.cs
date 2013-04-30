//IPerfil.cs
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
    
    [ServiceContract]
    public interface IUsuario
    {
        [OperationContract]
        long Insertar(nUsuario usuario);
        [OperationContract]
        bool Actualizar(nUsuario usuario);
        [OperationContract]
        object Eliminar(nUsuario usuario);
        [OperationContract]
        object Consultar(nUsuario usuario);
        [OperationContract]
        short ValidarUsuario(nUsuario usuario);
        [OperationContract]
        List<mUsuario> Listar(int Inicio, int Final);
    }
}