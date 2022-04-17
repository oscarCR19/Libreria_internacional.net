using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libreria_internacional.net.Modelos
{
    public class LibroPorUsuario:Libro
    {
        public string User { get; set; }
        public string Id { get; set; }
        public DateTime FechaEmision { get; set; }

        public string DiasTranscurridos { get; set; }

        public string Email { get; set; }
        

    }
        
}