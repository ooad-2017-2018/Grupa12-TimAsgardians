using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjekatAsgardiansNet.Models
{
    public abstract class Osoba
    {
        [Required]
        protected string ime;
        [Required]
        protected string prezime;
        [Required]
        protected string username;
        [Required]
        protected string password;
        [Required]
        protected string email;
        [Required]
        protected string brtel;
        [Required]
        protected string adresa;
        [ScaffoldColumn(false)]
        public int OsobaId;

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
            o.ime = ime;
            o.prezime = prezime;
            o.username = username;
            o.password = password;
            o.email = email;
            o.brtel = brtel;
            o.adresa = adresa;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Brtel { get => brtel; set => brtel = value; }
        public string Adresa { get => adresa; set => adresa = value; }

    }
}