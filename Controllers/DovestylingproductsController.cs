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
{
    public class DovestylingproductsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Dovestylingproducts
        public ActionResult Index()
        {
            return View(db.Dovestylingproducts.ToList());
        }

        // GET: Dovestylingproducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dovestylingproduct dovestylingproduct = db.Dovestylingproducts.Find(id);
            if (dovestylingproduct == null)
            {
                return HttpNotFound();
            }
            return View(dovestylingproduct);
        }

        // GET: Dovestylingproducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dovestylingproducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Dovehairspray,Gidtcardno_,Dovehairgel,Doveheatprotector")] Dovestylingproduct dovestylingproduct)
        {
            if (ModelState.IsValid)
            {
                db.Dovestylingproducts.Add(dovestylingproduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dovestylingproduct);
        }

        // GET: Dovestylingproducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dovestylingproduct dovestylingproduct = db.Dovestylingproducts.Find(id);
            if (dovestylingproduct == null)
            {
                return HttpNotFound();
            }
            return View(dovestylingproduct);
        }

        // POST: Dovestylingproducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Dovehairspray,Gidtcardno_,Dovehairgel,Doveheatprotector")] Dovestylingproduct dovestylingproduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dovestylingproduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dovestylingproduct);
        }

        // GET: Dovestylingproducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dovestylingproduct dovestylingproduct = db.Dovestylingproducts.Find(id);
            if (dovestylingproduct == null)
            {
                return HttpNotFound();
            }
            return View(dovestylingproduct);
        }

        // POST: Dovestylingproducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Dovestylingproduct dovestylingproduct = db.Dovestylingproducts.Find(id);
            db.Dovestylingproducts.Remove(dovestylingproduct);
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
