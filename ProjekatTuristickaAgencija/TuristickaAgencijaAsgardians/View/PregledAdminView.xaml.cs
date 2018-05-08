using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using TuristickaAgencijaAsgardians.Klase;
using TuristickaAgencijaAsgardians.Klase.Osobe;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TuristickaAgencijaAsgardians.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PregledAdminView : Page
    {
        TuristickaAgencija tours;
        public PregledAdminView()
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
        }

        public PregledAdminView(ref TuristickaAgencija refTours)
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
            tours = refTours;
            foreach (Osoba o in tours.Osobe)
            {
                if (o is Uposlenik) employeL.Items.Add(o);
                else if (o is Vodic) touristL.Items.Add(o);
                else if (o is Putnik) passL.Items.Add(o);
            }
            
        }
        

        private void Button_Click_del(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < tours.Osobe.Count; i++)
            {
                if (tours.Osobe[i].Equals(passL.SelectedItem) || tours.Osobe[i].Equals(touristL.SelectedItem) || tours.Osobe[i].Equals(employeL.SelectedItem))
                    tours.Osobe.Remove(tours.Osobe[i]);
            }
            Page reload = new PregledAdminView(ref tours);
            this.Content = reload;
        }

        private void clickadd(object sender, RoutedEventArgs e)
        {
            
            Page dodajClana = new DodavanjeClanaAdmin(ref tours);
            this.Content = dodajClana;

        }

        private void passL_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
