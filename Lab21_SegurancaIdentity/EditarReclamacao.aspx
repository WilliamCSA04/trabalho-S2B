<%@ Page Title="Editar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarReclamacao.aspx.cs" Inherits="ReclamaPoaS2B.EditarReclamacao" %>
<%@ PreviousPageType VirtualPath="~/Reclamacoes.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edite sua reclamação</h2>
    <br />
    <br />
    <asp:Label ID="label1" runat="server" Text="Titulo: "></asp:Label>
    <br />
    <asp:TextBox ID="textTitulo" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="label2" runat="server" Text="Reclamação: "></asp:Label>
    <br />
    <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="label4" runat="server" Text="Bairro: "></asp:Label>
    <br />
    <asp:TextBox ID="TextBairro" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="label5" runat="server" Text="Endereço: "></asp:Label>
    <br />
    <asp:TextBox ID="TextEndereco" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <br />
    <br />
    <br />
    <asp:Button ID="cmdEditar" type="button" class="btn btn-danger" runat="server" Text="Editar" OnClick="cmdEditar_Click"/>
    <asp:Label ID="Label3" runat="server" Text="Categoria: "></asp:Label>
</asp:Content>
