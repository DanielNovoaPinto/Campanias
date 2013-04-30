using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using serTI.Campania.Comunicacion.WCF.Usuario;

namespace serTI.Campania.Web
{  
    public partial class Acceso : System.Web.UI.Page
    {
        Boolean VarBoolean;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        UsuarioClient sUsuario = serTI.Campania.Comunicacion.WCF.UsuarioCliente.ObtenerUsuarioClient();
        Usuario1 nUsuario = new Usuario1() { Usuario1 = "", Contrasenia = "",ApellidoMaterno = "", ApellidoPaterno = "", Nombre = "", UsuarioActualizacion = "", UsuarioCreacion = "" };


        private void CargarUsuario()
        {
            nUsuario.Usuario1 = txtUsuario.Text;
            nUsuario.Contrasenia = txtContraseña.Text;
        }
        private void LLenarUsuario()
        {
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidaAcceso())
            {
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                Label3.Visible = false;
                Label3.Visible = true;
                Label3.Text = "Usuario o Contraseña incorrectos";
            }
        }
        private bool ValidaAcceso()
        {
            CargarUsuario();
            try
            {
              
            short resultado =    sUsuario.ValidarUsuario(nUsuario);

            if (resultado == 0)
                VarBoolean = true;
            else
                VarBoolean = false;

            }
            catch (Exception e)
            {
                throw (e);
            }
            return VarBoolean;
        }
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            Label3.Text = "";
        }

        
    }
}