<%@ Page Title="Categorias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="ReclamaPoaS2B.Categorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <link href="Content/Categoria.css" rel="stylesheet" type="text/css">
    
   <br />
     <asp:DropDownList ID="ddlCategorias" runat="server"></asp:DropDownList>
<br />
 <br />
    <asp:Label ID="Label2" runat="server" Text="Informe o nome: "></asp:Label>
    <asp:TextBox class="Box" ID="txtNome" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label  ID="Label3" runat="server" Text="Informe a descrição: "></asp:Label>
    <asp:TextBox class="Box" ID="txtDescricao" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="cmdInserir" 
        runat="server" Text="Inserir" OnClick="cmdInserir_Click" />

</asp:Content>

