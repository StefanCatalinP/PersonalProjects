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
    public class PromotiiTichetesController : Controller
    {
        private CinemaContext db = new CinemaContext();


        // Functie search nume promotii

        public ActionResult Index(string searchString)
        {

            var promotiiTichete = from t in db.PromotiiTichete
                       select t;

            if (!String.IsNullOrEmpty(searchString))
            {
                promotiiTichete = promotiiTichete.Where(s => s.Nume.Contains(searchString));
            }

            return View(promotiiTichete);
        }


        // GET: PromotiiTichetes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PromotiiTichete promotiiTichete = db.PromotiiTichete.Find(id);
            if (promotiiTichete == null)
            {
                return HttpNotFound();
            }
            return View(promotiiTichete);
        }

        // GET: PromotiiTichetes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PromotiiTichetes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PromotiiTicheteID,Nume,Pret,Descriere,Data_Incepere,Data_Sfarsit")] PromotiiTichete promotiiTichete)
        {
            if (ModelState.IsValid)
            {
                db.PromotiiTichete.Add(promotiiTichete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(promotiiTichete);
        }

        // GET: PromotiiTichetes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PromotiiTichete promotiiTichete = db.PromotiiTichete.Find(id);
            if (promotiiTichete == null)
            {
                return HttpNotFound();
            }
            return View(promotiiTichete);
        }

        // POST: PromotiiTichetes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PromotiiTicheteID,Nume,Pret,Descriere,Data_Incepere,Data_Sfarsit")] PromotiiTichete promotiiTichete)
        {
            if (ModelState.IsValid)
            {
                db.Entry(promotiiTichete).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(promotiiTichete);
        }

        // GET: PromotiiTichetes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PromotiiTichete promotiiTichete = db.PromotiiTichete.Find(id);
            if (promotiiTichete == null)
            {
                return HttpNotFound();
            }
            return View(promotiiTichete);
        }

        // POST: PromotiiTichetes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PromotiiTichete promotiiTichete = db.PromotiiTichete.Find(id);
            db.PromotiiTichete.Remove(promotiiTichete);
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
