using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Aplicacao
{
    public class GeneroAplicacao
    {
        private readonly IGenero<GENERO> repositorio;

        public GeneroAplicacao(IGenero<GENERO> repo)
        {
            repositorio = repo;
        }

        public void Salvar(GENERO genero)
        {
            repositorio.Salvar(genero);
        }

        public void Excluir(GENERO genero)
        {
            repositorio.Excluir(genero);
        }

        public IEnumerable<GENERO> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public GENERO ListarPorId(string Id_Genero)
        {
            return repositorio.ListarPorId(Id_Genero);
        }
    }
}
