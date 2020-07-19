<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfmInicio.aspx.cs" Inherits="webRestaurante.wfmInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Inicio</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>
        <asp:Label ID="Label1" runat="server" Text="Menu del dia"></asp:Label>
    </h3>
    <br />
    <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" RepeatColumns="3" Width="729px">
        <ItemTemplate>
            <table>
                <tr>
                    <td align="center">
                        <asp:ImageButton ID="ImageButton1" runat="server" Width="200px" Height="200px" ImageUrl='<%#Eval("Url") %>' />
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Label ID="lblNombre" runat="server" Text='<%#Eval("Nombre") %>'></asp:Label>
                        <br />
                        <asp:Label ID="lblDescripcion" runat="server" Text='<%#Eval("Descripcion") %>'></asp:Label>
                        <br />
                        <strong>USD $: <asp:Label ID="lblPrecio" runat="server" Text='<%#Eval("Precio") %>'></asp:Label></strong>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:ImageButton ID="ImageButton2" runat="server" Width="100px" Height="30px" CommandName="Comprar" CommandArgument='<%#Eval("ID") %>' ImageUrl="~/Images/order now.png" />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
