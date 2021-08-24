using Cinema.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Aplicacao
{
    public class AplicacaoConstrutor
    {

        public static FilmeAplicacao FilmeAplicacao()
        {
            return new FilmeAplicacao(new FilmeRepositorio());
        }

        public static ClienteAplicacao ClienteAplicacao()
        {
            return new ClienteAplicacao(new ClienteRepositorio());
        }

        public static AssentoSalaAplicacao AssentoSalaAplicacao()
        {
            return new AssentoSalaAplicacao(new AssentoSalaRepositorio());
        }

        public static GeneroAplicacao GeneroAplicacao()
        {
            return new GeneroAplicacao(new GeneroRepositorio());
        }

        public static IngressoAplicacao IngressoAplicacao()
        {
            return new IngressoAplicacao(new IngressoRepositorio());
        }

        public static SessaoAplicacao SessaoAplicacao()
        {
            return new SessaoAplicacao(new SessaoRepositorio());
        }
    }
}
