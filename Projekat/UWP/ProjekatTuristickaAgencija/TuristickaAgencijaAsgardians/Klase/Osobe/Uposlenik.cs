using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Osobe
{
    public class Uposlenik : Osoba
    {
        public int Id { get; set; }

        public Uposlenik()
        {
        }

        public Uposlenik(string ime, string prezime, string username, string password, string email, string brtel, string adresa) : base(ime, prezime, username, password, email, brtel, adresa)
        {
        }

        public Uposlenik(Uposlenik u)
        {
            this.Ime = u.Ime;
            this.Prezime = u.Prezime;
            this.Username = u.Username;
            this.Password = u.Password;
            this.Email = u.Email;
            this.Brtel = u.Brtel;
            this.Adresa = u.Adresa;
            this.Id = u.Id;
        }

        override public string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
    }
}
