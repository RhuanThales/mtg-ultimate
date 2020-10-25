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
using Shop.Mtg.Web.ViewModels.Carta;

namespace Shop.Mtg.Web.Controllers
{
    public class CartasController : Controller
    {
        private MtgDbContext db = new MtgDbContext();

        // GET: Cartas
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Carta>, List<CartaIndexViewModel>> (db.Cartas.ToList()));
        }

        // GET: Cartas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Carta carta = db.Cartas.Find(id);
            
            if (carta == null)
            {
                return HttpNotFound();
            }
            
            return View(Mapper.Map<Carta, CartaIndexViewModel>(carta));
        }

        // GET: Cartas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cartas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id, Nome, CustoMana, CustoManaConvertido, Tipo, Lendaria, SubTipoA, SubTipoB, Raridade, Descricao, Poder, Resistencia, Edicao")] CartaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Carta carta = Mapper.Map<CartaViewModel, Carta>(viewModel);
                db.Cartas.Add(carta);
                db.SaveChanges();
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
            
            Carta carta = db.Cartas.Find(id);
            
            if (carta == null)
            {
                return HttpNotFound();
            }
            
            return View(Mapper.Map<Carta, CartaViewModel>(carta));
        }

        // POST: Cartas/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Nome, CustoMana, CustoManaConvertido, Tipo, Lendaria, SubTipoA, SubTipoB, Raridade, Descricao, Poder, Resistencia, Edicao")] CartaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Carta carta = Mapper.Map<CartaViewModel, Carta>(viewModel);
                db.Entry(carta).State = EntityState.Modified;
                db.SaveChanges();
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
            
            Carta carta = db.Cartas.Find(id);
            
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
            Carta carta = db.Cartas.Find(id);
            
            db.Cartas.Remove(carta);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            
            base.Dispose(disposing);
        }
    }
}
