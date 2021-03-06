﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ProjekatAsgardiansNet.Models;

namespace ProjekatAsgardiansNet.Controllers
{
    public class PutniksController : Controller
    {
        private AsgardiansContext db = new AsgardiansContext();

        // GET: Putniks
        string apiURL = "http://projekatasgardianswebapi.azurewebsites.net/";
        public async Task<ActionResult> Index()

        {
            List<Putnik> putnici = new List<Putnik>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiURL);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("api/Putniks");

                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    putnici = JsonConvert.DeserializeObject<List<Putnik>>(response);


                }
            }
            return View(putnici);
        }

        // GET: Putniks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Putnik putnik = db.Putnik.Find(id);
            if (putnik == null)
            {
                return HttpNotFound();
            }
            return View(putnik);
        }

        // GET: Putniks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Putniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PutnikId,Kontaktiran,Ime,Prezime,Username,Password,Email,Brtel,Adresa")] Putnik putnik)
        {
            if (ModelState.IsValid)
            {
                db.Putnik.Add(putnik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(putnik);
        }

        // GET: Putniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Putnik putnik = db.Putnik.Find(id);
            if (putnik == null)
            {
                return HttpNotFound();
            }
            return View(putnik);
        }

        // POST: Putniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PutnikId,Kontaktiran,Ime,Prezime,Username,Password,Email,Brtel,Adresa")] Putnik putnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(putnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(putnik);
        }

        // GET: Putniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Putnik putnik = db.Putnik.Find(id);
            if (putnik == null)
            {
                return HttpNotFound();
            }
            return View(putnik);
        }

        // POST: Putniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Putnik putnik = db.Putnik.Find(id);
            db.Putnik.Remove(putnik);
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
