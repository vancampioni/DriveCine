using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Dominio.contrato
{
    public interface IAssentoSala<T> where T : class 
    {
        void Salvar(T entidade);

        IEnumerable<T> ListarTodos();

        T ListarPorId(string Id_AssentoSala);

        IEnumerable<T> ListarVariosPorId(string Id_AssentoSala);

        IEnumerable<T> ListarPorSala(string Id_Sala);
    }
}
