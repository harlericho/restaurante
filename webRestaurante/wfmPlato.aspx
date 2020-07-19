<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfmPlato.aspx.cs" Inherits="webRestaurante.wfmUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Icons/plato.ico" Width="30" Height="30" />
        Registro de plato nuevo</h3>
    <hr />
    <div class="form-row">
        <div class="col-md-6 mb-3">
            <label for="validationDefault01">Tipo plato:</label>
            <asp:DropDownList ID="ddlTiposCartas" runat="server" class="form-control" required autofocus></asp:DropDownList>
        </div>
        <div class="col-md-6 mb-3">
            <label for="validationDefault01">Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server" class="form-control" required></asp:TextBox>
        </div>
        <div class="col-md-6 mb-3">
            <label for="validationDefault02">Descripcion:</label>
            <asp:TextBox ID="txtDescripcion" runat="server" class="form-control" required></asp:TextBox>
        </div>
        <div class="col-md-6 mb-3">
            <label for="validationDefault02">Precio:</label>
            <asp:TextBox ID="txtPrecio" runat="server" step="0.01" class="form-control" TextMode="Number" required></asp:TextBox>
        </div>
        <div class="col-md-6 mb-3">
            <label for="validationDefault02">Archivo Imagen:</label>
            <asp:FileUpload ID="FileUpload1" runat="server" class="form-control" onchange="showimagepreview(this)" required />
        </div>
        <div class="col-md-6 mb-3">
            <label for="validationDefault02">Portada:</label>
            <img src="Images/preview-icon.png" width="150" height="150" />

        </div>
        <div class="col-md-3 mb-3">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-primary btn-md btn-block" OnClick="btnGuardar_Click" />
        </div>
        <div class="col-md-3 mb-3">
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" class="btn btn-info btn-md btn-block" OnClick="btnNuevo_Click" />
        </div>
    </div>
    <hr />
    <script type="text/javascript">

        function showimagepreview(input) {

            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {

                    document.getElementsByTagName("img")[0].setAttribute("src", e.target.result);
                }
                reader.readAsDataURL(input.files[0]);
            }
        }

    </script>

</asp:Content>
