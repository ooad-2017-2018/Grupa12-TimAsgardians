using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencijaAsgardians.Klase;
using TuristickaAgencijaAsgardians.Klase.Osobe;

namespace TuristickaAgencijaAsgardians.ViewModel
{
    public class PutnikViewModel
    {
        Putnik p;
        TuristickaAgencija tours;
        public PutnikViewModel()
        {
            tours = new TuristickaAgencija();

        }

        public PutnikViewModel(ref TuristickaAgencija refTours)
        {
            tours = new TuristickaAgencija();
            tours = refTours;
        }
        public PutnikViewModel(Putnik p)
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
