using Libreria_internacional.net.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libreria_internacional.net.Controladores
{
    public class LibrosPorUsuarios
    {
        
        private List<LibroPorUsuario> ListCarrito = new List<LibroPorUsuario>();
        


        public void setListCarrito(string isbn,string titulo, string autor,Double precio,string user)
        {
            Modelos.LibroPorUsuario Libro=new Modelos.LibroPorUsuario();
            Libro.ISBN = isbn;
            Libro.Titulo = titulo;
            Libro.Autor = autor;
            Libro.Precio = precio;
            Libro.user = user;

            ListCarrito.Add(Libro);
            
        }
        
        public List<LibroPorUsuario> getListCarrito()
        {
             List<LibroPorUsuario> ListCarritos = new List<LibroPorUsuario>();
            Modelos.LibroPorUsuario Libros = new Modelos.LibroPorUsuario()
            {
                ISBN = "12453",
                Titulo ="El principito",
                Autor ="Oscar",
                Precio =17500,
                user ="oscar"

            };
            ListCarritos.Add(Libros);

            Modelos.LibroPorUsuario Libros2 = new Modelos.LibroPorUsuario()
            {
                ISBN = "12453",
                Titulo = "El principito",
                Autor = "Oscar",
                Precio = 17500,
                user = "oscar"

            };
            ListCarritos.Add(Libros2);

            return ListCarritos;
        }
    }
}