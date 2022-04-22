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
    public partial class AgregarCarrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string accion = Request.QueryString["accion"];
            int id = Convert.ToInt32(Request.QueryString["id"]);
            string sitio = Request.QueryString["sitio"];
            string isnb = Request.QueryString["isnb"];
            string titulo = Request.QueryString["titulo"];
            string autor = Request.QueryString["autor"];
            string precio = Request.QueryString["precio"];
            string foto = Request.QueryString["foto"];
            Usuario usuario = (Usuario)Session["Login"];
            Usuarios email=new Usuarios();
            if (accion == "borraCarrito")
            {
                LibrosPorCarritos borrar = new LibrosPorCarritos();
                borrar.quitarLibroCarrito(id);
                Response.Redirect(sitio);
            }
            else
            {
                LibrosPorCarritos factura = new LibrosPorCarritos();
                LibroPorCarrito libro = new LibroPorCarrito()
                {
                    ISBN = isnb,
                    Titulo = titulo,
                    Autor = autor,
                    Precio = Convert.ToDouble(precio),
                    Foto = foto,
                    Email = email.getEmail(usuario).ToString(),
                    Estado = "Pago Pendiente"
                };

                factura.setListCarrito(libro, usuario);
                Response.Redirect("Inicio.aspx?mensaje=Se agregó al carrito con éxito");
            }

            

            

           
            

        }
    }
}