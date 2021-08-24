using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Aplicacao
{
    public class AssentoSalaAplicacao
    {
        private readonly IAssentoSala<ASSENTOSALA> repositorio;

        public AssentoSalaAplicacao(IAssentoSala<ASSENTOSALA> repo)
        {
            repositorio = repo;
        }

        public void Salvar(ASSENTOSALA assento)
        {
            repositorio.Salvar(assento);
        }

        //public void Excluir(ASSENTOSALA assento)
        //{
        //    repositorio.Excluir(assento);
        //}

        public IEnumerable<ASSENTOSALA> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public ASSENTOSALA ListarPorId(string Id_Assento)
        {
            return repositorio.ListarPorId(Id_Assento);
        }

        public IEnumerable<ASSENTOSALA> ListarVariosPorId(string Id_Assento)
        {
            return repositorio.ListarVariosPorId(Id_Assento);
        }

        public IEnumerable<ASSENTOSALA> ListarPorSala(string Id_Sala)
        {
            return repositorio.ListarPorSala(Id_Sala);
        }
    }
}
