using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Osobe
{
    public abstract class Osoba
    {
        private string ime;
        private string prezime;
        private string username;
        private string password;
        private string email;
        private string brtel;
        private string adresa;
        public int OsobaId { get; set; }


        public Osoba()
        {
        }

        public Osoba(string ime, string prezime, string username, string password, string email, string brtel, string adresa)
        {
            Ime = ime;
            Prezime = prezime;
            Username = username;
            Password = password;
            Email = email;
            Brtel = brtel;
            Adresa = adresa;
        }

        public Osoba(Osoba o)
        {
            this.Ime = o.Ime;
            this.Prezime = o.Prezime;
            this.Username = o.Username;
            this.Password = o.Password;
            this.Email = o.Email;
            this.Brtel = o.Brtel;
            this.Adresa = o.Adresa;
            this.OsobaId = o.OsobaId;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Brtel { get => brtel; set => brtel = value; }
        public string Adresa { get => adresa; set => adresa = value; }

        //abstract public string To_String(Osoba o);

    }
}
