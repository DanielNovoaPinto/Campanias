//IPerfil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nPerfilPantalla = serTI.Campania.Negocio.Administracion.PerfilPantalla;

namespace serTI.Campania.Servicio.Administracion
{
   
    [ServiceContract]
    public interface IPerfilPantalla
    {
        [OperationContract]
        void Insertar(nPerfilPantalla perfilpantalla);
        [OperationContract]
        void Actualizar(nPerfilPantalla perfilpantalla);
        [OperationContract]
        void Eliminar(nPerfilPantalla perfilpantalla);
        [OperationContract]
        void Consultar(nPerfilPantalla perfilpantalla);
    }
}