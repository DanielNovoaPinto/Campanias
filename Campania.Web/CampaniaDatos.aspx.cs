using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using serTI.Campania.Comunicacion.WCF.FuenteInformacion;
using serTI.Campania.Comunicacion.WCF.ImportarCliente;


namespace serTI.Campania.Web
{
    public partial class CampaniaDatos : System.Web.UI.Page
    {
        FuenteInformacionClient sfuenteinformacion = serTI.Campania.Comunicacion.WCF.FuenteInformacionCliente.ObtenerFuenteInformacionClient();
        ImportarClienteClient sImportarCliente = serTI.Campania.Comunicacion.WCF.ImportarClienteCliente.ObtenerImportarClienteClient();
        ImportarCliente1 nimportarcliente = new ImportarCliente1() { Nombre = "", Direccion = "", Contacto = "", Email = "" };


        private void CargarUsuario()
        {
            nimportarcliente.Clave = int.Parse(lblClave.Text);
            nimportarcliente.Nombre = txtNombre.Text;
            nimportarcliente.Direccion = txtDireccion.Text;
            nimportarcliente.Contacto = txtContacto.Text;
            nimportarcliente.Email = txtEmail.Text;
            nimportarcliente.Telefono = int.Parse(txtTelefono.Text);
            nimportarcliente.FechaHora = DateTime.Parse(txtFechaHora.Text);
            nimportarcliente.ClaveExcel = int.Parse(lblClaveExcel.Text);
        }
        private void LLenarUsuario()
        {
            var temp = (Comunicacion.WCF.ImportarCliente.ImportarCliente)Session["importarCliente"];
            Session.Remove("importarCliente");
            lblClave.Text = temp.Clave.ToString();
            txtNombre.Text = temp.Nombre;
            txtDireccion.Text = temp.Direccion;
            txtContacto.Text = temp.Contacto;
            txtEmail.Text = temp.Email;
            txtTelefono.Text = temp.Telefono.ToString();
            txtFechaHora.Text = temp.FechaHora.ToString();
            lblClaveExcel.Text = temp.ClaveExcel.ToString();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LLenarUsuario();
                GridView1.DataSource = sfuenteinformacion.Listar(1, 10);
                GridView1.DataBind();
            }


        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            CargarUsuario();
            sImportarCliente.Actualizar(nimportarcliente);
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                GridView1.DataSource = sfuenteinformacion.Listar(1, 10);
                GridView1.DataBind();
                var index = int.Parse(e.CommandArgument.ToString());
                var fuenteinformacion = (List<FuenteInformacion>)GridView1.DataSource;
                var a = fuenteinformacion[index];
                int clave = (int)a.Clave;
                Session.Add("Clave", clave);
                //var index = int.Parse(e.CommandArgument.ToString());
                //var fuenteinformacion = (List<FuenteInformacion>)GridView1.DataSource;

                //Session.Add("fuenteinformacion", fuenteinformacion[index]);
                Server.Transfer("Archivo/ArchivoDatos.aspx");
            }

        }


    }
}