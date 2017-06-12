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

          /*  if (!IsPostBack)
            {
                GeneroController generocontroller = new GeneroController();
                ddlGenero.DataSource = generocontroller.ListarGenerosAtivos();
                ddlGenero.DataBind();
            }*/
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

        protected void btnEditarFilmes_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            Filme filme = new Filme();
            filme.Nome = txtNomeFilme.Text;
            filme = ctrlf.buscarFilmePorNome(filme);
            if (filme != null)
            {
                filme.Nome = txtNovoNome.Text;
                filme.Sinopse = txtSinopse.Text;
                //filme.Genero.Id = int.Parse(ddlGenero.SelectedValue);
                filme.Ativo = true;
                ctrlf.Editar(filme);
                AtualizaLista();
            }
            txtNomeFilme.Text = "";
            txtNovoNome.Text = "";
            txtSinopse.Text = "";

        }

        protected void btnEditarGenero_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            genero.Categoria = txtNomeCategoria.Text;
            genero = ctrlg.buscarGeneroPorNome(genero);
            if (genero != null)
            {
                genero.Categoria = txtNovoGenero.Text;
                ctrlg.Editar(genero);
                AtualizaLista();
            }
            txtNomeCategoria.Text = "";
            txtNovoGenero.Text = "";
        }
    }
}