using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Interface
{
    public interface IPutnik
    {
        void rezervisiLokaciju(Lokacija l);
        void otkaziLokaciju(Lokacija l);
        void provjeriPoruke();
    }
}
