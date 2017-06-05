<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaInicial.aspx.cs" Inherits="Projeto1Segunda.Views.CadastroFilmesGeneros.PaginaInicial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Cadastro de filmes</h2>
    <asp:Button ID="btnCadastrarFilme" runat="server" Text="Cadastro Filme" Height="59px" OnClick="btnCadastrarFilme_Click" />
    <asp:Button ID="btnCadastrarGenero" runat="server" Text="Cadastrar Gênero" Height="60px" OnClick="btnCadastrarGenero_Click" />
    <asp:Button ID="btnListar" runat="server" Text="Listar" Height="60px" OnClick="btnListar_Click" Width="76px" />
    <asp:Button ID="btnEditar" runat="server" Text="Editar" Height="58px" OnClick="btnEditar_Click" Width="71px" />
</asp:Content>
