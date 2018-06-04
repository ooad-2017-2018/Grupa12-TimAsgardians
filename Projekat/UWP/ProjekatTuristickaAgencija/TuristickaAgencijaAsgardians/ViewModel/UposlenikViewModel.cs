using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencijaAsgardians.Klase;
using TuristickaAgencijaAsgardians.Klase.Osobe;

namespace TuristickaAgencijaAsgardians.ViewModel
{
    public class UposlenikViewModel
    {
        Uposlenik u;
        TuristickaAgencija tours;
        public UposlenikViewModel()
        {
            tours = new TuristickaAgencija();

        }

        public UposlenikViewModel(ref TuristickaAgencija refTours)
        {
            tours = new TuristickaAgencija();
            tours = refTours;
        }
        public UposlenikViewModel(Uposlenik u)
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

        public void kontaktirajPutnika(Klase.Osobe.Putnik p, string poruka)
        {
            p.Kontaktiran = true;
            p.ListaPoruka.Add(false, poruka);
        }

        public void login() { }
        public int pretragaPutnika(Putnik p) {

            for (int i = 0; i < tours.Osobe.Count; i++) if (p == tours.Osobe[i]) return i;
            return -1;
        }
        public string infoOPutniku(Putnik p)
        {
            return p.ToString();
        }
    }
}
