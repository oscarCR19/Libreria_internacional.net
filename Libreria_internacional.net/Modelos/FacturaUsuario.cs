using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libreria_internacional.net.Modelos
{
    public class FacturaUsuario:LibroPorCarrito
    {   //Aqui se da forma a la factura de cada usuario
        
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public string NumeroTarjeta { get; set; }
        public string FechaExp { get; set; }
        public string CodigoSeg { get; set; }

    }
}