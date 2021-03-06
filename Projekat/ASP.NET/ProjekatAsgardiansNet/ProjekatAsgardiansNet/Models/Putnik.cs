﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjekatAsgardiansNet.Models
{
    public class Putnik : Osoba
    {
        private bool kontaktiran;
        private Dictionary<bool, string> listaPoruka;
        [ScaffoldColumn(false)]
        public int PutnikId { get; set; }
        public Putnik()
        {
        }

        public Putnik(string ime, string prezime, string username, string password, string email, string brtel, string adresa) : base(ime, prezime, username, password, email, brtel, adresa)
        {
        }

        public Putnik(Putnik p)
        {
            p.Ime = Ime;
            p.Prezime = Prezime;
            p.Username = Username;
            p.Password = Password;
            p.Email = Email;
            p.Brtel = Brtel;
            p.Adresa = Adresa;
            p.kontaktiran = kontaktiran;
            p.listaPoruka = listaPoruka;
        }

        public bool Kontaktiran { get => kontaktiran; set => kontaktiran = value; }
        public Dictionary<bool, string> ListaPoruka { get => listaPoruka; set => listaPoruka = value; }
        override public string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
    }
}