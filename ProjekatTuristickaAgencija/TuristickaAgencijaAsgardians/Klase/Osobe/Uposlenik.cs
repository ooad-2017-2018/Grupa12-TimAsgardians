using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Osobe
{
    public class Uposlenik : Osoba
    {
        public Uposlenik()
        {
        }

        public Uposlenik(string ime, string prezime, string username, string password, string email, string brtel, string adresa) : base(ime, prezime, username, password, email, brtel, adresa)
        {
        }

        public Uposlenik(Uposlenik u)
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
