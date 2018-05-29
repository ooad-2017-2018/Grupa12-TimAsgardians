using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjekatAsgardiansNet.Models
{
    public class Vodic : Osoba
    {
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
            v.Ime = Ime;
            v.Prezime = Prezime;
            v.Username = Username;
            v.Password = Password;
            v.Email = Email;
            v.Brtel = Brtel;
            v.Adresa = Adresa;
            v.ZaduzeneLokacije = ZaduzeneLokacije;
        }

        override public string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
    }
}