using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Libreria_internacional.net.DB;
using Libreria_internacional.net.Modelos;

namespace Libreria_internacional.net.Controladores
{
    public class Libros
    {//Por el momento aqui se crean libros manualmente, falta implementar desde db
        public List<Libro> obtenerLibros()
        {
            List<Libro> libros = new List<Libro>();

            DataTable dt = DataBase.fillDTStoreProcedure("spObtenerLibros", null);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Libro libro = new Libro()
                {
                    ISBN = dt.Rows[i]["isbn"].ToString(),
                    Titulo = dt.Rows[i]["titulo"].ToString(),
                    Autor = dt.Rows[i]["autor"].ToString(),
                    FechaPublicacion = dt.Rows[i]["anioPublicacion"].ToString(),
                    Foto = dt.Rows[i]["foto"].ToString(),
                    Precio = Convert.ToDouble(dt.Rows[i]["precio"])



                };
                libros.Add(libro);

            }
            return libros;
        }


        public List<Libro> obtenerBusqueda(Libro libro)
        {
            List<Libro> libros = new List<Libro>();
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@titulo", libro.Titulo));
            param.Add(new SqlParameter("@isbn", libro.ISBN));

            DataTable dt = DataBase.fillDTStoreProcedure("spObtenerBusqueda", param);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Libro Libro = new Libro()
                {
                    ISBN = dt.Rows[i]["isbn"].ToString(),
                    Titulo = dt.Rows[i]["titulo"].ToString(),
                    Autor = dt.Rows[i]["autor"].ToString(),
                    FechaPublicacion = dt.Rows[i]["anioPublicacion"].ToString(),
                    Foto = dt.Rows[i]["foto"].ToString(),
                    Precio = Convert.ToDouble(dt.Rows[i]["precio"])



                };
                libros.Add(Libro);

            }
            return libros;
        }

        public void SetFavoritos(Libro libro, Usuario usuario)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@isbn", libro.ISBN));
            param.Add(new SqlParameter("@user", usuario.User));

            DataBase.executeQuery("spIngresarFavoritos", param);


        }

        public void QuitarFavoritps(Libro libro, Usuario usuario)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@isbn", libro.ISBN));
            param.Add(new SqlParameter("@user", usuario.User));

            DataBase.executeQuery("spQuitarFavoritos", param);


        }

        public List<Libro> ObtenerFavoritos(Usuario usuario)
        {
            List<Libro> libros = new List<Libro>();
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@user", usuario.User));

            DataTable dt = DataBase.fillDTStoreProcedure("spObtenerFavoritos", param);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Libro libro = new Libro()
                {
                    ISBN = dt.Rows[i]["isbn"].ToString(),
                    Titulo = dt.Rows[i]["titulo"].ToString(),
                    Autor = dt.Rows[i]["autor"].ToString(),
                    FechaPublicacion = dt.Rows[i]["anioPublicacion"].ToString(),
                    Foto = dt.Rows[i]["foto"].ToString(),
                    Precio = Convert.ToDouble(dt.Rows[i]["precio"])



                };
                libros.Add(libro);

            }
            return libros;


    }
}
}