using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CinemaPiersic.DAL;
using CinemaPiersic.Models;

namespace ASP_CinemaPiersic.Controllers
{
    public class TichetesController : Controller
    {
        private CinemaContext db = new CinemaContext();

        // GET: Tichetes
        public ActionResult Index()
        {
            var tichete = db.Tichete.Include(t => t.Film).Include(t => t.Nume);
            return View(tichete.ToList());
        }

        // GET: Tichetes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tichete tichete = db.Tichete.Find(id);
            if (tichete == null)
            {
                return HttpNotFound();
            }
            return View(tichete);
        }

        // GET: Tichetes/Create
        public ActionResult Create()
        {
            ViewBag.FilmeID = new SelectList(db.Filme, "FilmeID", "Film");
            ViewBag.PromotiiTicheteID = new SelectList(db.PromotiiTichete, "PromotiiTicheteID", "Nume");
            return View();
        }

        // POST: Tichetes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TicheteID,FilmeID,PromotiiTicheteID,Rand,Loc,Data")] Tichete tichete)
        {
            if (ModelState.IsValid)
            {
                db.Tichete.Add(tichete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FilmeID = new SelectList(db.Filme, "FilmeID", "Film", tichete.FilmeID);
            ViewBag.PromotiiTicheteID = new SelectList(db.PromotiiTichete, "PromotiiTicheteID", "Nume", tichete.PromotiiTicheteID);
            return View(tichete);
        }

        // GET: Tichetes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tichete tichete = db.Tichete.Find(id);
            if (tichete == null)
            {
                return HttpNotFound();
            }
            ViewBag.FilmeID = new SelectList(db.Filme, "FilmeID", "Film", tichete.FilmeID);
            ViewBag.PromotiiTicheteID = new SelectList(db.PromotiiTichete, "PromotiiTicheteID", "Nume", tichete.PromotiiTicheteID);
            return View(tichete);
        }

        // POST: Tichetes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TicheteID,FilmeID,PromotiiTicheteID,Rand,Loc,Data")] Tichete tichete)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tichete).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FilmeID = new SelectList(db.Filme, "FilmeID", "Film", tichete.FilmeID);
            ViewBag.PromotiiTicheteID = new SelectList(db.PromotiiTichete, "PromotiiTicheteID", "Nume", tichete.PromotiiTicheteID);
            return View(tichete);
        }

        // GET: Tichetes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tichete tichete = db.Tichete.Find(id);
            if (tichete == null)
            {
                return HttpNotFound();
            }
            return View(tichete);
        }

        // POST: Tichetes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tichete tichete = db.Tichete.Find(id);
            db.Tichete.Remove(tichete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
