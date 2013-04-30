using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using serTI.Campania.Comunicacion.WCF.ImportarCliente;

namespace serTI.Campania.Web.Campania
{
    public partial class Campania : System.Web.UI.Page
    {
        ImportarClienteClient sImportarCliente = serTI.Campania.Comunicacion.WCF.ImportarClienteCliente.ObtenerImportarClienteClient();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = sImportarCliente.Listar(1, 10);
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Editar")
            {
                var index = int.Parse(  e.CommandArgument.ToString());
                var importarCliente = (List<ImportarCliente>)GridView1.DataSource;
              
                Session.Add("importarCliente", importarCliente[index]);

                Server.Transfer("../CampaniaDatos.aspx");
            }
        }
    }
}