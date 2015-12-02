<%@ Page Title="Reclamacoes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reclamacoes.aspx.cs" Inherits="ReclamaPoaS2B.Reclamacoes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Reclamacao.css" rel="stylesheet" type="text/css">
    <br />
    <h2>Insira sua reclamação</h2>
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

    <asp:Label ID="Label3" runat="server" Text="Categoria: "></asp:Label>
    <asp:DropDownList ID="ddlCategoria" runat="server" Width="175px"></asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="cmdInserir" runat="server" type="button" class="btn btn-danger" Text="Inserir" OnClick="cmdInserir_Click" />
    <br />
    <br />

    <h2>Reclamações já feitas</h2>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Filtrar: "></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList2" runat="server"
        RepeatDirection="Horizontal" RepeatLayout="Table">
                <asp:ListItem Text="Categoria" Value="Categoria"></asp:ListItem>
                <asp:ListItem Text="Bairro" Value="Bairro"></asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="Label7" runat="server" Text="Data inicial"></asp:Label>
    <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
    <asp:Label ID="Label8" runat="server" Text="Data Final"></asp:Label>    
    <asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
    <asp:Button ID="cmdFiltrar" type="button" class="btn btn-danger" runat="server" Text="Filtrar" OnClick="cmdFiltrar_Click"/>
    <asp:GridView ID="GridView1" class="Grid" runat="server"></asp:GridView>
    <br />
    <asp:Button ID="cmdComentario" type="button" class="btn btn-danger" runat="server" Text="Comentarios" OnClick="cmdComentario_Click"/>
    <asp:Button ID="cmdEditar" type="button" class="btn btn-danger" runat="server" Text="Editar" OnClick="cmdEditar_Click"/>

</asp:Content>
