using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serTI.Campania.Comunicacion.WCF.Archivo;

using serTI.Campania.Comunicacion.WCF.FuenteInformacion;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            serTI.Campania.AccesoDatos.Administracion.Archivo archivo = new serTI.Campania.AccesoDatos.Administracion.Archivo();
            
            //Program nArchivo = new Program() {Desc="",sdasd=""};

            //nArchivo.Desc = "este es un archivo de word";
            //archivo.Consultar(nArchivo);


        }



        public string sdasd { get; set; }

        public string Desc { get; set; }
    }
}
