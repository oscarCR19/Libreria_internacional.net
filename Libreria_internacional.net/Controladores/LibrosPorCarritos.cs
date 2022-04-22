using Libreria_internacional.net.DB;
using Libreria_internacional.net.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Libreria_internacional.net.Controladores
{
    public class LibrosPorCarritos
    {

        private List<LibroPorCarrito> ListCarrito = new List<LibroPorCarrito>();



        public void setListCarrito(Libro libro,Usuario usuario)
        {
            Usuarios email = new Usuarios();
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@isbn", libro.ISBN));
            param.Add(new SqlParameter("@titulo", libro.Titulo));
            param.Add(new SqlParameter("@autor", libro.Autor));
            param.Add(new SqlParameter("@precio", libro.Precio));
            param.Add(new SqlParameter("@usuario", usuario.User));
            param.Add(new SqlParameter("@estado", libro.Estado));
            param.Add(new SqlParameter("@fechaEmision", DateTime.Today));
            param.Add(new SqlParameter("@foto", libro.Foto));
            param.Add(new SqlParameter("@email", email.getEmail(usuario).Email.ToString()));

            DataBase.executeQuery("spIngresarFacturaCarrito", param);

        }
        


        public List<LibroPorCarrito> getListCarrito(Usuario usuario)
        {
            List<LibroPorCarrito> ListCarritos = new List<LibroPorCarrito>();
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@user", usuario.User));

            DataTable dt = DataBase.fillDTStoreProcedure("spObtenerLibrosCarrito", param);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Modelos.LibroPorCarrito Libros = new Modelos.LibroPorCarrito()
                {
                    Id = dt.Rows[i]["id"].ToString(),
                    ISBN = dt.Rows[i]["isbn"].ToString(),
                    Titulo = dt.Rows[i]["titulo"].ToString(),
                    Autor = dt.Rows[i]["autor"].ToString(),
                    Precio = Convert.ToDouble(dt.Rows[i]["precio"]),
                    User = dt.Rows[i]["usuario"].ToString(),
                    Email=dt.Rows[i]["email"].ToString(),
                    Foto= dt.Rows[i]["foto"].ToString(),
                    Estado = dt.Rows[i]["estado"].ToString(),
                    FechaEmision =Convert.ToDateTime(dt.Rows[i]["fechaEmision"].ToString())



                };
                Libros.DiasTranscurridos = DateTime.Now.Subtract(Libros.FechaEmision).ToString().Remove(1);
                ListCarritos.Add(Libros);
            }

            for(int i = 0; i < ListCarritos.Count; i++)
            {
                if(ListCarritos[i].Estado!= "Pago Pendiente")
                {
                    ListCarrito.RemoveAt(i);
                }
            }

            return ListCarritos;
        }

        public void quitarLibroCarrito(int id)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@id", id));
            DataBase.executeQuery("spborraDeCarrito", param);

        }
    }
}