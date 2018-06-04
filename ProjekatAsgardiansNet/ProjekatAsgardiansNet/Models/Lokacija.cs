using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjekatAsgardiansNet.Models
{
    public class Lokacija
    {
        [Required]
        protected string ime;
        protected string informacije;
        [Required]
        protected double cijena;

        protected List<string> listaHotela;
        protected List<Putnik> listaPutnika;
        protected List<string> atrakcija;

        [ScaffoldColumn(false)]
        public int LokacijaId { get; set; }

        public Lokacija()
        {
        }

        public Lokacija(string informacije, double cijena, List<string> listaHotela, List<string> atrakcija, string ime)
        {
            Informacije = informacije;
            Cijena = cijena;
            ListaHotela = listaHotela;

            Atrakcija = atrakcija;
            Ime = ime;
        }

        public Lokacija(Lokacija l)
        {
            informacije = l.Informacije;
            cijena = l.Cijena;
            listaHotela = l.ListaHotela;
            ListaPutnika = l.ListaPutnika;
            atrakcija = l.Atrakcija;
            ime = l.Ime;
        }

        public string Informacije { get => informacije; set => informacije = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public List<string> ListaHotela { get => listaHotela; set => listaHotela = value; }
        public List<string> Atrakcija { get => atrakcija; set => atrakcija = value; }
        public string Ime { get => ime; set => ime = value; }
        public List<Putnik> ListaPutnika { get => listaPutnika; set => listaPutnika = value; }

        public void dodajPutnika(Putnik p)
        {
            ListaPutnika.Add(new Putnik(p));
        }
        public void obrisiPutnika(Putnik p)
        {
            foreach (Putnik put in ListaPutnika)
            {
                if (put.Equals(p))
                {
                    ListaPutnika.Remove(p);
                    break;
                }
            }
        }
        public void obrisiPutnike()
        {

        }
    }
}