using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjekatAsgardiansNet.Models;

namespace ProjekatAsgardiansNet.Controllers
{
    public class VodicController : Controller
    {
        // GET: Vodic
        Vodic v;
        TuristickaAgencija tours;
        public ActionResult Index()
        {
            return View();
        }

        
        public VodicController()
        {
            tours = new TuristickaAgencija();

        }

        public VodicController(ref TuristickaAgencija refTours)
        {
            tours = new TuristickaAgencija();
            tours = refTours;
        }
        public VodicController(Vodic v)
        {
            V = v;
        }

        public Vodic V { get => v; set => v = value; }
        public void zaduziNaLokaciju(Lokacija l)
        {
            v.ZaduzeneLokacije.Add(l);
        }
        public void razduziSaLokacije(Lokacija l)
        {
            for (int i = 0; i < v.ZaduzeneLokacije.Count; i++)
            {
                if (l == v.ZaduzeneLokacije[i]) v.ZaduzeneLokacije.Remove(v.ZaduzeneLokacije[i]);
            }
        }
        public string infoODestinaciji(Lokacija l)
        {
            return l.ToString();
        }
        public void login() { }
    }
}