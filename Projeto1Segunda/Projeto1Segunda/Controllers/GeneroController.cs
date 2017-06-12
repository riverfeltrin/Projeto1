using Projeto1Segunda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto1Segunda.Controllers
{
    public class GeneroController : BasePage
    {
        public bool Adicionar(Genero genero)
        {
            try
            {
                if (genero != null)
                {
                    contexto.Generos.Add(genero);
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

        public List<Genero> ListarGenerosAtivos()
        {
            return contexto.Generos.Where(c => c.Ativo == true ).ToList();
        }

        public List<Genero> ListarGeneros()
        {
            return contexto.Generos.ToList();
        }

        public Genero buscarGeneroPorNome(Genero genero)
        {
            return contexto.Generos.FirstOrDefault(c => c.Categoria == genero.Categoria);
        }

        public Genero BuscarGeneroPorId(Genero genero)
        {
            int id = genero.Id;
            return contexto.Generos.Find(id);
        }

        public void Excluir(Genero genero)
        {
            try
            {
                genero.Ativo = false;

                contexto.Entry(genero).State = System.Data.Entity.EntityState.Deleted;

                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public void Editar(Genero genero)
        {
            contexto.Entry(genero).State = System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }
    }
}