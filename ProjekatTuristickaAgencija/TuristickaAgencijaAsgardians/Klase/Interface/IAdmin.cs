using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Interface
{
    public interface IAdmin
    {
        void dodajUposlenika(Osobe.Uposlenik u);
        void obrisiUposlenika(Osobe.Uposlenik u);
        void dodajVodica(Osobe.Vodic v);
        void obrisiVodica(Osobe.Vodic v);
    }
}
