using Cinema.Aplicacao;
using Cinema.Dominio;
using Cinema.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.UI.Web.Controllers
{
    public class AssentoSalaController : Controller
    {
        private readonly AssentoSalaAplicacao appAssento;
        private readonly SessaoAplicacao appSessao;


        public AssentoSalaController()
        {
            appAssento = AplicacaoConstrutor.AssentoSalaAplicacao();
            appSessao = AplicacaoConstrutor.SessaoAplicacao();
        }
        public ActionResult Index()
        {
            var listaDeAssentos = appAssento.ListarTodos();
            return View(listaDeAssentos);
        }

        //public ActionResult Editar(string Id_Assento)
        //{
        //    var assento = appAssento.ListarPorId(Id_Assento);
        //    if (assento == null)
        //        return HttpNotFound();
        //    return View(assento);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Editar(ASSENTO assento)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        appAssento.Salvar(assento);
        //        return RedirectToAction("Index");
        //    }
        //    return View(assento);
        //}

        public ActionResult AssentosDisponíveis(string Id_Sessao)
        {
            var assentosSessao = appSessao.ListarVariosPorId(Id_Sessao);
            return View(assentosSessao);
        }

        public ActionResult ListarPorSala(string Id_Sala)
        {
            var assentos = appAssento.ListarPorSala(Id_Sala);
            return View(assentos);
        }
    }
}