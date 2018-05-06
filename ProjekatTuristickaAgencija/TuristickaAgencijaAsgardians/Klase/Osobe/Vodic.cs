﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Osobe
{
    public class Vodic:Osoba
    {
        private List<Lokacija> zaduzeneLokacije;

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
            v.zaduzeneLokacije = zaduzeneLokacije;
        }

        public void zaduziNaLokaciju(Lokacija l)
        {

        }
        public void razduziSaLokaciju(Lokacija l)
        {

        }

    }
}
