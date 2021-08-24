using Cinema.Aplicacao;
using Cinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.UI.Web.Controllers
{
    public class GeneroController : Controller
    {
        private readonly GeneroAplicacao appGenero;

        public GeneroController()
        {
            appGenero = AplicacaoConstrutor.GeneroAplicacao();
        }
        public ActionResult Index()
        {
            var listaDeGenero = appGenero.ListarTodos();
            return View(listaDeGenero);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(GENERO genero)
        {
            if (ModelState.IsValid)
            {
                appGenero.Salvar(genero);
                return RedirectToAction("Index");
            }
            return View(genero);
        }

        public ActionResult Editar(string Id_Genero)
        {
            var genero = appGenero.ListarPorId(Id_Genero);
            if (genero == null)
                return HttpNotFound();
            return View(genero);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(GENERO genero)
        {
            if (ModelState.IsValid)
            {
                appGenero.Salvar(genero);
                return RedirectToAction("Index");
            }
            return View(genero);
        }

        public ActionResult Detalhes(string Id_Genero)
        {
            var genero = appGenero.ListarPorId(Id_Genero);
            if (genero == null)
                return HttpNotFound();
            return View(genero);
        }

        public ActionResult Excluir(string Id_Genero)
        {
            var genero = appGenero.ListarPorId(Id_Genero);
            if (genero == null)
                return HttpNotFound();
            return View(genero);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(string Id_Genero)
        {
            var genero = appGenero.ListarPorId(Id_Genero);
            appGenero.Excluir(genero);
            return RedirectToAction("Index");
        }
    }
}