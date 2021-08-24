using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Aplicacao
{
    public class IngressoAplicacao
    {
        private readonly IIngresso<INGRESSO> repositorio;

        public IngressoAplicacao(IIngresso<INGRESSO> repo)
        {
            repositorio = repo;
        }

        public void Salvar(INGRESSO ingresso)
        {
            repositorio.Salvar(ingresso);
        }

        public void Excluir(INGRESSO ingresso)
        {
            repositorio.Excluir(ingresso);
        }

        public IEnumerable<INGRESSO> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public INGRESSO ListarPorId(string Id_Ingresso)
        {
            return repositorio.ListarPorId(Id_Ingresso);
        }
    }
}
