using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Aplicacao
{
    public class ClienteAplicacao
    {
        private readonly ICliente<CLIENTE> repositorio;

        public ClienteAplicacao(ICliente<CLIENTE> repo)
        {
            repositorio = repo;
        }

        public void Salvar(CLIENTE cliente)
        {
            repositorio.Salvar(cliente);
        }

        public void Excluir(CLIENTE cliente)
        {
            repositorio.Excluir(cliente);
        }

        public IEnumerable<CLIENTE> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public CLIENTE ListarPorId(string Id_Cliente)
        {
            return repositorio.ListarPorId(Id_Cliente);
        }
    }
}
