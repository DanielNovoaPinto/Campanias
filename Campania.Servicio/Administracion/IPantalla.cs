//IPerfil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nPantalla = serTI.Campania.Negocio.Administracion.Pantalla;

namespace serTI.Campania.Servicio.Administracion
{
  
    [ServiceContract]
    public interface IPantalla
    {
        [OperationContract]
        void Insertar(nPantalla pantalla);
        [OperationContract]
        void Actualizar(nPantalla pantalla);
        [OperationContract]
        void Eliminar(nPantalla pantalla);
        [OperationContract]
        void Consultar(nPantalla pantalla);
    }
}