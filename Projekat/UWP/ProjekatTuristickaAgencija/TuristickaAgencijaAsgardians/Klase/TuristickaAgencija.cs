using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using TuristickaAgencijaAsgardians.Klase.Osobe;

namespace TuristickaAgencijaAsgardians.Klase
{
    public class TuristickaAgencija
    {
        private List<Osoba> osobe;
        private List<Lokacija> lokacije;

        

        

        //IMobileServiceTable<Admin> adminTabela = App.mobileService.GetTable<Admin>();
        public List<Osoba> Osobe { get { return osobe; } set { this.osobe = value; } }
        public List<Lokacija> Lokacije { get => lokacije; set => lokacije = value; }
        public List<Putnik> Putnici { get => putnici; set => putnici = value; }
        public List<Uposlenik> Uposlenici { get => uposlenici; set => uposlenici = value; }
        public List<Vodic> Vodici { get => vodici; set => vodici = value; }
        public List<Admin> Admins { get => admins; set => admins = value; }

        private List<Putnik> putnici = new List<Putnik>();
        private List<Uposlenik> uposlenici = new List<Uposlenik>();
        private List<Vodic> vodici = new List<Vodic>();
        private List<Admin> admins = new List<Admin>();
             

        string apiURL = "http://projekatasgardianswebapi.azurewebsites.net/";

        public TuristickaAgencija()
        {
            osobe = new List<Osoba>();
            lokacije = new List<Lokacija>();
        }

        public void povuciPodatkeSBaze()
        {
            dajAdmine();
            dajLokacije();
            dajPutnike();
            dajUposlenike();
            dajVodice();
        }

        public async void dajAdmine()
        {
            var k = await getAdmin();
            admins = new List<Admin>(k);
        }

        public static async Task<ObservableCollection<Admin>> getAdmin()
        {
            
            ObservableCollection<Admin> admins = new ObservableCollection<Admin>();
            var lista = App.mobileService.GetTable<Putnik>();
            var kor = from x in lista
                      select x;
            var listatmp = await kor.ToListAsync();
            foreach (var x in listatmp)
            {
                admins.Add(new Admin(x.Ime, x.Prezime, x.Username, x.Password, x.Email, x.Brtel, x.Adresa));
            }
            
            return admins;
        }

        public async void dajPutnike()
        {
            var k = await getPutnik();
            putnici = new List<Putnik>(k);
        }

        public static async Task<ObservableCollection<Putnik>> getPutnik()
        {
            ObservableCollection<Putnik> putnicis = new ObservableCollection<Putnik>();
            var lista = App.mobileService.GetTable<Putnik>();
            var kor = from x in lista
                      select x;
            var listatmp = await kor.ToListAsync();
            foreach (var x in listatmp)
            {
                putnicis.Add(new Putnik(x.Ime, x.Prezime, x.Username, x.Password, x.Email, x.Brtel, x.Adresa));
            }
            return putnicis;
        }

        public async void dajUposlenike()
        {
            var k = await getUposlenik();
            uposlenici = new List<Uposlenik>(k);
        }

        public static async Task<ObservableCollection<Uposlenik>> getUposlenik()
        {
            ObservableCollection<Uposlenik> uposlenics = new ObservableCollection<Uposlenik>();
            var lista = App.mobileService.GetTable<Uposlenik>();
            var kor = from x in lista
                      select x;
            var listatmp = await kor.ToListAsync();
            foreach (var x in listatmp)
            {
                uposlenics.Add(new Uposlenik(x.Ime, x.Prezime, x.Username, x.Password, x.Email, x.Brtel, x.Adresa));
            }
            return uposlenics;
        }

        public async void dajVodice()
        {
            var k = await getVodic();
            vodici = new List<Vodic>(k);
        }

        public static async Task<ObservableCollection<Vodic>> getVodic()
        {
            ObservableCollection<Vodic> vodics = new ObservableCollection<Vodic>();
            var lista = App.mobileService.GetTable<Uposlenik>();
            var kor = from x in lista
                      select x;
            var listatmp = await kor.ToListAsync();
            foreach (var x in listatmp)
            {
                vodics.Add(new Vodic(x.Ime, x.Prezime, x.Username, x.Password, x.Email, x.Brtel, x.Adresa));
            }
            return vodics;
        }

        public async void dajLokacije()
        {
            var k = await getLokacije();
            lokacije = new List<Lokacija>(k);
        }

        public static async Task<ObservableCollection<Lokacija>> getLokacije()
        {
            ObservableCollection<Lokacija> lokacijas = new ObservableCollection<Lokacija>();
            var lista = App.mobileService.GetTable<Lokacija>();
            var kor = from x in lista
                      select x;
            var listatmp = await kor.ToListAsync();
            foreach (var x in listatmp)
            {
                lokacijas.Add(new Lokacija(x.Informacije, x.Cijena, x.Ime));
            }
            return lokacijas;
        }

        public void dodajAdmina(Admin a)
        {
            osobe.Add(new Admin(a));
        }
        public void dodajUposlenika(Uposlenik u)
        {
            osobe.Add(new Uposlenik(u));
        }
        public void dodajVodica(Vodic v)
        {
            osobe.Add(new Vodic(v));
        }
        public void dodajPutnika(Putnik p)
        {
            osobe.Add(new Putnik(p));
        }

        public void obrisiAdmina(Admin a)
        {
            foreach (Admin adm in admins)
            {
                if (adm.Equals(a))
                {
                    osobe.Remove(a);
                    admins.Remove(a);
                    break;
                }
            }
        }
        public void obrisiUposlenika(Uposlenik u)
        {
            
            foreach (Uposlenik up in uposlenici)
            {
                if (up.Equals(u))
                {
                    osobe.Remove(u);
                    uposlenici.Remove(u);
                    break;
                }
            }
        }
        public void obrisiVodica(Vodic v)
        {
            
            foreach (Vodic vod in vodici)
            {
                if (vod.Equals(v))
                {
                    osobe.Remove(v);
                    vodici.Remove(v);
                    break;
                }
            }
        }
        public void obrisiPutnika(Putnik p)
        {
           
            foreach (Putnik put in putnici)
            {
                if (put.Equals(p))
                {
                    osobe.Remove(p);
                    putnici.Remove(p);
                    break;
                }
            }
        }

        public void dodajLokaciju(Lokacija l)
        {
            lokacije.Add(new Lokacija(l));
        }
        public void obrisiLokaciju(Lokacija l)
        {
            foreach (Lokacija lok in lokacije)
            {
                if (lok.Equals(l))
                {
                    lokacije.Remove(l);
                    break;
                }
            }
        }

    }
}
