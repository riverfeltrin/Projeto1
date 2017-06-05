<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="Projeto1Segunda.Views.CadastroFilmesGeneros.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <h2>Para Editar preencha os campos desejados</h2>
        <div class ="form-group">
        <asp:Label ID="lblNomeFilme" runat="server" Text="Filme:  "></asp:Label>
        <br />
        <asp:TextBox ID="txtNomeFilme" runat="server" Width="140px" OnTextChanged="txtNomeFilme_TextChanged"></asp:TextBox><br />

        <asp:Label ID="lblSinopse" runat="server" Text="Sinopse:  "></asp:Label><br />
        <asp:TextBox ID="txtSinopse" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="lblFilmes" runat="server" Text="Filmes cadastrados: "></asp:Label><br />
        <asp:GridView ID="gdvFilmes" runat="server" BorderStyle="Outset"></asp:GridView>
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEditarFilmes" runat="server" Text="Editar" Height="36px" Width="68px" />
        </div>
        

        <div class ="form-group">
        <asp:Label ID="lblEditarCategoria" runat="server" Text="Gênero:  "></asp:Label><br />
        <asp:TextBox ID="txtEditarCategoria" runat="server" Width="140px"></asp:TextBox><br />
        <br/>
        <asp:Label ID="lblGeneros" runat="server" Text="Gêneros cadastrados: "></asp:Label><br />
        <asp:GridView ID="gdvGeneros" runat="server" BorderStyle="Outset"></asp:GridView>
        <br />
        </div>
       
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
        <asp:Button ID="btnEditarGenero" runat="server" Text="Editar" OnClick="btnSalvarFilme_Click" Width="69px" Height="29px" /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" Width="69px" />
        
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
