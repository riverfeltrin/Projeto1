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
    public partial class Lista : BasePage
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
            Response.Redirect("PaginaInicial.aspx");
        }

        protected void btnExcluirFilme_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            filme.Id = int.Parse(txtBoxIdFilme.Text);
            filme = ctrlf.BuscarFilmePorId(filme);
            if(filme != null)
            {
                ctrlf.Excluir(filme);
                AtualizaLista();
            }
            txtBoxIdFilme.Text = string.Empty;
        }

        protected void btnExcluirGenero_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            genero.Id = int.Parse(txtBoxIdGenero.Text);
            genero = ctrlg.BuscarGeneroPorId(genero);
            if(genero != null)
            {
                ctrlg.Excluir(genero);
                AtualizaLista();
            }
            txtBoxIdGenero.Text = string.Empty;
        }
    }
}