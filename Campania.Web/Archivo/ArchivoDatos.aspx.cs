using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using serTI.Campania.Comunicacion.WCF.Archivo;
using serTI.Campania.Comunicacion.WCF.FuenteInformacion;
using System.Data;
using serTI.Campania.Comunicacion.WCF;

namespace serTI.Campania.Web.Archivo
{
    public partial class ArchivoDatos : System.Web.UI.Page
    {
        
        ArchivoClient sArchivo = serTI.Campania.Comunicacion.WCF.ArchivoCliente.ObtenerArchivoClient();
        Archivo1 nArchivo = new Archivo1() { Archivo1 = "", Descripcion = "", UsuarioActualizacion = "", UsuarioCreacion = "", ClaveFuenteInformacion = 0};
        FuenteInformacionClient sfuenteinformacion = serTI.Campania.Comunicacion.WCF.FuenteInformacionCliente.ObtenerFuenteInformacionClient();

        private void CargarUsuario()
        {
        }
        private void LLenarUsuario()
        {
            //var temp = (Comunicacion.WCF.FuenteInformacion.FuenteInformacion)Session["fuenteinformacion"];
            //Session.Remove("fuenteinformacion");
            //nArchivo.ClaveFuenteInformacion = temp.Clave;
            nArchivo.ClaveFuenteInformacion = (int)(Session["Clave"]);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            LLenarUsuario();

                
                //try
                //{


                    GridView1.DataSource = sArchivo.Consultar(nArchivo);
                    GridView1.DataBind();
                //}
                //catch (Exception)
                //{
                //    Label1.Text = "algo salio mal :(";
                //}
            
        }   
    }
}