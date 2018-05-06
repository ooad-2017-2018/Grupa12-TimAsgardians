using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Osobe
{
    public class Admin : Osoba
    {
        public Admin()
        {
        }

        

        public Admin(Admin a)
        {

        }

        public Admin(string ime, string prezime, string username, string password, string email, string brtel, string adresa) : base(ime, prezime, username, password, email, brtel, adresa)
        {
        }

        public void dodajUposlenika(Uposlenik u)
        {

        }
        public void obrisiUposlenika(Uposlenik u)
        {

        }
        public void dodajVodica(Vodic v)
        {

        }
        public void obrisiVodica(Vodic v)
        {

        }
    }
}
