using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Dominio.contrato
{
    public interface IAssento<T> where T : class
    {
        void Salvar(T entidade);

        void Excluir(T entidade);

        IEnumerable<T> ListarTodos();

        T ListarPorId(string Id_Assento);

        IEnumerable<T> ListarVariosPorId(string Id_Assento);
    }
}
