﻿using Libreria_internacional.net.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Libreria_internacional.net.Vistas
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Libros libros = new Libros();
            repLibros.DataSource = libros.obtenerLibros();
            repLibros.DataBind();
        }
    }
}