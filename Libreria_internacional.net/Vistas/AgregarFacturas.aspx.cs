using Libreria_internacional.net.Controladores;
using Libreria_internacional.net.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Libreria_internacional.net.Vistas
{
    public partial class AgregarFacturas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string accion = Request.QueryString["accion"];
            string id = Request.QueryString["id"];
            string titulo = Request.QueryString["titulo"];
            string autor = Request.QueryString["autor"];
            string precio = Request.QueryString["precio"];
            string foto = Request.QueryString["foto"];
            Usuario usuario = (Usuario)Session["Login"];

            

            // esto es para invocar el metodo para devolver el email
            Usuarios email = new Usuarios();


            lblAutor.InnerText = autor;
            lblTitulo.InnerText = titulo;
            lblPrecio.InnerText = precio;
            lblUsuario.InnerText = usuario.User;
            lblEmail.InnerText = email.getEmail(usuario).Email;
            imgLibro.Attributes.Add("src", foto);

            List<Pais> listaPaises = new List<Pais>();
            listaPaises = ObtenerPaises();

            selectPais.Items.Add("Seleccionar");
            // ciclo para llevar los paises
            for (int i = 0; i < listaPaises.Count; i++)
            {
                selectPais.Items.Add(listaPaises[i].Nombre);
            }

            selectProvincia.Items.Add("Seleccionar");

           


            //marcarEntregadoDesdePerfil
            if (accion == "entregado")
            {
                FacturaUsuario factura = new FacturaUsuario();
                factura.Id= id;
                FacturasPorUsuarios entregado = new FacturasPorUsuarios();
                entregado.setFacturaEntregado(factura);
                Response.Redirect("Perfil.aspx?mensaje=Se marcó factura como entregada");

            }
            
        }


        public List<Pais> ObtenerPaises()
        {
            Paises paises = new Paises();
            List<Pais> listaPaises = new List<Pais>();
            listaPaises = paises.ObtenerPaises();



            return listaPaises;

        }

        public List<Provincia> ObtenerProvincias(string pais)
        {
            Paises provincia = new Paises();
            List<Provincia> provincias = new List<Provincia>();
            provincias = provincia.ObtenerProvincias();

            List<Provincia> listaProvincia = new List<Provincia>();
            for (int i = 0; i < provincias.Count; i++)
            {
                if (provincias[i].Id_Pais == pais)
                {
                    listaProvincia.Add(provincias[i]);
                }
            }



            return listaProvincia;

        }

        public string ObtenerIdPais(string pais)
        {

            List<Pais> listaPaises = new List<Pais>();
            listaPaises = ObtenerPaises();
            string id_pais = "";
            //ciclo para obtener id pais
            for (int i = 0; i < listaPaises.Count; i++)
            {
                if (listaPaises[i].Nombre == pais)
                {
                    id_pais = listaPaises[i].Id;
                }
            }

            return id_pais;
        }



        protected void btnBuscarProv_ServerClick(object sender, EventArgs e)
        {

            string pais = selectPais.Value;
            ObtenerIdPais(pais);
            List<Provincia> listaProvincias = new List<Provincia>();
            listaProvincias = ObtenerProvincias(ObtenerIdPais(pais));


            //InpPruebas.Attributes.Add("value", Text1.Value);

            // ciclo para llevar los provincias
            for (int i = 0; i < listaProvincias.Count; i++)
            {
                selectProvincia.Items.Add(listaProvincias[i].Nombre);
            }






        }

        protected void btnComprar_ServerClick(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            string isbn = Request.QueryString["isbn"];
            string titulo = Request.QueryString["titulo"];
            string autor = Request.QueryString["autor"];
            string precio = Request.QueryString["precio"];
            string foto = Request.QueryString["foto"];
            Usuario usuario = (Usuario)Session["Login"];
            Usuarios email=new Usuarios();
            
            FacturaUsuario factura = new FacturaUsuario()
            {   ISBN = isbn,
                User = usuario.User,
                Email = email.getEmail(usuario).Email.ToString(),
                Titulo = titulo,
                Autor = autor,
                Precio = Convert.ToDouble(precio),
                Foto = foto,
                Pais = selectPais.Value,
                Provincia = selectProvincia.Value,
                Direccion = txtDescripcion.Value,
                CodigoPostal = inCodigoPostal.Value,
                NumeroTarjeta = inNumTarjeta.Value,
                FechaExp = Text1.Value,
                CodigoSeg = inCodigoPostal.Value,
                FechaEmision = DateTime.Today,
                Estado = "Pendiente"

            };
            FacturasPorUsuarios facturaFinal = new FacturasPorUsuarios();
            facturaFinal.setFacturaFinal(factura);
            LibrosPorCarritos quitarDeCarrito = new LibrosPorCarritos();
            quitarDeCarrito.quitarLibroCarrito(Convert.ToInt32(id));
            Response.Redirect("Inicio.aspx?mensaje=Compra realizada con éxito");
        }

        protected void btnRegresar_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}