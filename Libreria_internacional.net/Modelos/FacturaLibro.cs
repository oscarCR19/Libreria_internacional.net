using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libreria_internacional.net.Modelos
{
    public class FacturaLibro:LibroPorUsuario
    {
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Dirrecion { get; set; }
        public string CodigoPostal { get; set; }
        public string NumeroTarjeta { get; set; }
        public string FechaExp { get; set; }
        public string CodigoSeg { get; set; }

    }
}