using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Repositorio
{
    public class FilmeRepositorio : IRepositorio<FILME>
    {
        private readonly CinemaContexto contexto;

        public FilmeRepositorio()
        {
            contexto = new CinemaContexto();
        }

        public void Salvar(FILME entidade)
        {
            if (entidade.Id_Filme > 0)
            {
                var filmeAlterar = contexto.FILME.First(x => x.Id_Filme == entidade.Id_Filme);
                filmeAlterar.Id_Class = entidade.Id_Class;
                filmeAlterar.Nome_Filme = entidade.Nome_Filme;
                filmeAlterar.Sinopse = entidade.Sinopse;
                filmeAlterar.Duracao = entidade.Duracao;
            } else
            {
                contexto.FILME.Add(entidade);
            }
            contexto.SaveChanges();
        }

        public void Excluir(FILME entidade)
        {
            var filmeExcluir = contexto.FILME.First(x => x.Id_Filme == entidade.Id_Filme);
            contexto.Set<FILME>().Remove(filmeExcluir);
            contexto.SaveChanges();
        }

        public IEnumerable<FILME> ListarTodos()
        {
            return contexto.FILME.Include("CLASSIFICACAO")
                .ToList();
        }

        public FILME ListarPorId(string Id_Filme)
        {
            int idInt;
            Int32.TryParse(Id_Filme, out idInt);
            return contexto.FILME.FirstOrDefault(x => x.Id_Filme == idInt);
        }
    }
}
