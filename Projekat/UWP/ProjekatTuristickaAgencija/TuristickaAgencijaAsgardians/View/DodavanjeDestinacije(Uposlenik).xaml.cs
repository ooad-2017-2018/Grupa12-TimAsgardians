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
    public sealed partial class DodavanjeDestinacije_Uposlenik_ : Page
    {
        TuristickaAgencija tours;
        public DodavanjeDestinacije_Uposlenik_()
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
        }

        public DodavanjeDestinacije_Uposlenik_(ref TuristickaAgencija refTours)
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
            tours = refTours;
        }

        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            List<string> ls=new List<string>();
            for(int i=0; i<hoteli.Text.Length; i++)
            {
                int a = i;
                while (hoteli.Text[a] != ',') a++;
                string s = hoteli.Text.Substring(i, a-1);
                i = a;
                ls.Add(s);
            }
            List<string> la = new List<string>();
            for (int i = 0; i < mainatr.Text.Length; i++)
            {
                int a = i;
                while (mainatr.Text[a] != ',') a++;
                string s = mainatr.Text.Substring(i, a-1);
                i = a;
                la.Add(s);
            }

            tours.Lokacije.Add(new Lokacija(info.Text,Convert.ToDouble(cjena.Text),ls,la,ime.Text));
            Page page = new UposlenikView(ref tours);
            this.Content = page;
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
