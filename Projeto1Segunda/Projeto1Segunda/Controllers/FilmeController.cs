using Projeto1Segunda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto1Segunda.Controllers
{
    public class FilmeController : BasePage
    {
        public bool AdicionarFilme(Filme filme)
        {
            try
            {
                if (filme != null)
                {
                    contexto.Filmes.Add(filme);
                    contexto.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public List<Filme> ListarFilmesAtivos()
        {
            return contexto.Filmes.Where(c => c.Ativo == true).ToList();
        }

        public List<Filme> Listar()
        {
            return contexto.Filmes.ToList();
        }
        public Filme buscarFilmePorNome(Filme filme)
        {
            return contexto.Filmes.FirstOrDefault(c => c.Nome == filme.Nome);
        }

        public Filme BuscarFilmePorId(Filme filme)
        {
            int id = filme.Id;
            return contexto.Filmes.Find(id);
        }

        public void Excluir(Filme filme)
        {
            filme.Ativo = false;

            contexto.Entry(filme).State = System.Data.Entity.EntityState.Deleted;

            contexto.SaveChanges();
        }
        public void Editar(Filme filme)
        {
            contexto.Entry(filme).State = System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }
    }
}
