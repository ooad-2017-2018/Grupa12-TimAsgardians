﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Osobe
{
    public class Putnik :Osoba
    {
        private bool kontaktiran;
        private Dictionary<bool, string> listaPoruka;

        public Putnik()
        {
        }

        public Putnik(string ime, string prezime, string username, string password, string email, string brtel, string adresa) : base(ime, prezime, username, password, email, brtel, adresa)
        {
        }

        public Putnik(Putnik p)
        {

        }

        public bool Kontaktiran { get => kontaktiran; set => kontaktiran = value; }
        public Dictionary<bool, string> ListaPoruka { get => listaPoruka; set => listaPoruka = value; }

    }
}
