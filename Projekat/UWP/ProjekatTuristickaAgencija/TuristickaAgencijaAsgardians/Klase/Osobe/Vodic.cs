using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Osobe
{
    public class Vodic:Osoba
    {
        public int Id { get; set; }

        private List<Lokacija> zaduzeneLokacije;

        public List<Lokacija> ZaduzeneLokacije { get => zaduzeneLokacije; set => zaduzeneLokacije = value; }

        public Vodic()
        {
        }

        public Vodic(string ime, string prezime, string username, string password, string email, string brtel, string adresa) : base(ime, prezime, username, password, email, brtel, adresa)
        {
        }

        public Vodic(Vodic v)
        {
            this.Ime = v.Ime;
            this.Prezime = v.Prezime;
            this.Username = v.Username;
            this.Password = v.Password;
            this.Email = v.Email;
            this.Brtel = v.Brtel;
            this.Adresa = v.Adresa;
            this.Id = v.Id;
        }

        override public string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
    }
}
