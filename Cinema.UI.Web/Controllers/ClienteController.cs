using Cinema.Aplicacao;
using Cinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteAplicacao appCliente;

        public ClienteController()
        {
            appCliente = AplicacaoConstrutor.ClienteAplicacao();
        }
        public ActionResult Index()
        {
            var listaDeClientes = appCliente.ListarTodos();
            return View(listaDeClientes);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(CLIENTE cliente)
        {
            if (ModelState.IsValid)
            {
                appCliente.Salvar(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        public ActionResult Editar(string Id_Cliente)
        {
            var cliente = appCliente.ListarPorId(Id_Cliente);
            if (cliente == null)
                return HttpNotFound();
            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(CLIENTE cliente)
        {
            if (ModelState.IsValid)
            {
                appCliente.Salvar(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        public ActionResult Detalhes(string Id_Cliente)
        {
            var cliente = appCliente.ListarPorId(Id_Cliente);
            if (cliente == null)
                return HttpNotFound();
            return View(cliente);
        }

        public ActionResult Excluir(string Id_Cliente)
        {
            var cliente = appCliente.ListarPorId(Id_Cliente);
            if (cliente == null)
                return HttpNotFound();
            return View(cliente);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(string Id_Cliente)
        {
            var cliente = appCliente.ListarPorId(Id_Cliente);
            appCliente.Excluir(cliente);
            return RedirectToAction("Index");
        }
    }
}