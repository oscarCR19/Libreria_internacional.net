using Libreria_internacional.net.DB;
using Libreria_internacional.net.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Libreria_internacional.net.Controladores
{//Aqui se crean paises y provincias
    public class Paises
    {

        public List<Pais> ObtenerPaises()
        {//Aqui se obtienen los paises desde la db
            List<Pais> paises = new List<Pais>();

            DataTable dt = DbPaises.fillDTStoreProcedure("spObtenerPaises", null);

            foreach (DataRow dr in dt.Rows)
            {
                Pais pais = new Pais()
                {
                    Id = dr["id"].ToString(),
                    Nombre = dr["name"].ToString(),
                    
                };

                paises.Add(pais);
            }

            return paises;
        }
        //Aqui se obtienen las provincias desde la db 
        public List<Provincia> ObtenerProvincias()
        {
            List<Provincia> provincias = new List<Provincia>();
           

            DataTable dt = DbPaises.fillDTStoreProcedure("spObtenerProvincias", null);

            foreach (DataRow dr in dt.Rows)
            {
                Provincia provincia = new Provincia()
                {
                    Id = dr["id"].ToString(),
                    Nombre = dr["name"].ToString(),
                    Id_Pais= dr["id_country"].ToString()


                };
                    provincias.Add(provincia);
            }
            

            return provincias;
        }
    }
}