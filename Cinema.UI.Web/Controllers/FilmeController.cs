using Cinema.Aplicacao;
using Cinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.UI.Web.Controllers
{
    public class FilmeController : Controller
    {
        private readonly FilmeAplicacao appFilme;
        private readonly SessaoAplicacao appSessao;

        public FilmeController()
        {
            appFilme = AplicacaoConstrutor.FilmeAplicacao();
            appSessao = AplicacaoConstrutor.SessaoAplicacao();
        }
        public ActionResult Index()
        {
            var listaDeFilmes = appFilme.ListarTodos();
            return View(listaDeFilmes);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(FILME filme)
        {
            if (ModelState.IsValid)
            {
                appFilme.Salvar(filme);
                return RedirectToAction("Index");
            }
            return View(filme);
        }

        public ActionResult Editar(string Id_Filme)
        {
            var filme = appFilme.ListarPorId(Id_Filme);
            if (filme == null)
                return HttpNotFound();
            return View(filme);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(FILME filme)
        {
            if(ModelState.IsValid)
            {
                appFilme.Salvar(filme);
                return RedirectToAction("Index");
            }
            return View(filme);
        }

        public ActionResult Detalhes(string Id_Filme)
        {
            var filme = appFilme.ListarPorId(Id_Filme);
            if (filme == null)
                return HttpNotFound();
            return View(filme);
        }

        public ActionResult Excluir(string Id_Filme)
        {
            var filme = appFilme.ListarPorId(Id_Filme);
            if (filme == null)
                return HttpNotFound();
            return View(filme);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(string Id_Filme)
        {
            var filme = appFilme.ListarPorId(Id_Filme);
            appFilme.Excluir(filme);
            return RedirectToAction("Index");
        }
        
    }
}