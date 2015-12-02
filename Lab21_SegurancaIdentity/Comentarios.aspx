<%@ Page Title="Comentarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comentarios.aspx.cs" Inherits="ReclamaPoaS2B.Comentarios" %>
<%@ PreviousPageType VirtualPath="~/Reclamacoes.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label ID="Label1" runat="server" Text="Reclamação:"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxDescricao" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Comentarios" ></asp:Label>
    <br />

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Novo comentario:"></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Nome:"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxNome" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Insira seu comentario"></asp:Label>
    <br />
    <asp:TextBox ID="txtBoxComentario" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Button ID="ButtonComentario" type="button" class="btn btn-primary" runat="server" Text="Publicar" OnClick="ButtonComentario_Click" />
    <asp:Button ID="ButtonFechar" type="button" class="btn btn-primary" runat="server" Text="Marcar como Fechada" OnClick="ButtonFechar_Click" />
</asp:Content>
