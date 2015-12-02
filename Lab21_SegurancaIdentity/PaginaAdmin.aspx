<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaAdmin.aspx.cs" Inherits="ReclamaPoaS2B.PaginaAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Categoria.css" rel="stylesheet" type="text/css">
    <h2>Adicionar Categorias</h2>
   <br />
     <asp:DropDownList ID="ddlCategorias" runat="server"></asp:DropDownList>
<br />
 <br />
    <asp:Label ID="Label2" runat="server" Text="Informe o nome: "></asp:Label>
    <asp:TextBox class="Box" ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <br />
    <asp:Label  ID="Label3" runat="server" Text="Informe a descrição: "></asp:Label>
    <asp:TextBox class="Box" ID="txtDescricao" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="cmdInserir" type="button" class="btn btn-primary" runat="server" Text="Inserir" OnClick="cmdInserir_Click" />
    <br />
    <br />
    <h2>Habilitar Contas Oficiais</h2>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="cmdAdicionar" type="button" class="btn btn-primary" runat="server" Text="Adicionar" />
    <br />
    <br />
    <h2>Dados estatisticos</h2>
    <br />
    <br />
    <H3>total de reclamações por categoria ou bairros em um periodo</H3>
    <br />
    <asp:RadioButtonList ID="RadioButtonList2" runat="server"
        RepeatDirection="Horizontal" RepeatLayout="Table">
                <asp:ListItem Text="Categoria" Value="Categoria"></asp:ListItem>
                <asp:ListItem Text="Bairro" Value="Bairro"></asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="Label6" runat="server" Text="Data inicial"></asp:Label>
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <asp:Label ID="Label7" runat="server" Text="Data Final"></asp:Label>    
    <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
    <input id="Text1" type="text" />
    <asp:Button ID="Button1" type="button" class="btn btn-primary" runat="server" Text="Calcular" OnClick="Calcular1"/>
    <br />
    <H3>Numero médio de comentarios</H3>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Filtar:"></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server"
        RepeatDirection="Horizontal" RepeatLayout="Table">
                <asp:ListItem Text="Categoria" Value="Categoria"></asp:ListItem>
                <asp:ListItem Text="Bairro" Value="Bairro"></asp:ListItem>
                <asp:ListItem Text="Periodo" Value="Periodo"></asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="Label9" runat="server" Text="Data inicial"></asp:Label>
    <asp:Calendar ID="Calendar5" runat="server"></asp:Calendar>
    <asp:Label ID="Label10" runat="server" Text="Data Final"></asp:Label>    
    <asp:Calendar ID="Calendar6" runat="server"></asp:Calendar>
    <input id="Text2" type="text" />
    <asp:Button ID="Button3" type="button" class="btn btn-primary" runat="server" Text="Calcular" OnClick="Calcular2"/>
    <br />

    <H3>Percentual de reclamações resolvidas</H3>
    <br />
    <input id="Text4" type="text" />
    <asp:Button ID="Button2" type="button" class="btn btn-primary" runat="server" Text="Calcular" OnClick="Calcular3"/>
    <br />

    <H3>Percentual de reclamações respondidas e encerradas por orgãos publicos</H3>
    <br />
    <input id="Text3" type="text" />
    <asp:Button ID="Button4" type="button" class="btn btn-primary" runat="server" Text="Calcular" OnClick="Calcular4"/>

</asp:Content>
