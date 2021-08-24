using Cinema.Dominio;
using Cinema.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Repositorio
{
    public class GeneroRepositorio : IGenero<GENERO>
    {
        private readonly CinemaContexto contexto;

        public GeneroRepositorio()
        {
            contexto = new CinemaContexto();
        }

        public void Salvar(GENERO entidade)
        {
            if (entidade.Id_Genero > 0)
            {
                var generoAlterar = contexto.GENERO.FirstOrDefault(x => x.Id_Genero == entidade.Id_Genero);
                generoAlterar.Descricao_Genero = entidade.Descricao_Genero;
            } else
            {
                contexto.GENERO.Add(entidade);
            }
            contexto.SaveChanges();
        }

        public void Excluir(GENERO entidade)
        {
            var generoExcluir = contexto.GENERO.FirstOrDefault(x => x.Id_Genero == entidade.Id_Genero);
            contexto.Set<GENERO>().Remove(generoExcluir);
            contexto.SaveChanges();
        }

        public IEnumerable<GENERO> ListarTodos()
        {
            return contexto.GENERO;
        }

        public GENERO ListarPorId(string Id_Genero)
        {
            int idInt;
            Int32.TryParse(Id_Genero, out idInt);
            return contexto.GENERO.FirstOrDefault(x => x.Id_Genero == idInt);
        }
    }
}
