using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ResApplication.Data;
using ResApplication.Models;

namespace ResApplication.Controllers
{
    public class RestaurentController : Controller
    {
        private ResContext db = new ResContext();

        // GET: Restaurent
        public ActionResult Index()
        {
            return View(db.Restaurents.ToList());
        }

        // GET: Restaurent/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurent restaurent = db.Restaurents.Find(id);
            if (restaurent == null)
            {
                return HttpNotFound();
            }
            return View(restaurent);
        }

        // GET: Restaurent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RestaurentName,RestaurentType,EnrollmentDate")] Restaurent restaurent)
        {
            if (ModelState.IsValid)
            {
                db.Restaurents.Add(restaurent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(restaurent);
        }

        // GET: Restaurent/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurent restaurent = db.Restaurents.Find(id);
            if (restaurent == null)
            {
                return HttpNotFound();
            }
            return View(restaurent);
        }

        // POST: Restaurent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RestaurentName,RestaurentType,EnrollmentDate")] Restaurent restaurent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(restaurent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(restaurent);
        }

        // GET: Restaurent/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurent restaurent = db.Restaurents.Find(id);
            if (restaurent == null)
            {
                return HttpNotFound();
            }
            return View(restaurent);
        }

        // POST: Restaurent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Restaurent restaurent = db.Restaurents.Find(id);
            db.Restaurents.Remove(restaurent);
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
