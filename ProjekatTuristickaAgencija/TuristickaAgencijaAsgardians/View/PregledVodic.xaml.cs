using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class Pregled_Vodic_ : Page
    {
        TuristickaAgencija tours;
        public Pregled_Vodic_()
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
        }
        public Pregled_Vodic_(ref TuristickaAgencija refTours)
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
            tours = refTours;
            foreach(Lokacija l in tours.Lokacije)
            {
                lokacije.Items.Add(l.Ime);
            }
        }
        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private async void detaljibutton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("neki detalji o lokaciji"); 
            await dialog.ShowAsync();
        }

        private void izabeributton_Click(object sender, RoutedEventArgs e)
        {
            //stavlja ga u listu
        }
    }
}
