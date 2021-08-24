using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Aplicacao
{
    public class SessaoAplicacao
    {
        private readonly ISessao<SESSAO> repositorio;

        public SessaoAplicacao(ISessao<SESSAO> repo)
        {
            repositorio = repo;
        }

        public void Salvar(SESSAO sessao)
        {
            repositorio.Salvar(sessao);
        }

        public void Excluir(SESSAO sessao)
        {
            repositorio.Excluir(sessao);
        }

        public IEnumerable<SESSAO> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public SESSAO ListarPorId(string Id_Sessao)
        {
            return repositorio.ListarPorId(Id_Sessao);
        }

        public IEnumerable<SESSAO> ListarVariosPorId(string Id_Sessao)
        {
            return repositorio.ListarVariosPorId(Id_Sessao);
        }
    }
}
