using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjekatAsgardiansNet.Models
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

        override public string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }

    }
}