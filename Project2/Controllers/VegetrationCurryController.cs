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
    public class VegetrationCurryController : Controller
    {
        private IndianCuisinesContext db = new IndianCuisinesContext();
        // GET: Vegetration_curries
        public ActionResult Index()
        {
            return View(db.Vegetration_curry.ToList());
        }

        [Authorize(Roles = "Admin")]
        // GET: Vegetration_curries for Admin
        public ActionResult Admin()
        {
            return View(db.Vegetration_curry.ToList());
        }

        // GET: Vegetration_curries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vegetration_curry vegetrarioncurry = db.Vegetration_curry.Find(id);
            if (vegetrarioncurry == null)
            {
                return HttpNotFound();
            }
            return View(vegetrarioncurry);
        }

        // GET: AdminVegetration_curries/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminVegetration_curries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VegetrartionCurryId,VegetrartionCurryName,Vegetration_currieshortDescription,VegetrartionCurryLongDescription,VegetrartionCurryPrice,VegetrartionCurryImage")] Vegetration_curry VegetrartionCurry)
        {
            if (ModelState.IsValid)
            {
                db.Vegetration_curry.Add(VegetrartionCurry);
                db.SaveChanges();
                return RedirectToAction("Admin");
            }

            return View(VegetrartionCurry);
        }

        // GET: AdminVegetration_curries/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vegetration_curry vegetrarioncurry = db.Vegetration_curry.Find(id);
            if (vegetrarioncurry == null)
            {
                return HttpNotFound();
            }
            return View(vegetrarioncurry);
        }

        // POST: AdminVegetration_curries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VegetrartionCurryId,VegetrartionCurryName,Vegetration_currieshortDescription,VegetrartionCurryLongDescription,VegetrartionCurryPrice,VegetrartionCurryImage")] Vegetration_curry VegetrartionCurry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(VegetrartionCurry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Admin");
            }
            return View(VegetrartionCurry);
        }

        // GET: AdminVegetration_curries/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vegetration_curry vegetrarioncurry = db.Vegetration_curry.Find(id);
            if (vegetrarioncurry == null)
            {
                return HttpNotFound();
            }
            return View(vegetrarioncurry);
        }

        // POST: AdminVegetration_curries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vegetration_curry vegetrarioncurry = db.Vegetration_curry.Find(id);
            db.Vegetration_curry.Remove(vegetrarioncurry);
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
