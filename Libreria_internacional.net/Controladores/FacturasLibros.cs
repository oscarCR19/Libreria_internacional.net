using Libreria_internacional.net.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libreria_internacional.net.Controladores
{
    public class FacturasLibros
    {
        List<FacturaLibro> facturaFinal = new List<FacturaLibro>();
        public void setFactura(FacturaLibro facturas)
        {
         
            FacturaLibro factura = new FacturaLibro();
            factura.Id = facturas.Id;
            factura.ISBN = facturas.ISBN;  
            factura.Titulo = facturas.Titulo;
            factura.Precio = facturas.Precio;
            factura.User = facturas.User;
            factura.FechaEmision= facturas.FechaEmision;
            facturaFinal.Add(factura);
        }



        public List<FacturaLibro> getFactura(Usuario usuario)
        {
            List<FacturaLibro> facturas = new List<FacturaLibro>();
            Modelos.FacturaLibro factura = new Modelos.FacturaLibro()
            {
                Id = "1",
                ISBN = "12453",
                Titulo = "El principito",
                Autor = "Oscar",
                Precio = 17500,
                User = "oscar",
                FechaEmision = Convert.ToDateTime("10 / 04 / 2022 12:05:30")
            };
            
            facturas.Add(factura);

            Modelos.FacturaLibro factura2 = new Modelos.FacturaLibro()
            {
                Id = "2",
                ISBN = "12453",
                Titulo = "El principito",
                Autor = "Oscar",
                Precio = 17500,
                User = "oscar",
                FechaEmision = Convert.ToDateTime("11 / 04 / 2022 12:05:30")


            };
            facturas.Add(factura2);

            Modelos.FacturaLibro factura3 = new Modelos.FacturaLibro()
            {
                Id = "3",
                ISBN = "12453",
                Titulo = "El principito",
                Autor = "Oscar",
                Precio = 17500,
                User = "pepe",
                FechaEmision = Convert.ToDateTime("04 / 04 / 2022 12:05:30")


            };
            facturas.Add(factura3);

            List<FacturaLibro> facturasFinal = new List<FacturaLibro>();

            for (int i = 0; i < facturas.Count; i++)
            {
                if (facturas[i].User == usuario.User)
                {
                    facturasFinal.Add(facturas[i]);
                }
            }

            return facturasFinal;
        }
    }
}