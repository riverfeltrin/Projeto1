<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroGenero.aspx.cs" Inherits="Projeto1Segunda.Views.CadastroFilmesGeneros.CadastroGenero1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
    <ContentTemplate>
        <div class ="form-group">
        <asp:Label ID="lblNomeCategoria" runat="server" Text="Nome novo gênero:  "></asp:Label><br />
        <asp:TextBox ID="txtNomeCategoria" runat="server" Width="140px"></asp:TextBox><br />
        </div>

        <div class ="form-group">
        <asp:Label ID="lblGeneros" runat="server" Text="Gêneros cadastrados: "></asp:Label><br />
        <asp:GridView ID="gdvGeneros" runat="server" BorderStyle="Outset"></asp:GridView>
        <br />
        </div>
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Button ID="btnSalvarGenero" runat="server" Text="Salvar" OnClick="btnSalvarFilme_Click" Width="49px" /><br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" /><br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCadastroFilmes" runat="server" Text="Filme" OnClick="btnCadastroFilmes_Click" />
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
