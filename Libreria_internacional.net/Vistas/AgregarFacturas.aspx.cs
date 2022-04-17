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
    public partial class AgregarFacturas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            List<Pais> listaPaises = new List<Pais>();
            listaPaises = ObtenerPaises();


            for(int i = 0; i < listaPaises.Count; i++)
            {
                selectPais.Items.Add(listaPaises[i].Nombre);
            }

            List<Provincia> listaProvincias = new List<Provincia>();
            listaProvincias = ObtenerProvincias("36");

            if (selectPais.SelectedIndex.Equals(0))
            {
                InpPruebas.Attributes.Add("value","hola");
            }
            

            for (int i = 0; i < listaProvincias.Count; i++)
            {
                selectProvincia.Items.Add(listaProvincias[i].Nombre);
            }
                




            InpPruebas.Attributes.Add("value", listaProvincias.Count.ToString());
            }

        }


        public List<Pais> ObtenerPaises()
        {   Paises paises= new Paises();
            List<Pais> listaPaises = new List<Pais>();
            listaPaises=paises.ObtenerPaises(); 
            
            

            return listaPaises;

        }

        public List<Provincia> ObtenerProvincias(string pais)
        {
            Paises provincia = new Paises();
            List<Provincia> provincias = new List<Provincia>();
            provincias = provincia.ObtenerProvincias();

            List<Provincia> listaProvincia = new List<Provincia>();
            for ( int i = 0; i < provincias.Count; i++)
            {
                if(provincias[i].Id_Pais==pais)
                {
                    listaProvincia.Add(provincias[i]);
                }
            }



            return listaProvincia;

        }

        protected void btnPais_ServerClick(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                     }
        }
    }
}