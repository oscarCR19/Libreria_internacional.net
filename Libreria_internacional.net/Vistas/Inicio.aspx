﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Libreria_internacional.net.Vistas.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <link rel="stylesheet"
        id="theme_link"
        href="https://cdnjs.cloudflare.com/ajax/libs/bootswatch/5.1.2/lumen/bootstrap.min.css" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link href="../css/mdb.min.css" rel="stylesheet" />
    <link href="../css/navbar-fixed-left.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="../css/navbar-fixed-left.min.css" />
    <link rel="stylesheet" href="../css/docs.css" />
    <script src="../js/jquery.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/app.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <title>Inicio</title>
</head>
<body style="background-color: #f5f6fa; width: auto">
    <form id="form1" runat="server">
        <div>
            <!--Alerta-->
            <div id="divAlert2" hidden="hidden" role="alert" runat="server">
                <label id="lblAlert2" runat="server">hola</label>
                <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>



            <div id="divEncabezado" runat="server" style="display: flexbox; text-align: right;">
                <label style="margin-right: 10px;" for="">Bienvenidos a Libreria Internacional</label>
                <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#modalIngresar">
                    Ingresar
                </button>
                <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#modalRegistrar">
                    Registrar
                </button>
            </div>
            <hr>
            <!--logo-->
            <div>
                <div class="row">
                    <div class="column" style="float: left; width: 83%;">
                        <div style="margin-left: 20px">
                            <a class="logo" href="Inicio.aspx">
                                <img src="/Assets/Logo/LOGO-LI-01.png" alt="" width="170" height="64" />
                            </a>
                        </div>

                    </div>
                    <!--Seccion de saludo y cart shoppin-->

                    <div class="column" style="float: right; width: 17%;">
                        <div>
                            <label id="lblUser" runat="server" for=""></label>

                            <button class="fa" type="button" style="font-size: 45px; color: blue; border-radius: 10px;" data-bs-toggle="offcanvas" data-bs-target="#offcanvasRight" aria-controls="offcanvasRight">&#xf07a;</button>
                            <span class='badge badge-warning' id='lblCartCount' runat="server">0 </span>
                        </div>
                    </div>



                </div>
            </div>
            <hr>
            <!--Carusel-->
            <div class="container-sm" style="margin-left: 30%;">
                <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
                    <ol class="carousel-indicators">
                        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                    </ol>
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <img class="d-block w-50" src="/Assets/carrusel/banner1.jpg" alt="First slide">
                        </div>
                        <div class="carousel-item">
                            <img class="d-block w-50" src="/Assets/carrusel/banner2.png" alt="Second slide">
                        </div>
                        <div class="carousel-item">
                            <img class="d-block w-50" src="/Assets/carrusel/banner3.jpg" alt="Third slide">
                        </div>
                    </div>
                    <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                    </a>
                    <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                    </a>
                </div>
            </div>
            <hr>


            <!--off canvas de cart shopping-->


            <div class="offcanvas offcanvas-end" tabindex="-1" id="offcanvasRight" aria-labelledby="offcanvasRightLabel">
                <div class="offcanvas-header">
                    <h5 id="offcanvasRightLabel">Facturas Pendientes de Pago</h5>
                    <button type="button" class="btn-close text-reset" data-bs-dismiss="offcanvas" aria-label="Close" style="background-color: black"></button>
                </div>
                <div class="offcanvas-body">
                    <asp:Repeater ID="repLibrosCarro" runat="server">
                        <ItemTemplate>

                            <div class="list-group">
                                <abbr style="text-decoration: none" title="Presiona para realizar la compra">
                                    <div class="list-group">
                                        <a href="AgregarFacturas.aspx?id=<%# Eval("ID")%>&isbn=<%#Eval("ISBN") %>&titulo=<%#Eval("Titulo") %>&autor=<%#Eval("Autor") %>&precio=<%#Eval("Precio") %>&foto=<%#Eval("Foto") %>" class="list-group-item list-group-item-action flex-column align-items-start">
                                            <div class="d-flex w-100 justify-content-between">
                                                <h5 class="mb-1">Factura:</h5>
                                                <label style="margin-right: 90px"><%#Eval("Id") %></label>
                                                <small><%#Eval("DiasTranscurridos") %> days ago</small>
                                            </div>

                                            <div class="d-flex w-100 justify-content-between">
                                                <h5 class="mb-1">ISBN:</h5>
                                                <label style="margin-right: 200px"><%#Eval("ISBN") %></label>
                                            </div>

                                            <div class="d-flex w-100 justify-content-between">
                                                <h5 class="mb-1">Titulo:</h5>
                                                <label style="margin-right: 160px"><%#Eval("Titulo") %></label>
                                            </div>

                                            <div class="d-flex w-100 justify-content-between">
                                                <h5 class="mb-1">Precio:</h5>
                                                <label style="margin-right: 200px">₡<%#Eval("Precio") %></label>
                                            </div>
                                        </a>
                                        <abbr title="Dar click para eliminar">
                                            <div class="col w-25" style="float: right; margin-right: 30px;">
                                                <div>
                                                    <a href="AgregarCarro.aspx?accion=borraCarrito&id=<%#Eval("Id") %>&sitio=Inicio.aspx" class="btn btn alert-danger">Eliminar
                                                    </a>
                                                </div>
                                            </div>
                                        </abbr>


                                    </div>
                                </abbr>

                            </div>


                        </ItemTemplate>
                    </asp:Repeater>

                </div>
            </div>

            <!-- Modal Registrar -->
            <!-- Button trigger modal -->

            <div class="modal fade" id="modalRegistrar" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h3 class="modal-title" id="modalRegistrar">Registrar</h3>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body">
                            <div>
                                <h4>Ingrese los datos que se solicita a continuacion:
                                </h4>
                                <label for="textUsuario">Usuario</label>
                                <input id="textUsuario" runat="server" type="text" />
                                <br />
                                <label for="textContrasena">Contraseña</label>
                                <input id="textContrasena" runat="server" type="password" />
                                <br />
                                <label for="textEmail">Email</label>
                                <input id="textEmail" runat="server" type="email" />


                            </div>
                        </div>
                        <div class="modal-footer">
                            <button id="btnRegistrar" runat="server" onserverclick="btnRegistrar_ServerClick" type="button" class="btn btn-primary">Registrar</button>
                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</button>

                        </div>
                    </div>
                </div>
            </div>

            <!-- Modal Ingresar -->
            <div class="modal fade" id="modalIngresar" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="modalIngresar">Ingresar</h5>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body">
                            <div>
                                <label>Usuario</label>
                                <input id="txtUser" runat="server" type="text">
                                <br />
                                <label>Contraseña</label>
                                <input id="txtPassword" runat="server" type="password">
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-primary" id="btnIngresar" runat="server" onserverclick="btnIngresar_ServerClick">Ingresar</button>
                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</button>
                        </div>
                    </div>
                </div>
            </div>

            <!--menú lateral-->
            <div class="row">
                <div class="column" style="float: left; width: 10%;">
                    <div style="width: 70px;">
                        <div class="nav flex-column nav-pills" id="v-pills-tab" role="tablist" aria-orientation="vertical">
                            <a class="nav-link active" id="v-pills-home-tab" href="Inicio.aspx" role="tab" aria-controls="v-pills-home" aria-selected="true">Inicio</a>
                            <a class="nav-link" id="v-pills-profile-tab" href="Perfil.aspx" role="tab" aria-controls="v-pills-profile" aria-selected="false">Perfil</a>
                            <!--<a class="nav-link" id="v-pills-messages-tab" href="Favoritos.aspx" role="tab" aria-controls="v-pills-messages" aria-selected="false">Favoritos</a>-->
                            <a class="nav-link" id="btnCerrar" runat="server" onserverclick="btnCerrar_ServerClick" href="#v-pills-settings" role="tab" aria-controls="v-pills-settings" aria-selected="false">Cerrar</a>
                        </div>
                        <div class="tab-content" id="v-pills-tabContent">
                            <div class="tab-pane fade show active" id="v-pills-home" role="tabpanel" aria-labelledby="v-pills-Inicio-tab"></div>
                            <div class="tab-pane fade show active" id="v-pills-profile" role="tabpanel" aria-labelledby="v-pills-Perfil-tab"></div>
                            <div class="tab-pane fade" id="v-pills-messages" role="tabpanel" aria-labelledby="v-pills-Favoritos-tab"></div>
                            <div class="tab-pane fade" id="v-pills-settings" role="tabpanel" aria-labelledby="v-pills-Cerrar-tab"></div>
                        </div>
                    </div>
                </div>
                <div class="column" style="float: right; width: 90%;">
                    <!--Alerta-->
                    <div id="divAlert" hidden="hidden" role="alert" runat="server">
                        <label id="lblAlert" runat="server">hola</label>
                        <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>

                    <!--Espacio de trabajo-->


                    <!--InputBusqueda-->
                    <div id="divBusqueda" runat="server" style="margin-left:60px;">
                        <div class="input-group mb-3 w-25">
                            <input id="inputBusqueda" runat="server" type="text" class="form-control" placeholder="Por nombre o isbn" aria-label="Recipient's username" aria-describedby="basic-addon2"/>
                            <div class="input-group-append">
                                <button id="btnBuscar" runat="server" onserverclick="btnBuscar_ServerClick"   class="btn btn-info" type="button">Buscar</button>
                            </div>
                        </div>
                    </div>



                    <div class="container-fluid ml-3" style="margin-top: 1%">
                        <div class="row">


                            <!--RepetidorUno-->
                            <asp:Repeater ID="repLibros" runat="server">
                                <ItemTemplate>
                                    <div class="card" style="width: 18rem; margin-left: 2%; margin-top: 1%">
                                        <img src="<%# Eval("Foto") %>" class="card-img-top" style="width: 265px; height: 230px" />
                                        <div class="card-body">

                                            <label>ISBN:</label>
                                            <h5 class="card-title"><%# Eval("ISBN") %></h5>
                                            <label>Titulo:</label>
                                            <p class="card-text"><%# Eval("Titulo") %></p>
                                            <label>Autor:</label>
                                            <strong class="card-text"><%# Eval("Autor") %></strong>
                                            <div class="row">
                                                <div class="col">
                                                    <label>Precio: </label>
                                                </div>
                                                <div class="col" style="margin-right: 60px;">
                                                    <h5 class="card-title">₡<%# Eval("Precio") %></h5>
                                                </div>
                                            </div>
                                            <hr />
                                            <div class="row">
                                                <div class="col" style="width: 70%">
                                                    <a id="btnComprar" href="AgregarCarro.aspx?isnb=<%# Eval("ISBN") %>&titulo= <%# Eval("Titulo")%>&autor=<%# Eval("Autor") %>
                                                        &precio=<%# Eval("Precio")%>&foto=<%# Eval("Foto")%>"
                                                        style="float: right;" class="btn btn-primary">Agregar  carrito</a>
                                                </div>

                                                <div class="col" style="width: 30%">

                                                    <abbr title="Presionar para agregar a favoritos">
                                                        <a id="btnFavoritos" href="AgregarFavoritos.aspx?accion=poner&isbn=<%# Eval("ISBN") %>" style="float: right">
                                                            <img src="/Assets/Iconos/nofavorito.png" alt="" /></a></abbr>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>

                            <!--RepetidorDos-->
                            <asp:Repeater ID="repLibros2" runat="server">
                                <ItemTemplate>
                                    <div class="card" style="width: 18rem; margin-left: 2%; margin-top: 1%">
                                        <img src="<%# Eval("Foto") %>" class="card-img-top" style="width: 265px; height: 230px" />
                                        <div class="card-body">

                                            <label>ISBN:</label>
                                            <h5 class="card-title"><%# Eval("ISBN") %></h5>
                                            <label>Titulo:</label>
                                            <p class="card-text"><%# Eval("Titulo") %></p>
                                            <label>Autor:</label>
                                            <strong class="card-text"><%# Eval("Autor") %></strong>
                                            <div class="row">
                                                <div class="col">
                                                    <label>Precio: </label>
                                                </div>
                                                <div class="col" style="margin-right: 60px;">
                                                    <h5 class="card-title">₡<%# Eval("Precio") %></h5>
                                                </div>
                                            </div>
                                            <hr />
                                            <div class="row">
                                                <div class="col" style="width: 70%">
                                                    <a id="btnComprar" runat="server" onserverclick="btnComprar_ServerClick" style="float: right;" class="btn btn-primary">Agregar  carrito</a>
                                                </div>
                                                <div class="col" style="width: 30%">

                                                    <abbr title="Presionar para agregar a favoritos">
                                                        <a id="btnFavoritos" runat="server" onserverclick="btnFavoritos_ServerClick" style="float: right">
                                                            <img src="/Assets/Iconos/nofavorito.png" alt="" /></a></abbr>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>

                            <!--RepetidorTres-->
                            <asp:Repeater ID="repLibros3" runat="server">
                                <ItemTemplate>
                                    <div class="card" style="width: 18rem; margin-left: 2%; margin-top: 1%">
                                        <img src="<%# Eval("Foto") %>" class="card-img-top" style="width: 265px; height: 230px" />
                                        <div class="card-body">

                                            <label>ISBN:</label>
                                            <h5 class="card-title"><%# Eval("ISBN") %></h5>
                                            <label>Titulo:</label>
                                            <p class="card-text"><%# Eval("Titulo") %></p>
                                            <label>Autor:</label>
                                            <strong class="card-text"><%# Eval("Autor") %></strong>
                                            <div class="row">
                                                <div class="col">
                                                    <label>Precio: </label>
                                                </div>
                                                <div class="col" style="margin-right: 60px;">
                                                    <h5 class="card-title">₡<%# Eval("Precio") %></h5>
                                                </div>
                                            </div>
                                            <hr />
                                            <div class="row">
                                                <div class="col" style="width: 70%">
                                                    <a id="btnComprar" runat="server" onserverclick="btnComprar_ServerClick" style="float: right;" class="btn btn-primary">Agregar  carrito</a>
                                                </div>
                                                <div class="col" style="width: 30%">

                                                    <abbr title="Presionar para agregar a favoritos">
                                                        <a id="btnFavoritos" runat="server" onserverclick="btnFavoritos_ServerClick" style="float: right">
                                                            <img src="/Assets/Iconos/nofavorito.png" alt="" /></a></abbr>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>


                        </div>
                    </div>
                </div>
            </div>
            <hr />



            <!-- Modal de ir agregar a carito -->
            <div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
                <div class="modal-dialog modal-dialog-centered" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLongTitle">Modal title</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                            <button type="button" class="btn btn-primary">Save changes</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
