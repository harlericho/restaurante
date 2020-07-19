<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfmRegistro.aspx.cs" Inherits="webRestaurante.wfmRegistro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RESTAURANTE</title>
    <link rel="icon" href="Icons/logo.ico">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
</head>
<body>
    <br />
    <br />
    <form id="form1" runat="server">

        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-6">
                    <hr />
                    <h3>
                        <img src="Icons/users.ico" width="30" height="30" />
                        SISTEMA DE REGISTRO</h3>
                    <div class="col-md-12 mb-3">
                        <label for="exampleInputEmail1">Nombres:</label>
                        <asp:TextBox ID="txtNombres" runat="server" class="form-control" required autofocus></asp:TextBox>
                    </div>
                    <div class="col-md-12 mb-3">
                        <label for="exampleInputEmail1">Email:</label>
                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" required></asp:TextBox>
                    </div>
                    <div class="col-md-12 mb-3">
                        <label for="exampleInputPassword1">Contraseña:</label>
                        <asp:TextBox ID="txtPass" runat="server" class="form-control" required TextMode="Password"></asp:TextBox>
                    </div>

                    <div class="col-md-12 mb-3">
                        <label for="exampleInputPassword1">Reptir Contraseña:</label>
                        <asp:TextBox ID="txtPassRepetir" runat="server" class="form-control" required TextMode="Password"></asp:TextBox>
                    </div>

                    <div class="col-md-3 mb-3">
                        <asp:Button ID="btnResgistar" runat="server" Text="Registar" class="btn btn-dark btn-sm btn-block" OnClick="btnResgistar_Click" />
                    </div>
                    <center>
                        <a href="wfmLogin.aspx" class="badge badge-primary">Ir a login</a>
                    </center>
                    <hr />
                    <center>
                    <p class="mt-5 mb-3 text-muted">© 2020-2021</p>
                    <div class="copyright">
                        &copy; Copyright <strong><span>Harlericho</span></strong>
                        <a href="https://twitter.com/CarlChokSanc">CarlChokSanc</a>
                    </div>
                    </center>
                    <hr />
                </div>
            </div>
        </div>

    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
</body>
</html>
