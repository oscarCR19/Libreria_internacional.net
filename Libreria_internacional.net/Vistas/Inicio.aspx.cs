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
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string session = Request.QueryString["session"];
            string mensaje = Request.QueryString["mensaje"];
            if (session == null)
            {
                loginInactivo();
            }
            if ((Usuario)Session["Login"] != null)
            {
                loginActivo();
            }

            Libros libros = new Libros();
            List <Libro> mostrarLibros= libros.obtenerLibros();
            

            repLibros.DataSource = libros.obtenerLibros();
            repLibros.DataBind();

            repLibros2.DataSource = libros.obtenerLibros();
            repLibros2.DataBind();

            

            if (mensaje== "Se agregó al carrito con éxito")
            {
                divAlert.Attributes.Add("class", "alert alert-success");
                  divAlert.Attributes.Remove("hidden");
                   lblAlert.InnerText = mensaje;
            }
            




        }

        public void loginInactivo()
        {
            btnCerrar.Attributes.Add("hidden", "hidden");
            lblUser.InnerText = "No hay usuario registrado";
            repLibros.Visible = false;
            repLibros2.Visible = true;
           


        }

        public void loginActivo()
        {
            Usuario usuario = (Usuario)Session["Login"];
            lblUser.InnerText = "Bienvenido "+ usuario.User;
            btnCerrar.Attributes.Remove("hidden");
            divEncabezado.Attributes.Add("hidden", "hidden");
            repLibros.Visible = true;
            repLibros2.Visible = false;

            LibrosPorUsuarios librosCarro = new LibrosPorUsuarios();
            repLibrosCarro.DataSource=librosCarro.getListCarrito(usuario);
            repLibrosCarro.DataBind();
            
            lblCartCount.InnerText=librosCarro.getListCarrito(usuario).Count().ToString();

            
            //manejos de fecha
            lblFecha.InnerText = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ssss"));

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
            

        }

        protected void btnCerrar_ServerClick(object sender, EventArgs e)
        {
            Session["Login"] = null;
            Response.Redirect("Inicio.aspx");
            
        }

        protected void btnComprar_ServerClick(object sender, EventArgs e)
        {
            if(Session["Login"] == null)
            {
                divAlert.Attributes.Add("class", "alert alert-danger");
                divAlert.Attributes.Remove("hidden");
                lblAlert.InnerText = "Debes de estar loguedo para poder comprar";
            }
            
        }

        protected void btnFavoritos_ServerClick(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
            {
                divAlert.Attributes.Add("class", "alert alert-danger");
                divAlert.Attributes.Remove("hidden");
                lblAlert.InnerText = "Debes de estar loguedo para poder agregar a favoritos";
                
            }

        }
    }
}