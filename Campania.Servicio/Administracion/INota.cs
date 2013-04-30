//IPerfil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using nNota = serTI.Campania.Negocio.Administracion.Nota;

namespace serTI.Campania.Servicio.Administracion
{
 
    [ServiceContract]
    public interface INota
    {
        [OperationContract]
        void Insertar(nNota nota);
        [OperationContract]
        void Actualizar(nNota nota);
        [OperationContract]
        void Eliminar(nNota nota);
        [OperationContract]
        void Consultar(nNota nota);
    }
}