<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfmCarta.aspx.cs" Inherits="webRestaurante.wfmCarta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>
        <img src="Icons/menu.ico" width="30" height="30">
        Registro de tipo carta o menu</h3>
    <hr />
    <div class="form-row">
        <div class="col-md-6 mb-3">
            <label for="validationDefault01">Nombre o tipo plato:</label>
            <asp:TextBox ID="txtNombre" runat="server" class="form-control" required autofocus></asp:TextBox>
        </div>
        <div class="col-md-6 mb-3">
           
        </div>
        <div class="col-md-3 mb-3">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-primary btn-md btn-block" OnClick="btnGuardar_Click" />
        </div>
        <div class="col-md-3 mb-3">
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" class="btn btn-info btn-md btn-block" OnClick="btnNuevo_Click" />
        </div>
    </div>
    <hr />
</asp:Content>
