using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using week9suggestionbox.Models;

namespace week9suggestionbox.Controllers
{
    public class SuggestionmodelsController : Controller
    {
        private week9suggestionboxContext db = new week9suggestionboxContext();

        // GET: Suggestionmodels
        public ActionResult Index()
        {
            return View(db.Suggestionmodels.ToList());
        }

        // GET: Suggestionmodels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Suggestionmodel suggestionmodel = db.Suggestionmodels.Find(id);
            if (suggestionmodel == null)
            {
                return HttpNotFound();
            }
            return View(suggestionmodel);
        }

        // GET: Suggestionmodels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Suggestionmodels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecordNum,Name,Topic,Suggestion")] Suggestionmodel suggestionmodel)
        {
            if (ModelState.IsValid)
            {
                db.Suggestionmodels.Add(suggestionmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(suggestionmodel);
        }

        // GET: Suggestionmodels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Suggestionmodel suggestionmodel = db.Suggestionmodels.Find(id);
            if (suggestionmodel == null)
            {
                return HttpNotFound();
            }
            return View(suggestionmodel);
        }

        // POST: Suggestionmodels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecordNum,Name,Topic,Suggestion")] Suggestionmodel suggestionmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(suggestionmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(suggestionmodel);
        }

        // GET: Suggestionmodels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Suggestionmodel suggestionmodel = db.Suggestionmodels.Find(id);
            if (suggestionmodel == null)
            {
                return HttpNotFound();
            }
            return View(suggestionmodel);
        }

        // POST: Suggestionmodels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Suggestionmodel suggestionmodel = db.Suggestionmodels.Find(id);
            db.Suggestionmodels.Remove(suggestionmodel);
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
