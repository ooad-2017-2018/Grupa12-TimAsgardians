using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjekatAsgardiansNet.Models;

namespace ProjekatAsgardiansNet.Controllers
{
    public class UposlenikController : Controller
    {
        // GET: Uposlenik

        Uposlenik u;
        TuristickaAgencija tours;
        public ActionResult Index()
        {
            return View();
        }
        
        public UposlenikController()
        {
            tours = new TuristickaAgencija();

        }

        public UposlenikController(ref TuristickaAgencija refTours)
        {
            tours = new TuristickaAgencija();
            tours = refTours;
        }
        public UposlenikController(Uposlenik u)
        {
            U = u;
        }

        public Uposlenik U { get => u; set => u = value; }
        public void dodajLokaciju(Lokacija l)
        {
            tours.Lokacije.Add(l);
        }
        public void obrisiLokaciju(Lokacija l)
        {
            for (int i = 0; i < tours.Lokacije.Count; i++)
            {
                if (tours.Lokacije[i] == l) tours.Lokacije.Remove(tours.Lokacije[i]);
            }
        }

        public void kontaktirajPutnika(Putnik p, string poruka)
        {
            p.Kontaktiran = true;
            p.ListaPoruka.Add(false, poruka);
        }

        public void login() { }
        public int pretragaPutnika(Putnik p)
        {

            for (int i = 0; i < tours.Osobe.Count; i++) if (p == tours.Osobe[i]) return i;
            return -1;
        }
        public string infoOPutniku(Putnik p)
        {
            return p.ToString();
        }
    }
}