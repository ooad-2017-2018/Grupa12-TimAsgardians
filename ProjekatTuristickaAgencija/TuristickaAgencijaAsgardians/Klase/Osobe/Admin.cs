using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Osobe
{
    public class Admin : Osoba, Interface.IAdmin
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

        void Interface.IAdmin.dodajUposlenika(Uposlenik u)
        {

        }
        void Interface.IAdmin.obrisiUposlenika(Uposlenik u)
        {

        }
        void Interface.IAdmin.dodajVodica(Vodic v)
        {

        }
        void Interface.IAdmin.obrisiVodica(Vodic v)
        {

        }
        override public string ToString() {
            return this.Ime + " " + this.Prezime;
        }
    }
}
