<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroFilme.aspx.cs" Inherits="Projeto1Segunda.Views.CadastroFilmesGeneros.CadastroGenero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <h2>Para Cadastrar um filme preencha todos os dados, para excluir só escrever o ID do painel!</h2>
        <asp:Label ID="lblNomeFilme" runat="server" Text="Filme:  "></asp:Label>
        <br />
        <asp:TextBox ID="txtNomeFilme" runat="server" Width="140px" OnTextChanged="txtNomeFilme_TextChanged"></asp:TextBox><br />

        <asp:Label ID="lblSinopse" runat="server" Text="Sinopse:  "></asp:Label><br />
        <asp:TextBox ID="txtSinopse" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="lblGeneros" runat="server" Text="Gêneros cadastrados: "></asp:Label><br />
        <asp:GridView ID="gdvFilmeGenero" runat="server" BorderStyle="Outset"></asp:GridView>
        <br />

        <asp:Label ID="lblEscolhaGenero" runat="server" Text="Escolha a categoria no painel: "></asp:Label><br />

        <asp:DropDownList ID="ddlGenero" runat="server" DataTextField="Categoria" DataValueField="Id"></asp:DropDownList>
        <asp:Button ID="btnSalvarFilme" runat="server" Text="Salvar" OnClick="btnSalvarFilme_Click" Width="49px" /><br />
        <br />
        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
        <asp:Button ID="btnCadastroGenero" runat="server" Text="Gênero" OnClick="btnCadastroGenero_Click" />
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
