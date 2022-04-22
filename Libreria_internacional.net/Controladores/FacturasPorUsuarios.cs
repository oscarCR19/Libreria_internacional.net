using Libreria_internacional.net.DB;
using Libreria_internacional.net.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Libreria_internacional.net.Controladores
{
    public class FacturasPorUsuarios
    {//Aqui se crean facturas nuevas, cuando en el inicio un usuario le da agregar aqui se genera esa
     //factura, que despues se imprimepor cada usuario
        List<FacturaUsuario> facturaCarrito = new List<FacturaUsuario>();
        List<FacturaUsuario> facturaFinal = new List<FacturaUsuario>();
        public void setFacturaCarrito(FacturaUsuario facturas)
        {
            //Metodo para crear factura que va al carro
            FacturaUsuario factura = new FacturaUsuario();
            factura.Id = facturas.Id;
            factura.ISBN = facturas.ISBN;
            factura.Titulo = facturas.Titulo;
            factura.Precio = facturas.Precio;
            factura.User = facturas.User;
            factura.FechaEmision = facturas.FechaEmision;
            facturaCarrito.Add(factura);
        }



        public List<FacturaUsuario> getFacturaCarrito(Usuario usuario, FacturaUsuario fac)
        {//Metodo para obtener factura por usuario especifico e imprimir en el offcanvas(carroCompras)
            List<FacturaUsuario> facturas = new List<FacturaUsuario>();
           
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@user", usuario.User));
            param.Add(new SqlParameter("@estado", fac.Estado));

            DataTable dt = DataBase.fillDTStoreProcedure("spObtenerFactura", param);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                FacturaUsuario factura = new FacturaUsuario()
                {   Id= dt.Rows[i]["id"].ToString(),
                    ISBN =dt.Rows[i]["isbn"].ToString(),
                    Titulo = dt.Rows[i]["titulo"].ToString(),
                    Precio =Convert.ToDouble(dt.Rows[i]["precio"].ToString()),
                    User = dt.Rows[i]["usuario"].ToString(),
                    Email = dt.Rows[i]["email"].ToString(),
                    FechaEmision = Convert.ToDateTime(dt.Rows[i]["fechaEmision"].ToString()),
                    Pais = dt.Rows[i]["pais"].ToString(),
                    Provincia = dt.Rows[i]["provincia"].ToString(),
                    Direccion = dt.Rows[i]["direccion"].ToString(),
                    CodigoPostal = dt.Rows[i]["codigopostal"].ToString(),
                    NumeroTarjeta = dt.Rows[i]["numTarjeta"].ToString(),
                    CodigoSeg = dt.Rows[i]["codigoSeg"].ToString(),
                    Estado = dt.Rows[i]["isbn"].ToString(),
                    FechaExp = dt.Rows[i]["fechaExp"].ToString(),
                    Autor= dt.Rows[i]["autor"].ToString(),
                    Foto = dt.Rows[i]["foto"].ToString(),


                };
                factura.DiasTranscurridos = DateTime.Now.Subtract(factura.FechaEmision).ToString().Remove(1);
                facturas.Add(factura);
            }




            return facturas;
        }
        //Metodo para introducir la factura final que se va a pintar en el perfil
        public void setFacturaFinal(FacturaUsuario facturas)
        {
            //Metodo para crear factura desde el micoservicio
            

            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@isbn", facturas.ISBN));
            param.Add(new SqlParameter("@titulo", facturas.Titulo));
            param.Add(new SqlParameter("@precio", facturas.Precio));
            param.Add(new SqlParameter("@usuario", facturas.User));
            param.Add(new SqlParameter("@email", facturas.Email));
            param.Add(new SqlParameter("@fechaEmision", facturas.FechaEmision));
            param.Add(new SqlParameter("@pais", facturas.Pais));
            param.Add(new SqlParameter("@provincia", facturas.Provincia));
            param.Add(new SqlParameter("@direccion", facturas.Direccion));
            param.Add(new SqlParameter("@codigoPostal", facturas.CodigoPostal));
            param.Add(new SqlParameter("@numTarjeta", facturas.NumeroTarjeta));
            param.Add(new SqlParameter("@codigoSeg", facturas.CodigoSeg));
            param.Add(new SqlParameter("@estado", facturas.Estado));
            param.Add(new SqlParameter("@fechaExp", facturas.FechaExp));
            param.Add(new SqlParameter("@foto", facturas.Foto));
            param.Add(new SqlParameter("@autor", facturas.Autor));
            DataBase.executeQuery("spIngresarFactura", param);
            
           
            
            
          

            
        }

        public void setFacturaEntregado (FacturaUsuario facturas)
        {
            //Metodo para crear factura desde el micoservicio


            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@id", facturas.Id));
            
            DataBase.executeQuery("spIngresarEntregado", param);







        }


        public List<FacturaUsuario> getFacturaFinal(Usuario usuario)
        {//Metodo para obtener factura por usuario especifico e imprimir en el
         //perfil de cada usuario,metodo incompleto a nivel local,se tiene que implementar en db pero se va a
         //llamar en el boton de comprar de microservicios
            List<FacturaUsuario> facturas = new List<FacturaUsuario>();
            Modelos.FacturaUsuario factura = new Modelos.FacturaUsuario()
            {
                Id = "1",
                ISBN = "12453",
                Titulo = "El principito",
                Autor = "Oscar",
                Precio = 17500,
                User = "oscar",
                FechaEmision = Convert.ToDateTime("10 / 04 / 2022 12:05:30"),
                Pais="Costa rica",
                Provincia="San josé",
                Direccion="De la iglesia 100 metros al sur",
                CodigoPostal="10502",
                NumeroTarjeta="12454553255222",
                FechaExp="2025/12",
                CodigoSeg="125",
                Foto= "/Assets/Libros/Señor de los anillos.jpg",
                Estado ="Pendiente entrega"
            };
            factura.DiasTranscurridos = DateTime.Now.Subtract(factura.FechaEmision).ToString().Remove(1);
            facturas.Add(factura);

            Modelos.FacturaUsuario factura2 = new Modelos.FacturaUsuario()
            {
                Id = "2",
                ISBN = "12453",
                Titulo = "El principito",
                Autor = "Oscar",
                Precio = 17500,
                User = "oscar",
                FechaEmision = Convert.ToDateTime("11 / 04 / 2022 12:05:30"),
                Pais = "Costa rica",
                Provincia = "San josé",
                Direccion = "De la iglesia 100 metros al sur",
                CodigoPostal = "10502",
                NumeroTarjeta = "12454553255222",
                FechaExp = "2025/12",
                CodigoSeg = "125",
                Foto="/Assets/Libros/Señor de los anillos.jpg",
                Estado = "Entregado"


            };
            factura2.DiasTranscurridos = DateTime.Now.Subtract(factura2.FechaEmision).ToString().Remove(1);
            facturas.Add(factura2);

            Modelos.FacturaUsuario factura3 = new Modelos.FacturaUsuario()
            {
                Id = "3",
                ISBN = "12453",
                Titulo = "El principito",
                Autor = "Oscar",
                Precio = 17500,
                User = "pepe",
                FechaEmision = Convert.ToDateTime("04 / 04 / 2022 12:05:30"),
                Pais = "Costa rica",
                Provincia = "San josé",
                Direccion = "De la iglesia 100 metros al sur",
                CodigoPostal = "10502",
                NumeroTarjeta = "12454553255222",
                FechaExp = "2025/12",
                CodigoSeg = "125",
                Foto = "/Assets/Libros/Señor de los anillos.jpg",
                Estado = "Pendiente entrega"


            };
            factura3.DiasTranscurridos = DateTime.Now.Subtract(factura3.FechaEmision).ToString().Remove(1);
            facturas.Add(factura3);

            List<FacturaUsuario> facturasFinal = new List<FacturaUsuario>();

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