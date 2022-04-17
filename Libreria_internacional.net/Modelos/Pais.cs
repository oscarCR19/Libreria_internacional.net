using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libreria_internacional.net.Modelos
{
    public class Pais
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
    }

    public class Provincia : Pais
    {
        public string Id_Pais { get; set; }

    }
}