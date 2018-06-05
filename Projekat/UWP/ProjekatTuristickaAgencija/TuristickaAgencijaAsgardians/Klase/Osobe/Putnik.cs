using System;
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
        public int PutnikId { get; set; }

        public Putnik()
        {
        }

        public Putnik(string ime, string prezime, string username, string password, string email, string brtel, string adresa) : base(ime, prezime, username, password, email, brtel, adresa)
        {
        }

        public Putnik(Putnik p)
        {
            this.Ime = p.Ime;
            this.Prezime = p.Prezime;
            this.Username = p.Username;
            this.Password = p.Password;
            this.Email = p.Email;
            this.Brtel = p.Brtel;
            this.Adresa = p.Adresa;
            this.PutnikId = p.PutnikId;
        }

        public bool Kontaktiran { get => kontaktiran; set => kontaktiran = value; }
        public Dictionary<bool, string> ListaPoruka { get => listaPoruka; set => listaPoruka = value; }
        override public string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
      
        
        
    }
}
