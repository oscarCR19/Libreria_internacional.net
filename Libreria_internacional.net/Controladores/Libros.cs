using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Libreria_internacional.net.Modelos;

namespace Libreria_internacional.net.Controladores
{
    public class Libros
    {
        public List<Libro> obtenerLibros()
        {
            List<Libro> libros = new List<Libro>();

            Libro libroUno = new Libro();
            libroUno.ISBN = "264512";
            libroUno.Autor = "J.R.R Tolkien";
            libroUno.Titulo = "El Señor de los Anillos";
            libroUno.FechaPublicacion = "20/10/1995";
            libroUno.Foto = "/Assets/Libros/El principito.jpg";
            libroUno.Precio =  12500;

            libros.Add(libroUno);

            Libro libroDos = new Libro()
            {
                ISBN = "545512",
                Titulo = "El principito",
                Autor = "Antoine de Saint-Exupéry",
                FechaPublicacion = "06/04/1943",
                Foto = "/Assets/Libros/El principito.jpg",
                Precio = 15315

            };
            Libro libro3 = new Libro()
            {
                ISBN = "545512",
                Titulo = "El principito",
                Autor = "Antoine de Saint-Exupéry",
                FechaPublicacion = "06/04/1943",
                Foto="/Assets/Libros/El principito.jpg",
                Precio=14775

            };
            Libro libro4 = new Libro()
            {
                ISBN = "545512",
                Titulo = "El principito",
                Autor = "Antoine de Saint-Exupéry",
                FechaPublicacion = "06/04/1943",
                Foto = "/Assets/Libros/El principito.jpg",
                Precio=13500
               

            };
            Libro libro5 = new Libro()
            {
                ISBN = "545512",
                Titulo = "El principito",
                Autor = "Antoine de Saint-Exupéry",
                FechaPublicacion = "06/04/1943",
                Foto = "/Assets/Libros/El principito.jpg",
                Precio=14000

            };
            Libro libro6 = new Libro()
            {
                ISBN = "545512",
                Titulo = "El principito",
                Autor = "Antoine de Saint-Exupéry",
                FechaPublicacion = "06/04/1943",
                Foto = "/Assets/Libros/El principito.jpg",
                Precio=7500

            };

            libros.Add(libroDos);
            libros.Add(libro3);
            libros.Add(libro4);
            libros.Add(libro5);
            libros.Add(libro6);
            


            return libros;
        }
        

        
        
    }
  
}