using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencijaAsgardians.Klase;
using TuristickaAgencijaAsgardians.Klase.Osobe;

namespace TuristickaAgencijaAsgardians.ViewModel
{
    public class VodicViewModel
    {
        Vodic v;
        TuristickaAgencija tours;
        public VodicViewModel()
        {
            tours = new TuristickaAgencija();

        }

        public VodicViewModel(ref TuristickaAgencija refTours)
        {
            tours = new TuristickaAgencija();
            tours = refTours;
        }
        public VodicViewModel(Vodic v)
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
