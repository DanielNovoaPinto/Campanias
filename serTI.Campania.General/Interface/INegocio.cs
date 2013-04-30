using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serTI.Campania.General.Interface
{
    public interface INegocio
    {
        object Insertar();
        bool Actualizar();
        object Eliminar();
        object Consultar();
        object Listar(int Inicio, int Final);
    }
}
