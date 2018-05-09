using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Interface
{
    public interface IUposlenik
    {
        void dodajLokaciju(Lokacija l);
        void obrisiLokaciju(Lokacija l);
    }
}
