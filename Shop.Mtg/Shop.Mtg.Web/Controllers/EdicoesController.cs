using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Shop.Mtg.Dados.Entity.Context;
using Shop.Mtg.Dominio;
using Shop.Mtg.Repositorios.Comum;
using Shop.Mtg.Repositorios.Entity;
using Shop.Mtg.Web.Filtros;
using Shop.Mtg.Web.ViewModels.Carta;
using Shop.Mtg.Web.ViewModels.Edicao;

namespace Shop.Mtg.Web.Controllers
{
    [Authorize]
    [LogActionFilter]
    public class EdicoesController : Controller
    {
        private IRepositorioGenerico<Edicao, int>
            repositorioEdicoes = new EdicoesRepositorio(new MtgDbContext());

        // GET: Edições
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Edicao>, List<EdicaoIndexViewModel>>(repositorioEdicoes.Selecionar()));
        }

        public ActionResult FiltrarPorNome(string pesquisa)
        {
            List<Edicao> edicoes = repositorioEdicoes
                .Selecionar()
                .Where(a => a.Nome.Contains(pesquisa)).ToList();
            List<EdicaoIndexViewModel> viewModels = Mapper
                .Map<List<Edicao>, List<EdicaoIndexViewModel>>(edicoes);

            return Json(viewModels, JsonRequestBehavior.AllowGet);
        }

        // GET: Edições/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Edicao edicao = repositorioEdicoes.SelecionarPorId(id.Value);
            
            if (edicao == null)
            {
                return HttpNotFound();
            }
            
            return View(Mapper.Map<Edicao, EdicaoIndexViewModel>(edicao));
        }

        // GET: Edições/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Edições/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id, Nome, Sigla, Ano")] EdicaoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Edicao edicao = Mapper.Map<EdicaoViewModel, Edicao>(viewModel);
                repositorioEdicoes.Inserir(edicao);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Edições/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Edicao edicao = repositorioEdicoes.SelecionarPorId(id.Value);
            
            if (edicao == null)
            {
                return HttpNotFound();
            }
            
            return View(Mapper.Map<Edicao, EdicaoViewModel>(edicao));
        }

        // POST: Edições/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Nome, Sigla, Ano")] EdicaoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Edicao edicao = Mapper.Map<EdicaoViewModel, Edicao>(viewModel);
                repositorioEdicoes.Alterar(edicao);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Edições/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Edicao edicao = repositorioEdicoes.SelecionarPorId(id.Value);
            
            if (edicao == null)
            {
                return HttpNotFound();
            }
            
            return View(Mapper.Map<Edicao, EdicaoIndexViewModel>(edicao));
        }

        // POST: Edições/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioEdicoes.ExcluirPorId(id);
            return RedirectToAction("Index");
        }
    }
}
