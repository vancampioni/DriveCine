using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Repositorio
{
    public class AssentoSalaRepositorio : IAssentoSala<ASSENTOSALA>
    {
        private readonly CinemaContexto contexto;

        public AssentoSalaRepositorio()
        {
            contexto = new CinemaContexto();
        }

        public void Salvar(ASSENTOSALA entidade)
        {
            contexto.ASSENTOSALA.Add(entidade);
        }

        //public void Excluir(ASSENTO entidade)
        //{
        //    var assentoExcluir = contexto.ASSENTO.FirstOrDefault(x => x.Id_Assento == entidade.Id_Assento);
        //    contexto.Set<ASSENTO>().Remove(assentoExcluir);
        //    contexto.SaveChanges();
        //}

        public IEnumerable<ASSENTOSALA> ListarTodos()
        {
            return contexto.ASSENTOSALA;
        }

        public ASSENTOSALA ListarPorId(string Id_AssentoSala)
        {
            int idInt;
            Int32.TryParse(Id_AssentoSala, out idInt);
            return contexto.ASSENTOSALA.FirstOrDefault(x => x.Id_AssentoSala == idInt);
        }

        public IEnumerable<ASSENTOSALA> ListarVariosPorId(string Id_AssentoSala)
        {
            int.TryParse(Id_AssentoSala, out int idInt);
            return contexto.ASSENTOSALA.Where(x => x.Id_AssentoSala == idInt).ToList();
        }

        public IEnumerable<ASSENTOSALA> ListarPorSala(string Id_Sala)
        {
            int.TryParse(Id_Sala, out int IdInt);
            return contexto.ASSENTOSALA
                .Include("ASSENTO")
            .Where(x => x.Id_Sala == IdInt).ToList();


        }
    }
}
