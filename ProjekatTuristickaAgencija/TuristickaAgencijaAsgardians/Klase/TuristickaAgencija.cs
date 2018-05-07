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

        public List<Osoba> Osobe { get { return osobe; } set { this.osobe = value; } }
        public List<Lokacija> Lokacije { get => lokacije; set => lokacije = value; }

        public TuristickaAgencija()
        {
            osobe = new List<Osoba>();
            lokacije = new List<Lokacija>();
        }

        public void dodajAdmina(Admin a)
        {
            osobe.Add(new Admin(a));
        }
        public void dodajUposlenika(Uposlenik u)
        {
            osobe.Add(new Uposlenik(u));
        }
        public void dodajVodica(Vodic v)
        {
            osobe.Add(new Vodic(v));
        }
        public void dodajPutnika(Putnik p)
        {
            osobe.Add(new Putnik(p));
        }

        public void obrisiAdmina(Admin a)
        {

            //NE VALJA
            foreach (Admin adm in osobe)
            {
                if (adm.Equals(a))
                {
                    osobe.Remove(a);
                    break;
                }
            }
        }
        public void obrisiUposlenika(Uposlenik u)
        {
            //NE VALJA
            foreach (Uposlenik up in osobe)
            {
                if (up.Equals(u))
                {
                    osobe.Remove(u);
                    break;
                }
            }
        }
        public void obrisiVodica(Vodic v)
        {
            //NE VALJA
            foreach (Vodic vod in osobe)
            {
                if (vod.Equals(v))
                {
                    osobe.Remove(v);
                    break;
                }
            }
        }
        public void obrisiPutnika(Putnik p)
        {
            //NE VALJA
            foreach (Putnik put in osobe)
            {
                if (put.Equals(p))
                {
                    osobe.Remove(p);
                    break;
                }
            }
        }

        public void dodajLokaciju(Lokacija l)
        {
            lokacije.Add(new Lokacija(l));
        }
        public void obrisiLokaciju(Lokacija l)
        {
            //NE VALJA
        }

    }
}
