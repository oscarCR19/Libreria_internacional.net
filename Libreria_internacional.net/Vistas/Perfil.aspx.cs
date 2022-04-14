using Libreria_internacional.net.Controladores;
using Libreria_internacional.net.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Libreria_internacional.net.Vistas
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Usuario)Session["Login"] != null)
            {
                loginActivo();
            }
            else
            {
                loginInactivo();
            }

        }


        public void loginInactivo()
        {
            btnCerrar.Attributes.Add("hidden", "hidden");
            lblUser.InnerText = "No hay usuario registrado";
            lblUser2.InnerText = "Debe ingresar sección para ver el contenido";

        }

        public void loginActivo()
        {
            Usuario usuario = (Usuario)Session["Login"];
            lblUser.InnerText = "Bienvenido " + usuario.User;
            btnCerrar.Attributes.Remove("hidden");
            divEncabezado.Attributes.Add("hidden", "hidden");
        }

        protected void btnIngresar_ServerClick(object sender, EventArgs e)
        {
            Usuarios controladorUsuarios = new Usuarios();
            Usuario usuario = new Usuario();
            usuario.User = txtUser.Value;
            usuario.Password = txtPassword.Value;

            if (controladorUsuarios.login(usuario))
            {
                Session["Login"] = usuario;
                loginActivo();
            }
            else
            {
                loginInactivo();
            }

            Response.Redirect("Perfil.aspx");
        }

        protected void btnCerrar_ServerClick(object sender, EventArgs e)
        {
            Session["Login"] = null;
            Response.Redirect("Perfil.aspx");

        }

        
    }
}