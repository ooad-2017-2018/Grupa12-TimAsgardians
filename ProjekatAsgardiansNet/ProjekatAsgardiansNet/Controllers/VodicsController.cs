using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjekatAsgardiansNet.Models;

namespace ProjekatAsgardiansNet.Controllers
{
    public class VodicsController : Controller
    {
        private AsgardiansContext db = new AsgardiansContext();

        // GET: Vodics
        public ActionResult Index()
        {
            return View(db.Vodic.ToList());
        }

        // GET: Vodics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vodic vodic = db.Vodic.Find(id);
            if (vodic == null)
            {
                return HttpNotFound();
            }
            return View(vodic);
        }

        // GET: Vodics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vodics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VodicId,Ime,Prezime,Username,Password,Email,Brtel,Adresa")] Vodic vodic)
        {
            if (ModelState.IsValid)
            {
                db.Vodic.Add(vodic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vodic);
        }

        // GET: Vodics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vodic vodic = db.Vodic.Find(id);
            if (vodic == null)
            {
                return HttpNotFound();
            }
            return View(vodic);
        }

        // POST: Vodics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VodicId,Ime,Prezime,Username,Password,Email,Brtel,Adresa")] Vodic vodic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vodic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vodic);
        }

        // GET: Vodics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vodic vodic = db.Vodic.Find(id);
            if (vodic == null)
            {
                return HttpNotFound();
            }
            return View(vodic);
        }

        // POST: Vodics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vodic vodic = db.Vodic.Find(id);
            db.Vodic.Remove(vodic);
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
