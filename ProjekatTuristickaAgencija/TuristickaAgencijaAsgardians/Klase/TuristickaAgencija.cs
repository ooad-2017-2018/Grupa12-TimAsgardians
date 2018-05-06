using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencijaAsgardians.Klase.Osobe;

namespace TuristickaAgencijaAsgardians.Klase
{
    public class TuristickaAgencija
    {
        private List<Osoba> osobe;
        private List<Lokacija> lokacije;

        public List<Osoba> Osobe { get => osobe; set => osobe = value; }
        public List<Lokacija> Lokacije { get => lokacije; set => lokacije = value; }

        public TuristickaAgencija()
        {
        }

        public void dodajAdmina(Admin a)
        {

        }
        public void dodajUposlenika(Uposlenik u)
        {

        }
        public void dodajVodica(Vodic v)
        {

        }
        public void dodajPutnika(Putnik p)
        {

        }

        public void obrisiAdmina(Admin a)
        {

        }
        public void obrisiUposlenika(Uposlenik u)
        {

        }
        public void obrisiVodica(Vodic v)
        {

        }
        public void obrisiPutnika(Putnik p)
        {

        }

        public void dodajLokaciju(Lokacija l)
        {

        }
        public void obrisiLokaciju(Lokacija l)
        {

        }

    }
}
