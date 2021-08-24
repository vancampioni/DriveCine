using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Repositorio
{
    public class IngressoRepositorio : IIngresso<INGRESSO>
    {
        private readonly CinemaContexto contexto;

        public IngressoRepositorio()
        {
            contexto = new CinemaContexto();
        }

        public void Salvar(INGRESSO entidade)
        {
            if (entidade.Id_Ingresso > 0)
            {
                var ingressoAlterar = contexto.INGRESSO.FirstOrDefault(x => x.Id_Ingresso == entidade.Id_Ingresso);
                ingressoAlterar.Id_Cliente = entidade.Id_Cliente;
                ingressoAlterar.Id_TipoIngresso = entidade.Id_TipoIngresso;
                ingressoAlterar.Id_Filme = entidade.Id_Filme;
                ingressoAlterar.Id_Sessao = entidade.Id_Sessao;
                ingressoAlterar.Id_Sala = entidade.Id_Sala;
                ingressoAlterar.Id_Assento = entidade.Id_Assento;
                ingressoAlterar.Data_Venda = entidade.Data_Venda;
            } else
            {
                contexto.INGRESSO.Add(entidade);
            }
            contexto.SaveChanges();
        }

        public void Excluir(INGRESSO entidade)
        {
            var ingressoExcluir = contexto.INGRESSO.FirstOrDefault(x => x.Id_Ingresso == entidade.Id_Ingresso);
            contexto.Set<INGRESSO>().Remove(ingressoExcluir);
            contexto.SaveChanges();
        }

        public IEnumerable<INGRESSO> ListarTodos()
        {
            return contexto.INGRESSO.Include("CLIENTE")
                .Include("TIPO_INGRESSO")
                .Include("FILME")
                .Include("SALA")
                .Include("SESSAO")
                .Include("ASSENTO").ToList();
        }
       
        public INGRESSO ListarPorId(string Id_Ingresso)
        {
            int idInt;
            Int32.TryParse(Id_Ingresso, out idInt);
            return contexto.INGRESSO.FirstOrDefault(x => x.Id_Ingresso == idInt);
        }

    }
}
