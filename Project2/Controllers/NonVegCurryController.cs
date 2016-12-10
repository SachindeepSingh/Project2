using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class NonVegCurryController : Controller
    {
        private IndianCuisinesContext db = new IndianCuisinesContext();
        // GET: Non_veg_currys
        public ActionResult Index()
        {
            return View(db.Non_veg_curry.ToList());
        }

        [Authorize(Roles = "Admin")]
        // GET: Non_veg_curry for Admin
        public ActionResult Admin()
        {
            return View(db.Non_veg_curry.ToList());
        }

        // GET: Non_veg_curry/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Non_veg_curry Non_veg_curry = db.Non_veg_curry.Find(id);
            if (Non_veg_curry == null)
            {
                return HttpNotFound();
            }
            return View(Non_veg_curry);
        }

        // GET: AdminNon_veg_curry/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminNon_veg_curry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Non_veg_curryId,Non_veg_curryName,Non_veg_curryhortDescription,Non_veg_curryLongDescription,Non_veg_curryPrice,Non_veg_curryImage")] Non_veg_curry Non_veg_curry)
        {
            if (ModelState.IsValid)
            {
                db.Non_veg_curry.Add(Non_veg_curry);
                db.SaveChanges();
                return RedirectToAction("Admin");
            }

            return View(Non_veg_curry);
        }

        // GET: AdminNon_veg_curry/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Non_veg_curry Non_veg_curry = db.Non_veg_curry.Find(id);
            if (Non_veg_curry == null)
            {
                return HttpNotFound();
            }
            return View(Non_veg_curry);
        }

        // POST: AdminNon_veg_curry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Non_veg_curryId,Non_veg_curryName,Non_veg_curryhortDescription,Non_veg_curryLongDescription,Non_veg_curryPrice,Non_veg_curryImage")] Non_veg_curry Non_veg_curry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Non_veg_curry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Admin");
            }
            return View(Non_veg_curry);
        }

        // GET: AdminNon_veg_curry/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Non_veg_curry Non_veg_curry = db.Non_veg_curry.Find(id);
            if (Non_veg_curry == null)
            {
                return HttpNotFound();
            }
            return View(Non_veg_curry);
        }

        // POST: AdminNon_veg_curry/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Non_veg_curry Non_veg_curry = db.Non_veg_curry.Find(id);
            db.Non_veg_curry.Remove(Non_veg_curry);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }
        [Authorize(Roles = "Admin")]
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
