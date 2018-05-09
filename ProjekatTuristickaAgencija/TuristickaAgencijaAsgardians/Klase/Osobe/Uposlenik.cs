using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Osobe
{
    public class Uposlenik : Osoba, Interface.IUposlenik, Interface.KontaktPutnika
    {
        public Uposlenik()
        {
        }

        public Uposlenik(string ime, string prezime, string username, string password, string email, string brtel, string adresa) : base(ime, prezime, username, password, email, brtel, adresa)
        {
        }

        public Uposlenik(Uposlenik u)
        {
            u.Ime = Ime;
            u.Prezime = Prezime;
            u.Username = Username;
            u.Password = Password;
            u.Email = Email;
            u.Brtel = Brtel;
            u.Adresa = Adresa;
        }

        void Interface.IUposlenik.dodajLokaciju(Lokacija l)
        {
            
        }
        void Interface.IUposlenik.obrisiLokaciju(Lokacija l)
        {

        }

        void Interface.KontaktPutnika.kontaktirajPutnika(Osobe.Putnik p, string poruka)
        {
            p.Kontaktiran = true;
            p.ListaPoruka.Add(false, poruka);
        }


        override public string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
    }
}
