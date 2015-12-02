<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reclamacoes.aspx.cs" Inherits="ReclamaPoaS2B.Reclamacoes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Reclamacao.css" rel="stylesheet" type="text/css">
    <br />
    <h2>Inserira sua reclamação</h2>
    <br />
    <asp:DropDownList ID="ddlReclamacoes" runat="server"></asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="c" runat="server" Text="Reclamação: "></asp:Label>
    <asp:TextBox ID="txtTitulo" runat="server" Width="538px"></asp:TextBox>
    <br />
    <br />

    <asp:Label ID="Label3" runat="server" Text="Categoria: "></asp:Label>
    <asp:DropDownList ID="ddlCategoria" runat="server" Width="175px"></asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="cmdInserir" runat="server" Text="Inserir" OnClick="cmdInserir_Click" />
    <br />
    <br />

    <h2>Reclamações já feitas</h2>
    <br />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <br />
    <asp:Button ID="cmdComentario" runat="server" Text="Comentarios" OnClick="cmdComentario_Click"/>

</asp:Content>
