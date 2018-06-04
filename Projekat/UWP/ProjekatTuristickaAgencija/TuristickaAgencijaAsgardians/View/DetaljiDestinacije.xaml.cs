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
    public sealed partial class DetaljiDestinacije : Page
    {
        TuristickaAgencija tours;
        public DetaljiDestinacije()
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
        }

        public DetaljiDestinacije(ref TuristickaAgencija refTours)
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
            tours = refTours;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Page page = new HomePage(ref tours);
            this.Content = page;
        }

        private void izaberi_Click(object sender, RoutedEventArgs e)
        {
            Page page = new Rezervacija_putnik_(ref tours);
            this.Content = page;
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
