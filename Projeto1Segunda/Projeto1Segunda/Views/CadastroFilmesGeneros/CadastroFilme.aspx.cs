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
    public partial class CadastroGenero : System.Web.UI.Page
    {
        string script;
        protected void Page_Load(object sender, EventArgs e)
        {
            FilmeController ctrl = new FilmeController();
            GeneroController ctrlg = new GeneroController();
            List<Genero> lista = ctrlg.ListarGenerosAtivos();
            gdvFilmeGenero.DataSource = lista.OrderBy(c => c.Categoria);
            gdvFilmeGenero.DataBind();


            if (!IsPostBack)
            {
                GeneroController generocontroller = new GeneroController();
                ddlGenero.DataSource = generocontroller.ListarGenerosAtivos();
                ddlGenero.DataBind();
            }
        }
        protected void AtualizaLista()
        {
            GeneroController ctrlg = new GeneroController();
            List<Genero> lista = ctrlg.ListarGenerosAtivos();
            gdvFilmeGenero.DataSource = lista.OrderBy(c => c.Categoria);
            gdvFilmeGenero.DataBind();
        }

        protected void btnSalvarFilme_Click(object sender, EventArgs e)
        {
        
            GeneroController generocontroller = new GeneroController();
            FilmeController ctrl = new FilmeController();
            Filme filme = new Filme();
            Genero genero = new Genero();
            filme.Nome = txtNomeFilme.Text;
            if (ctrl.buscarFilmePorNome(filme) == null)
            {
                filme.Nome = txtNomeFilme.Text;
                filme.Sinopse = txtSinopse.Text;
                genero.Id = int.Parse(ddlGenero.SelectedValue);//int.Parse(txtBoxGenero.Text);
                filme.Genero = generocontroller.BuscarGeneroPorId(genero);
                filme.Ativo = true;
                if(ctrl.AdicionarFilme(filme) == true)
                {
                    script = "alert(\"Sucesso!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }
                else
                {
                    script = "alert(\"Não foi possível cadastrar!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }
            }
            txtNomeFilme.Text = "";
            txtSinopse.Text = "";
            AtualizaLista();
            
        }

        protected void btnExcluirFilme_Click(object sender, EventArgs e)
        {
            FilmeController ctrl = new FilmeController();
            Filme filme = new Filme();
            filme.Nome = txtNomeFilme.Text;
            filme = ctrl.buscarFilmePorNome(filme);
            if(filme != null)
            {
                ctrl.Excluir(filme);
                AtualizaLista();
            }

        }

        protected void txtNomeFilme_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaInicial.aspx");
        }

        protected void btnCadastroGenero_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroGenero.aspx");
        }
    }
}