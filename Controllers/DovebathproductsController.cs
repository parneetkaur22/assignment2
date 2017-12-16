using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using parneetkaur.Models;

namespace parneetkaur.Controllers
{[Authorize]
    public class DovebathproductsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Dovebathproducts
        public ActionResult Index()
        {
            return View(db.Dovebathproducts.ToList());
        }

        // GET: Dovebathproducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dovebathproduct dovebathproduct = db.Dovebathproducts.Find(id);
            if (dovebathproduct == null)
            {
                return HttpNotFound();
            }
            return View(dovebathproduct);
        }

        // GET: Dovebathproducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dovebathproducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "C_Giftcardno_,DoveSoap,DoveShampoo,DoveConditioner")] Dovebathproduct dovebathproduct)
        {
            if (ModelState.IsValid)
            {
                db.Dovebathproducts.Add(dovebathproduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dovebathproduct);
        }

        // GET: Dovebathproducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dovebathproduct dovebathproduct = db.Dovebathproducts.Find(id);
            if (dovebathproduct == null)
            {
                return HttpNotFound();
            }
            return View(dovebathproduct);
        }

        // POST: Dovebathproducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "C_Giftcardno_,DoveSoap,DoveShampoo,DoveConditioner")] Dovebathproduct dovebathproduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dovebathproduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dovebathproduct);
        }

        // GET: Dovebathproducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dovebathproduct dovebathproduct = db.Dovebathproducts.Find(id);
            if (dovebathproduct == null)
            {
                return HttpNotFound();
            }
            return View(dovebathproduct);
        }

        // POST: Dovebathproducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dovebathproduct dovebathproduct = db.Dovebathproducts.Find(id);
            db.Dovebathproducts.Remove(dovebathproduct);
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
