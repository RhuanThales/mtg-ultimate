using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shop.Mtg.Dados.Entity.Context;
using Shop.Mtg.Dominio;

namespace Shop.Mtg.Web.Controllers
{
    public class CartasController : Controller
    {
        private MtgDbContext db = new MtgDbContext();

        // GET: Cartas
        public ActionResult Index()
        {
            return View(db.Cartas.ToList());
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
            
            return View(carta);
        }

        // GET: Cartas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cartas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Carta carta)
        {
            if (ModelState.IsValid)
            {
                db.Cartas.Add(carta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carta);
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
            
            return View(carta);
        }

        // POST: Cartas/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Carta carta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(carta);
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
            
            return View(carta);
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
