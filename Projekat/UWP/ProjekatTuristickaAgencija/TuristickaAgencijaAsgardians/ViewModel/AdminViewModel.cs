using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencijaAsgardians.Klase;
using TuristickaAgencijaAsgardians.Klase.Osobe;

namespace TuristickaAgencijaAsgardians.ViewModel
{
    public class AdminViewModel
    {
        Klase.Osobe.Admin a;
        TuristickaAgencija tours;
        public AdminViewModel()
        {
            tours = new TuristickaAgencija();

        }

        public AdminViewModel(ref TuristickaAgencija refTours)
        {
            tours = new TuristickaAgencija();
            tours = refTours;
        }
        public AdminViewModel(Admin a)
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
            for(int i=0; i<tours.Osobe.Count; i++)
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
