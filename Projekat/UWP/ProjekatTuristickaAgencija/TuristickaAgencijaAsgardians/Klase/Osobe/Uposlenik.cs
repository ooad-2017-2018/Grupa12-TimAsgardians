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
            u.Ime = Ime;
            u.Prezime = Prezime;
            u.Username = Username;
            u.Password = Password;
            u.Email = Email;
            u.Brtel = Brtel;
            u.Adresa = Adresa;
        }

        override public string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
    }
}
