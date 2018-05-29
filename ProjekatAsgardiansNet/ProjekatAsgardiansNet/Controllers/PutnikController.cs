using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjekatAsgardiansNet.Models;

namespace ProjekatAsgardiansNet.Controllers
{
    public class PutnikController : Controller
    {
        // GET: Putnik
        Putnik p;
        TuristickaAgencija tours;
        public ActionResult Index()
        {
            return View();
        }

        
        public PutnikController()
        {
            tours = new TuristickaAgencija();

        }

        public PutnikController(ref TuristickaAgencija refTours)
        {
            tours = new TuristickaAgencija();
            tours = refTours;
        }
        public PutnikController(Putnik p)
        {
            P = p;
        }

        public Putnik P { get => p; set => p = value; }
        public void rezervisiLokaciju(Lokacija l)
        {
            l.ListaPutnika.Add(p);
        }
        public void otkaziLokaciju(Lokacija l)
        {
            for (int i = 0; i < l.ListaPutnika.Count; i++) if (l.ListaPutnika[i] == p) l.ListaPutnika.Remove(p);
        }
        public string provjeriPoruke()
        {
            string s = "";
            if (p.Kontaktiran == true)
            {
                foreach (KeyValuePair<bool, string> pair in p.ListaPoruka)
                {
                    if (pair.Key == false) s += pair.Value + " ";
                }
            }
            else return "";
            return s;
        }
        public void login() { }
        public void signup() { }
        public void placanje() { }
        public void pregledDestinacija() { }

    }
}