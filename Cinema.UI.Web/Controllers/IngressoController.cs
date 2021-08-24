using Cinema.Aplicacao;
using Cinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.UI.Web.Controllers
{
    public class IngressoController : Controller
    {
        private readonly IngressoAplicacao appIngresso;

        public IngressoController()
        {
            appIngresso = AplicacaoConstrutor.IngressoAplicacao();
        }
        public ActionResult Index()
        {
            var listaDeIngressos = appIngresso.ListarTodos();
            return View(listaDeIngressos);
        }

        public ActionResult Comprar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Comprar(INGRESSO ingresso)
        {
            if (ModelState.IsValid)
            {
                appIngresso.Salvar(ingresso);
                return RedirectToAction("Ingresso");
            }
            return View(ingresso);
        }

        public ActionResult Editar(string Id_Ingresso)
        {
            var ingresso = appIngresso.ListarPorId(Id_Ingresso);
            if (ingresso == null)
                return HttpNotFound();
            return View(ingresso);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(INGRESSO ingresso)
        {
            if (ModelState.IsValid)
            {
                appIngresso.Salvar(ingresso);
                return RedirectToAction("Index");
            }
            return View(ingresso);
        }

        public ActionResult Detalhes(string Id_Ingresso)
        {
            var ingresso = appIngresso.ListarPorId(Id_Ingresso);
            if (ingresso == null)
                return HttpNotFound();
            return View(ingresso);
        }

        public ActionResult Excluir(string Id_Ingresso)
        {
            var ingresso = appIngresso.ListarPorId(Id_Ingresso);
            if (ingresso == null)
                return HttpNotFound();
            return View(ingresso);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(string Id_Ingresso)
        {
            var ingresso = appIngresso.ListarPorId(Id_Ingresso);
            appIngresso.Excluir(ingresso);
            return RedirectToAction("Index");
        }
    }
}