using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Repositorio
{
    public class ClienteRepositorio : ICliente<CLIENTE>
    {
        private readonly CinemaContexto contexto;

        public ClienteRepositorio()
        {
            contexto = new CinemaContexto();
        }

        public void Salvar(CLIENTE entidade)
        {
            if (entidade.Id_Cliente > 0)
            {
                var filmeAlterar = contexto.CLIENTE.First(x => x.Id_Cliente == entidade.Id_Cliente);
                filmeAlterar.Nome_Cliente = entidade.Nome_Cliente;
                filmeAlterar.CPF = entidade.CPF;
                filmeAlterar.Email = entidade.Email;
                filmeAlterar.Data_Nasc = entidade.Data_Nasc;
            } else
            {
                contexto.CLIENTE.Add(entidade);
            }
            contexto.SaveChanges();
        }

        public void Excluir(CLIENTE entidade)
        {
            var clienteExcluir = contexto.CLIENTE.First(x => x.Id_Cliente == entidade.Id_Cliente);
            contexto.Set<CLIENTE>().Remove(clienteExcluir);
            contexto.SaveChanges();
        }

        public IEnumerable<CLIENTE> ListarTodos()
        {
            return contexto.CLIENTE;
        }

        public CLIENTE ListarPorId(string Id_Cliente)
        {
            int idInt;
            Int32.TryParse(Id_Cliente, out idInt);
            return contexto.CLIENTE.FirstOrDefault(x => x.Id_Cliente == idInt);
        }
    }
}
