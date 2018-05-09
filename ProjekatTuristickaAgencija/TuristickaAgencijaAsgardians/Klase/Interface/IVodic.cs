using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristickaAgencijaAsgardians.Klase.Interface
{
    public interface IVodic
    {
        void zaduziNaLokaciju(Lokacija l);
        void razduziSaLokacije(Lokacija l);
    }
}
