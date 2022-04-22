using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libreria_internacional.net.Modelos
{
    public class LibroPorCarrito:Libro
    {
        //Se da forma a los libros que se imprimen en el carro de compras
        public string User { get; set; }
        public string Id { get; set; }
        public DateTime FechaEmision { get; set; }

        public string DiasTranscurridos { get; set; }

        public string Email { get; set; }
        

    }
        
}