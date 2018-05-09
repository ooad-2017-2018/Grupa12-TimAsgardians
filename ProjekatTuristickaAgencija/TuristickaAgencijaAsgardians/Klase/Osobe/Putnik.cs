using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Osobe
{
    public class Putnik :Osoba, Interface.IPutnik
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
        void Interface.IPutnik.rezervisiLokaciju(Lokacija l)
        {

        }
        void Interface.IPutnik.otkaziLokaciju(Lokacija l)
        {

        }
        void Interface.IPutnik.provjeriPoruke()
        {

        }
    }
}
