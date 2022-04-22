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
    public partial class AgregarFavoritos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string accion = Request.QueryString["accion"];
            string isbn = Request.QueryString["isbn"];
            Libro libro = new Libro();
            libro.ISBN=isbn;
            Usuario usuario = (Usuario)Session["Login"];
            Libros ingresarFavorito = new Libros();
            if (accion == "poner")
            {
                ingresarFavorito.SetFavoritos(libro, usuario);
                Response.Redirect("Inicio.aspx?mensaje=Libro se agregó a favoritos");

            }
            if (accion == "quitar")
            {
                ingresarFavorito.QuitarFavoritps(libro, usuario);
                Response.Redirect("Perfil.aspx?mensaje=Se quitó libro de favoritos");
            }



        }
    }
}