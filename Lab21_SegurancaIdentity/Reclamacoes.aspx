<%@ Page Title="Reclamacoes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reclamacoes.aspx.cs" Inherits="ReclamaPoaS2B.Reclamacoes" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
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
    <asp:Label ID="label9" runat="server" Text="Data em que foi visto: "></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender3" runat="server" TargetControlID="TextBox3"/>
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
                <asp:ListItem Text="Categoria" Value="1"></asp:ListItem>
                <asp:ListItem Text="Bairro" Value="2"></asp:ListItem>
                <asp:ListItem Text="Nenhum" Value="0"></asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="Label7" runat="server" Text="Data inicial"></asp:Label>

    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1"/>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Data Final"></asp:Label>  
    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="TextBox2"/>  
    <asp:Button ID="cmdFiltrar" type="button" class="btn btn-danger" runat="server" Text="Filtrar" OnClick="cmdFiltrar_Click"/>
    <asp:GridView ID="GridView1" class="Grid" runat="server"></asp:GridView>
    <br />
    <asp:Button ID="cmdComentario" type="button" class="btn btn-danger" runat="server" Text="Comentarios" OnClick="cmdComentario_Click"/>
    <asp:Button ID="cmdEditar" type="button" class="btn btn-danger" runat="server" Text="Editar" OnClick="cmdEditar_Click"/>

</asp:Content>
