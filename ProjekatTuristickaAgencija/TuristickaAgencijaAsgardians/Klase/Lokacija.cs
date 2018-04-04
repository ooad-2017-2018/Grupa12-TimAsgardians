using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencijaAsgardians.Klase.Osobe;

namespace TuristickaAgencijaAsgardians.Klase
{
    public class Lokacija
    {
        //private List<>
        private string informacije;
        private double cjena;
        private List<string> listaHotela;
        private List<Osobe.Putnik> listaPutnika;
        private List<string> atrakcija;

        public Lokacija()
        {
        }

        public string Informacije { get => informacije; set => informacije = value; }
        public double Cjena { get => cjena; set => cjena = value; }
        public List<string> ListaHotela { get => listaHotela; set => listaHotela = value; }
        public List<Putnik> ListaPutnika { get => listaPutnika; set => listaPutnika = value; }
        public List<string> Atrakcija { get => atrakcija; set => atrakcija = value; }

        public void dodajPutnika(Putnik p)
        {

        }
        public void obrisiPutnika(Putnik p)
        {

        }
        public void obrisiPutnike()
        {

        }
    }
}
