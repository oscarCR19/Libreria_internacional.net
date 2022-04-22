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
            string mensaje = Request.QueryString["mensaje"];
            if ((Usuario)Session["Login"] != null)
            {
                loginActivo();
            }
            else
            {
                loginInactivo();
            }

            if (mensaje == "Se quitó libro de favoritos" || mensaje== "Se marcó factura como entregada")
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
            lblUser2.InnerText = "Debe ingresar sección para ver el contenido";
            divEspacioTrabajo.Visible = false;

        }

        public void loginActivo()
        {
            Usuario usuario = (Usuario)Session["Login"];
            lblUser.InnerText = "Bienvenido " + usuario.User;
            btnCerrar.Attributes.Remove("hidden");
            divEncabezado.Attributes.Add("hidden", "hidden");

            
            LibrosPorCarritos librosCarro = new LibrosPorCarritos(); ;
            repLibrosCarro.DataSource = librosCarro.getListCarrito(usuario);
            repLibrosCarro.DataBind();
            lblCartCount.InnerText = librosCarro.getListCarrito(usuario).Count().ToString();

            FacturasPorUsuarios facturasPendientes = new FacturasPorUsuarios();
            List<FacturaUsuario> facturasPend = new List<FacturaUsuario>();//Nos traemos todo lo que hay en la lista de facturas por usuario
            FacturaUsuario factura =new FacturaUsuario();
            factura.Estado = "Pendiente";
            facturasPend = facturasPendientes.getFacturaCarrito(usuario,factura);
            
            
            //facturas que estan pendientes de entrega
            repfacturasPendientes.DataSource = facturasPend;
            repfacturasPendientes.DataBind();

            FacturasPorUsuarios FacturasEntregadas = new FacturasPorUsuarios();
            List<FacturaUsuario> facturasEntregadas = new List<FacturaUsuario>();//Nos traemos todo lo que hay en la lista de facturas por usuario
            FacturaUsuario factura2 = new FacturaUsuario();
            factura2.Estado = "Entregado";
            facturasEntregadas = FacturasEntregadas.getFacturaCarrito(usuario, factura2);

            //facturas que ya se entregaron
            repFacturasEntragadas.DataSource= facturasEntregadas;
            repFacturasEntragadas.DataBind();

            //favoritos
            Libros libros = new Libros();
            List<Libro> mostrarLibros = libros.ObtenerFavoritos(usuario);


            repLibrosFavoritos.DataSource = libros.ObtenerFavoritos(usuario);
            repLibrosFavoritos.DataBind();

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