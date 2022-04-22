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
            List<Libro> mostrarLibros = libros.obtenerLibros();


            repLibros.DataSource = libros.obtenerLibros();
            repLibros.DataBind();

            repLibros2.DataSource = libros.obtenerLibros();
            repLibros2.DataBind();



            if (mensaje == "Se agregó al carrito con éxito" || mensaje == "Libro se agregó a favoritos" || mensaje == "Compra realizada con éxito")
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
            repLibros3.Visible = false;
            divBusqueda.Visible = false;




        }

        public void loginActivo()
        {
            Usuario usuario = (Usuario)Session["Login"];
            lblUser.InnerText = "Bienvenido " + usuario.User;
            btnCerrar.Attributes.Remove("hidden");
            divEncabezado.Attributes.Add("hidden", "hidden");
            repLibros.Visible = true;
            repLibros2.Visible = false;
            LibrosPorCarritos librosCarro = new LibrosPorCarritos();
            repLibrosCarro.DataSource = librosCarro.getListCarrito(usuario);
            repLibrosCarro.DataBind();

            lblCartCount.InnerText = librosCarro.getListCarrito(usuario).Count().ToString();
            divBusqueda.Visible = true;



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
                divAlert2.Attributes.Remove("hidden");
                divAlert2.Attributes.Add("class", "alert alert-danger");
                lblAlert2.InnerText = "Error en los datos ingresados";
            }


        }

        protected void btnCerrar_ServerClick(object sender, EventArgs e)
        {
            Session["Login"] = null;
            Response.Redirect("Inicio.aspx");

        }

        protected void btnComprar_ServerClick(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
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

        protected void btnRegistrar_ServerClick(object sender, EventArgs e)
        {
            Usuarios registroUsuarios = new Usuarios();
            Usuario usuario = new Usuario()
            {
                User = textUsuario.Value,
                Password = textContrasena.Value,
                Email = textEmail.Value

            };




            if (registroUsuarios.Registrar(usuario) == true)
            {
                divAlert2.Attributes.Add("class", "alert alert-success");
                divAlert2.Attributes.Remove("hidden");
                lblAlert2.InnerText = "El usuario fue registrado con éxito";

            }
            else
            {
                divAlert2.Attributes.Remove("hidden");
                divAlert2.Attributes.Add("class", "alert alert-danger");
                lblAlert2.InnerText = "No se pudo registrar usuario";




            }

            textUsuario.Value = "";
            textContrasena.Value = "";
            textEmail.Value = "";


        }

        protected void btnBuscar_ServerClick(object sender, EventArgs e)
        {
            repLibros.Visible = false;
            repLibros2.Visible = false;
            repLibros3.Visible = true;
            Libros libros = new Libros();
            Libro libro=new Libro();
            libro.ISBN = inputBusqueda.Value;
            libro.Titulo = inputBusqueda.Value;
            List<Libro> mostrarLibros = libros.obtenerBusqueda(libro);
            repLibros3.DataSource = mostrarLibros;
            repLibros3.DataBind();



        }
    }
}