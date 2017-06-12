<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Projeto1Segunda.Views.CadastroFilmesGeneros.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="Form-Group">
        <h1>Filmes Cadastrados</h1>
            <asp:GridView ID="gdvFilmes" runat="server" BorderStyle="Outset"></asp:GridView>
            <br />
            <br />
        <asp:Label ID="lblExcluirFilme" runat="server" Text="Digite o ID a excluir:"></asp:Label>
        <asp:TextBox ID="txtBoxIdFilme" runat="server"></asp:TextBox>
        <asp:Button ID="btnExcluirFilme" runat="server" Text="Excluir Filme" OnClick="btnExcluirFilme_Click" />
            <h1>Gêneros Cadastrados </h1>
            <asp:GridView ID="gdvGeneros" runat="server" BorderStyle="Outset"></asp:GridView>
            <br />
            <br />
        <asp:Label ID="lblExcluirGenero" runat="server" Text="Digite o ID a excluir:"></asp:Label>
        <asp:TextBox ID="txtBoxIdGenero" runat="server"></asp:TextBox>
        <asp:Button ID="btnExcluirGenero" runat="server" Text="Excluir Gênero" OnClick="btnExcluirGenero_Click" /><br /><br/>
        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" Width="96px" />
    </div>

    <div id="divMensagens" runat="server"></div>
</asp:Content>
