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
    public partial class CadastroGenero1 : System.Web.UI.Page
    {
        string script;
        protected void Page_Load(object sender, EventArgs e)
        {
            GeneroController ctrl = new GeneroController();
            List<Genero> lista = ctrl.ListarGeneros();
            gdvGeneros.DataSource = lista.OrderBy(c => c.Categoria);
            gdvGeneros.DataBind();
        }

        protected void AtualizaLista()
        {
            GeneroController ctrl = new GeneroController();
            List<Genero> lista = ctrl.ListarGeneros();
            gdvGeneros.DataSource = lista.OrderBy(c => c.Categoria);
            gdvGeneros.DataBind();
        }

        protected void btnSalvarFilme_Click(object sender, EventArgs e)
        {
            GeneroController ctrl = new GeneroController();
            Genero genero = new Genero();
            genero.Categoria = txtNomeCategoria.Text;
            if(ctrl.buscarGeneroPorNome(genero) == null)
            {
                genero.Categoria = txtNomeCategoria.Text;
                genero.Ativo = true;
                if(ctrl.Adicionar(genero) == true)
                {
                    script = "alert(\"Sucesso!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }
                else
                {
                    script = "alert(\"Gênero já cadastrado!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }
            }
            txtNomeCategoria.Text = "";
            AtualizaLista();
        }

        protected void btnExcluirGenero_Click(object sender, EventArgs e)
        {
            GeneroController ctrl = new GeneroController();
            Genero genero = new Genero();
            genero.Categoria = txtNomeCategoria.Text;
            genero = ctrl.buscarGeneroPorNome(genero);
            if (genero != null)
            {
                ctrl.Excluir(genero);
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaInicial.aspx");
        }

        protected void btnCadastroFilmes_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroFilme.aspx");
        }
    }
}