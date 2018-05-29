using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjekatAsgardiansNet.Models;

namespace ProjekatAsgardiansNet.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Admin a;
        TuristickaAgencija tours;
        public ActionResult Index()
        {
            return View();
        }

        public AdminController()
        {
            tours = new TuristickaAgencija();

        }

        public AdminController(ref TuristickaAgencija refTours)
        {
            tours = new TuristickaAgencija();
            tours = refTours;
        }
        public AdminController(Admin a)
        {
            A = a;
        }

        public Admin A { get => a; set => a = value; }
        public void dodajUposlenika(Uposlenik u)
        {
            tours.Osobe.Add(u);
        }
        public void obrisiUposlenika(Uposlenik u)
        {
            for (int i = 0; i < tours.Osobe.Count; i++)
            {
                if (tours.Osobe[i] == u) tours.Osobe.Remove(tours.Osobe[i]);
            }
        }
        public void dodajVodica(Vodic v)
        {
            tours.Osobe.Add(v);
        }
        public void obrisiVodica(Vodic v)
        {
            for (int i = 0; i < tours.Osobe.Count; i++)
            {
                if (tours.Osobe[i] == v) tours.Osobe.Remove(tours.Osobe[i]);
            }
        }
        public void login() { }

    }
}