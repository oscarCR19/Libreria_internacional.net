<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerFacturas.aspx.cs" Inherits="Libreria_internacional.net.Vistas.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
    <title>Factura</title>
</head>
<body style="background-color: #f5f6fa">
    <form id="form1" runat="server">
        <div>
            <div class="container" style="border: 2px solid black;">

                <div class="signup-form-container">

                    <!-- form start -->


                    <div class="form-header">
                        <h3 class="form-title" style="text-align: center;"><i class="fa fa-user"></i>Detalles de Factura</h3>

                        <div class="pull-right">
                            <h3 class="form-title"><span class="glyphicon glyphicon-pencil"></span></h3>
                        </div>
                        <hr>
                    </div>

                    <div class="form-body">
                        <div class="row">
                            <div class="col w-70">
                                <h3>Datos de Usuario</h3>
                        <!--Input Usuario -->
                        <div class="form-group">
                            <div class="input-group">
                                <div class="input-group-addon"><span class="glyphicon glyphicon-user"></span></div>
                                <label for="">Usuario: </label>
                                <label id="lblUsuario" runat="server" style="margin-left:10px;" for=""></label>
                            </div>
                            <span class="help-block" id="error"></span>
                        </div>
                        <!--Input Email -->
                        <div class="form-group">
                            <div class="input-group">
                                <div class="input-group-addon"><span class="glyphicon glyphicon-envelope"></span></div>
                                <label for="">Email: </label>
                                <label id="lblEmail" runat="server" style="margin-left:10px;" for=""></label>
                            </div>
                            <span class="help-block" id="error"></span>
                        </div>

                        
                             <!--SelectPais -->
                            <div class="form-group >
                                <label for="">País:</label>
                                <label id="lblPais" runat="server" style="margin-left:10px" for=""></label>
                                </div>
                             <!-- SelectPrivincia -->
                            <div class="form-group>
                                <label for="">Provincia:</label>
                                <label id="lblProvincia" runat="server" style="margin-left:10px" for=""></label>
                            </div>
                            
                            
                        <!--texarea Direccion -->
                            
                            <div class="form-group ">
                                <div class="input-group">
                                    <div class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></div>
                                    <label for="">Direccion:</label>
                                    <label id="lblDirrecion" runat="server" style="margin-left:10px"> </label>

                                </div>
                                <span class="help-block" id="error"></span>
                            </div>
                                <!--InputCodigoPostal -->
                            <div class="form-group ">
                                <div class="input-group">
                                    <div class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></div>
                                    <label for="">Codigo Postal:</label>
                                    <label id="lblCodigoPostal" runat="server" style="margin-left:10px" for=""></label>
                                </div>
                                <span class="help-block" id="error"></span>
                            </div>
                                
                            <h3>Datos tarjeta </h3>
                             <!--Input Num tarjeta -->
                            <div class="form-group ">
                                <div class="input-group">
                                    <div class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></div>
                                    <label for="">Numero Tarjeta:</label>
                                    <label id="lblNumTarjeta" runat="server" style="margin-left:10px" for="">1545455542255256</label>
                                </div>
                                <span class="help-block" id="error"></span>
                            </div>
                            <!--Input Fecha expiracion -->
                            <div class="form-group ">
                                <div class="input-group">
                                    <div class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></div>
                                    <label for="">Fecha expiracion:</label>
                                    <label id="lblFechaExp" runat="server" style="margin-left:10px" for=""></label>
                                </div>
                                <span class="help-block" id="error"></span>
                            </div>
                            </div>
                            <!--Segundo div-->
                            <div class="col w-30">
                            <h3>Detalles de compra</h3>

                        <div class="row">
                            <!--card-->
                            <div class="card" style="width: 200px;">
                                <img id="imgLibro" runat="server" src="/Assets/Libros/El principito.jpg" class="card-img-top"  alt="Card image cap"/>
                            </div>

                            <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-addon"><span class="glyphicon glyphicon-user"></span></div>
                                    <label for="">Titulo: </label>
                                    <label id="lblTitulo" runat="server" style="margin-left:10px;" for=""> </label>
                                </div>
                                <span class="help-block" id="error"></span>
                            </div>

                            <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-addon"><span class="glyphicon glyphicon-user"></span></div>
                                    <label for="">Autor: </label>
                                    <label id="lblAutor" runat="server" style="margin-left:10px;" for=""></label>
                                </div>
                                <span class="help-block" id="error"></span>
                            </div>

                            <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-addon"><span class="glyphicon glyphicon-user"></span></div>
                                    <label for="">Fecha de Entrega: </label>
                                    <label id="lblFechaEntrega" runat="server" style="margin-left:10px;" for=""></label>
                                </div>
                                <span class="help-block" id="error"></span>
                            </div>

                            <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-addon"><span class="glyphicon glyphicon-user"></span></div>
                                    <label for="">Precio: </label>
                                    <label id="lblPrecio" runat="server" style="margin-left:10px;" for=""></label>
                                </div>
                                <span class="help-block" id="error"></span>
                            </div>

                        </div>
                    </div>

                    </div>

                         </div>
                        <hr /><!--Botonregresar-->
                    <div style="text-align: right;" class="form-footer">
                        <button id="btnRegresar" runat="server" onserverclick="btnRegresar_ServerClick" type="button" class="btn btn-primary">
                            <span class="glyphicon glyphicon-log-in"></span>Regresar
                        </button>
                    </div>




                </div>

            </div>

        </div>
    </form>
</body>
</html>
