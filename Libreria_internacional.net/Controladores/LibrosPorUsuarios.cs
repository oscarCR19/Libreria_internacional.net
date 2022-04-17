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



        public void setListCarrito(string isbn, string titulo, string autor, Double precio, string user)
        {
            Modelos.LibroPorUsuario Libro = new Modelos.LibroPorUsuario();
            Libro.ISBN = isbn;
            Libro.Titulo = titulo;
            Libro.Autor = autor;
            Libro.Precio = precio;
            Libro.User = user;

            ListCarrito.Add(Libro);

        }


        public List<LibroPorUsuario> getListCarrito(Usuario usuario)
        {
            List<LibroPorUsuario> ListCarritos = new List<LibroPorUsuario>();
            Modelos.LibroPorUsuario Libros = new Modelos.LibroPorUsuario()
            {
                Id = "1",
                ISBN = "12453",
                Titulo = "El principito",
                Autor = "Oscar",
                Precio = 17500,
                User = "oscar",
                FechaEmision = Convert.ToDateTime("10 / 04 / 2022 12:05:30")
            };
            Libros.DiasTranscurridos = DateTime.Now.Subtract(Libros.FechaEmision).ToString().Remove(1);
            ListCarritos.Add(Libros);

            Modelos.LibroPorUsuario Libros2 = new Modelos.LibroPorUsuario()
            {
                Id = "2",
                ISBN = "12453",
                Titulo = "El principito",
                Autor = "Oscar",
                Precio = 17500,
                User = "oscar",
                FechaEmision = Convert.ToDateTime("11 / 04 / 2022 12:05:30")


            };
            Libros2.DiasTranscurridos = DateTime.Now.Subtract(Libros2.FechaEmision).ToString().Remove(1);
            ListCarritos.Add(Libros2);

            Modelos.LibroPorUsuario Libros3 = new Modelos.LibroPorUsuario()
            {
                Id = "3",
                ISBN = "12453",
                Titulo = "El principito",
                Autor = "Oscar",
                Precio = 17500,
                User = "pepe",
                FechaEmision = Convert.ToDateTime("04 / 04 / 2022 12:05:30")


            };
            Libros3.DiasTranscurridos = DateTime.Now.Subtract(Libros3.FechaEmision).ToString().Remove(1);
            ListCarritos.Add(Libros3);

            List<LibroPorUsuario> ListCarritosfinal = new List<LibroPorUsuario>();

            for (int i = 0; i < ListCarritos.Count; i++)
            {
                if (ListCarritos[i].User == usuario.User)
                {
                    ListCarritosfinal.Add(ListCarritos[i]);
                }
            }

            return ListCarritosfinal;
        }
    }
}