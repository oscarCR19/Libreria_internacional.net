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
            string isnb = Request.QueryString["isnb"];
            string titulo = Request.QueryString["titulo"];
            string autor = Request.QueryString["autor"];
            string precio = Request.QueryString["precio"];
           Usuario usuario = (Usuario)Session["Login"];

            LibrosPorUsuarios factura = new LibrosPorUsuarios();
            factura.setListCarrito(isnb,titulo,autor,Convert.ToDouble(precio),usuario.User);
            Response.Redirect("Inicio.aspx?mensaje=Se agregó al carrito con éxito");

        }
    }
}