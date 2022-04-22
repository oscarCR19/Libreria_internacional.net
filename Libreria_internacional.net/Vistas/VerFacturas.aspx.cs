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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pais = Request.QueryString["pais"];
            string provincia = Request.QueryString["provincia"];
            string direccion = Request.QueryString["direccion"];
            string codigoPortal = Request.QueryString["codigoPortal"];
            string numTarjeta = Request.QueryString["numTarjeta"];
            string fechaExp = Request.QueryString["fechaExp"];
            string foto = Request.QueryString["foto"];
            string titulo = Request.QueryString["titulo"];
            string autor = Request.QueryString["autor"];
            string precio = Request.QueryString["precio"];
            string fecha = Request.QueryString["fechaEmision"];
            Usuario usuario = (Usuario)Session["Login"];

            Usuarios email = new Usuarios();
            lblUsuario.InnerText = usuario.User;
            lblEmail.InnerText = email.getEmail(usuario).Email.ToString();
            lblPais.InnerText = pais;
            lblProvincia.InnerText = provincia;
            lblDirrecion.InnerText = direccion;
            lblCodigoPostal.InnerText = codigoPortal;
            lblNumTarjeta.InnerText = numTarjeta;
            lblFechaExp.InnerText = fechaExp;
            imgLibro.Src = foto;
            lblTitulo.InnerText = titulo;
            lblAutor.InnerText = autor;
            lblPrecio.InnerText = precio;
            lblFechaEntrega.InnerText = fecha;


        }

        protected void btnRegresar_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Perfil.aspx");
        }
    }
}