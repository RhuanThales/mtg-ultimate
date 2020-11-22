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
using Shop.Mtg.Web.ViewModels.Carta;
using Shop.Mtg.Web.ViewModels.Edicao;

namespace Shop.Mtg.Web.Controllers
{
    public class CartasController : Controller
    {
        private IRepositorioGenerico<Carta, long>
            repositorioCartas = new CartasRepositorio(new MtgDbContext());

        private IRepositorioGenerico<Edicao, int>
            repositorioEdicoes = new EdicoesRepositorio(new MtgDbContext());

        // GET: Cartas
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Carta>,
                List<CartaIndexViewModel>>(repositorioCartas.Selecionar()));
        }

        // GET: Cartas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Carta carta = repositorioCartas.SelecionarPorId(id.Value);
            
            if (carta == null)
            {
                return HttpNotFound();
            }
            
            return View(Mapper.Map<Carta, CartaIndexViewModel>(carta));
        }

        // GET: Cartas/Create
        public ActionResult Create()
        {
            List<EdicaoIndexViewModel> edicoes = Mapper.Map<List<Edicao>,
                List<EdicaoIndexViewModel>>(repositorioEdicoes.Selecionar());

            SelectList dropDownEdicoes = new SelectList(edicoes, "Id", "Nome");
            ViewBag.DropDownEdicoes = dropDownEdicoes;
            
            return View();
        }

        // POST: Cartas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id, Nome, CustoMana, CustoManaConvertido, Tipo, Lendaria, SubTipoA, SubTipoB, Raridade, Descricao, Poder, Resistencia, IdEdicao")] CartaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Carta carta = Mapper.Map<CartaViewModel, Carta>(viewModel);
                repositorioCartas.Inserir(carta);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Cartas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Carta carta = repositorioCartas.SelecionarPorId(id.Value);
            
            if (carta == null)
            {
                return HttpNotFound();
            }

            List<EdicaoIndexViewModel> edicoes = Mapper.Map<List<Edicao>,
                List<EdicaoIndexViewModel>>(repositorioEdicoes.Selecionar());

            SelectList dropDownEdicoes = new SelectList(edicoes, "Id", "Nome");
            ViewBag.DropDownEdicoes = dropDownEdicoes;
            
            return View(Mapper.Map<Carta, CartaViewModel>(carta));
        }

        // POST: Cartas/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Nome, CustoMana, CustoManaConvertido, Tipo, Lendaria, SubTipoA, SubTipoB, Raridade, Descricao, Poder, Resistencia, IdEdicao")] CartaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Carta carta = Mapper.Map<CartaViewModel, Carta>(viewModel);
                repositorioCartas.Alterar(carta);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Cartas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Carta carta = repositorioCartas.SelecionarPorId(id.Value);
            
            if (carta == null)
            {
                return HttpNotFound();
            }
            
            return View(Mapper.Map<Carta, CartaIndexViewModel>(carta));
        }

        // POST: Cartas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioCartas.ExcluirPorId(id);
            return RedirectToAction("Index");
        }
    }
}
