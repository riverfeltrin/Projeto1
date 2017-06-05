using Projeto1Segunda.Controllers;
using Projeto1Segunda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto1Segunda.Views.CadastroFilmesGeneros
{
    public partial class Editar : BasePage
    {
        FilmeController ctrlf = new FilmeController();
        GeneroController ctrlg = new GeneroController();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Filme> filmes = ctrlf.Listar();
            gdvFilmes.DataSource = filmes.OrderBy(c => c.Nome);
            gdvFilmes.DataBind();
            List<Genero> lista = ctrlg.ListarGeneros();
            gdvGeneros.DataSource = lista.OrderBy(c => c.Categoria);
            gdvGeneros.DataBind();
        }

        protected void AtualizaLista()
        {
            List<Filme> filmes = ctrlf.Listar();
            gdvFilmes.DataSource = filmes.OrderBy(c => c.Nome);
            gdvFilmes.DataBind();
            List<Genero> lista = ctrlg.ListarGeneros();
            gdvGeneros.DataSource = lista.OrderBy(c => c.Categoria);
            gdvGeneros.DataBind();
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Editar.aspx");
        }

    }
}