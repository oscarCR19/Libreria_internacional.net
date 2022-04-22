using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libreria_internacional.net.Modelos
{
    public class Libro
    {
        // Aqui se le da forma al libro
        public string ISBN { get; set; }
        public string Foto { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string FechaPublicacion { get; set; }
        public string Estado { get; set; }
        public Double Precio { get; set; }
    }
}