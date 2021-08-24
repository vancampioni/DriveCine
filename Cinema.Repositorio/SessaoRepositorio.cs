using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Repositorio
{
    public class SessaoRepositorio : ISessao<SESSAO>
    {
        private readonly CinemaContexto contexto;

        public SessaoRepositorio()
        {
            contexto = new CinemaContexto();
        }
        public void Excluir(SESSAO entidade)
        {
            var sessaoExcluir = contexto.SESSAO.First(x => x.Id_Sessao == entidade.Id_Sessao);
            contexto.Set<SESSAO>().Remove(sessaoExcluir);
            contexto.SaveChanges();
        }

        public void Salvar(SESSAO entidade)
        {
            contexto.SESSAO.Add(entidade);
        }

        public IEnumerable<SESSAO> ListarTodos()
        {
            return contexto.SESSAO.Include("SALA")
                .Include("FILME").ToList();
        }

        public SESSAO ListarPorId(string Id_Sessao)
        {
            int idInt;
            Int32.TryParse(Id_Sessao, out idInt);
            return contexto.SESSAO
                .Include("SALA")
                .Include("FILME")
                .FirstOrDefault(x => x.Id_Sessao == idInt);
        }

        public IEnumerable<SESSAO> ListarVariosPorId(string Id_Sessao)
        {
            int.TryParse(Id_Sessao, out int idInt);
            var sessoes = contexto.SESSAO
                .Include("SALA")
                .Include("FILME")
                .Where(x => x.Id_Filme == idInt);
            return sessoes;
        }
    }
}
