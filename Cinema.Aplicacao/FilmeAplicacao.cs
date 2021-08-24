using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Aplicacao
{
    public class FilmeAplicacao
    {
        private readonly IRepositorio<FILME> repositorio;

        public FilmeAplicacao(IRepositorio<FILME> repo)
        {
            repositorio = repo;
        }

        public void Salvar(FILME filme)
        {
            repositorio.Salvar(filme);
        }

        public void Excluir(FILME filme)
        {
            repositorio.Excluir(filme);
        }

        public IEnumerable<FILME> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public FILME ListarPorId(string Id_Filme)
        {
            return repositorio.ListarPorId(Id_Filme);
        }
    }
}
