using Cinema.Aplicacao;
using Cinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.UI.Web.Controllers
{
    public class SessaoController : Controller
    {
        private readonly SessaoAplicacao appSessao;

        public SessaoController()
        {
            appSessao = AplicacaoConstrutor.SessaoAplicacao();
        }
        public ActionResult Index()
        {
            var listaDeSessoes = appSessao.ListarTodos();
            return View(listaDeSessoes);
        }

        public ActionResult SessoesDisponiveis(string Id_Filme)
        {
            var sessaoFilme = appSessao.ListarVariosPorId(Id_Filme);
            return View(sessaoFilme);
        }
    }
}