﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristickaAgencijaAsgardians.Klase.Osobe;

namespace TuristickaAgencijaAsgardians.Klase
{
    public class Lokacija
    {
        public int LokacijaId { get; set; }
        private string ime;
        private string informacije;
        private double cijena;
        private List<string> listaHotela;
        private List<Putnik> listaPutnika;
        private List<string> atrakcija;

        public Lokacija()
        {
        }

        public Lokacija(string informacije, double cijena, string ime)
        {
            this.informacije = informacije;
            this.cijena = cijena;
            this.ime = ime;
            listaHotela = new List<string>();
            listaPutnika = new List<Putnik>();
            atrakcija = new List<string>();
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
            LokacijaId = l.LokacijaId;
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
            //NE VALJA
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
