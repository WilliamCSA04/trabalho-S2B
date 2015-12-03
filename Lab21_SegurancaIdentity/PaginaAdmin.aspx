<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaAdmin.aspx.cs" Inherits="ReclamaPoaS2B.PaginaAdmin" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

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
                <asp:ListItem Text="Categoria" Value="1"></asp:ListItem>
                <asp:ListItem Text="Bairro" Value="2"></asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="Label6" runat="server" Text="Data inicial"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1"/>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Data Final"></asp:Label>    
    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="TextBox2"/>
    <br />
    <asp:TextBox ID="TextBoxCalcular1" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Button ID="Button1" type="button" class="btn btn-primary" runat="server" Text="Calcular" OnClick="Calcular1"/>
    <br />
    <H3>Numero médio de comentarios</H3>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Filtar:"></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server"
        RepeatDirection="Horizontal" RepeatLayout="Table">
                <asp:ListItem Text="Categoria" Value="1"></asp:ListItem>
                <asp:ListItem Text="Bairro" Value="2"></asp:ListItem>
                <asp:ListItem Text="Periodo" Value="3"></asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="Label9" runat="server" Text="Data inicial"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender3" runat="server" TargetControlID="TextBox3"/>
    <br />
    <asp:Label ID="Label10" runat="server" Text="Data Final"></asp:Label>    
    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender4" runat="server" TargetControlID="TextBox4"/>
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
