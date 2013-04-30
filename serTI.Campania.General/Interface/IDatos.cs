using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serTI.Campania.General.Interface
{
    public interface IDatos
    {
        object Insertar(object objetoModelo);
        bool Actualizar(object objetoModelo);
        object Eliminar(object objetoModelo);
        object Consultar(object objetoModelo);
        Object Listar(int Inicio, int Final);

    }
}
