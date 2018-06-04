using System;
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
    public class UposleniksController : Controller
    {
        private AsgardiansContext db = new AsgardiansContext();

        // GET: Uposleniks
        string apiURL = "http://projekatasgardianswebapi.azurewebsites.net/";
        public async Task<ActionResult> Index()

        {
            List<Uposlenik> uposlenici = new List<Uposlenik>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiURL);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("api/Uposleniks");

                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    uposlenici = JsonConvert.DeserializeObject<List<Uposlenik>>(response);


                }
            }
            return View(uposlenici);
        }

        // GET: Uposleniks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uposlenik uposlenik = db.Uposlenik.Find(id);
            if (uposlenik == null)
            {
                return HttpNotFound();
            }
            return View(uposlenik);
        }

        // GET: Uposleniks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Uposleniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UposlenikId,Ime,Prezime,Username,Password,Email,Brtel,Adresa")] Uposlenik uposlenik)
        {
            if (ModelState.IsValid)
            {
                db.Uposlenik.Add(uposlenik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uposlenik);
        }

        // GET: Uposleniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uposlenik uposlenik = db.Uposlenik.Find(id);
            if (uposlenik == null)
            {
                return HttpNotFound();
            }
            return View(uposlenik);
        }

        // POST: Uposleniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UposlenikId,Ime,Prezime,Username,Password,Email,Brtel,Adresa")] Uposlenik uposlenik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uposlenik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uposlenik);
        }

        // GET: Uposleniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uposlenik uposlenik = db.Uposlenik.Find(id);
            if (uposlenik == null)
            {
                return HttpNotFound();
            }
            return View(uposlenik);
        }

        // POST: Uposleniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Uposlenik uposlenik = db.Uposlenik.Find(id);
            db.Uposlenik.Remove(uposlenik);
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
