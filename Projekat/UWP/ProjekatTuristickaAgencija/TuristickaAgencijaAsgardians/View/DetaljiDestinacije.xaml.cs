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
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;

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

        public DetaljiDestinacije(ref TuristickaAgencija refTours, ref string l)
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
            tours = refTours;

            if (l.Equals("Sarajevo"))
            {
                Geopoint lok = new Geopoint(new BasicGeoposition() { Latitude = 43.85, Longitude = 18.41 });
                MapIcon myPOI = new MapIcon { Location = lok, NormalizedAnchorPoint = new Point(0.5, 1.0), Title = "Destination", ZIndex = 0 };
                mapa.MapElements.Add(myPOI);
                mapa.Center = lok;
                mapa.ZoomLevel = 10;
            }
            if (l.Equals("London"))
            {
                Geopoint lok = new Geopoint(new BasicGeoposition() { Latitude = 51.50, Longitude = 0.12 });
                MapIcon myPOI = new MapIcon { Location = lok, NormalizedAnchorPoint = new Point(0, 0), Title = "Destination", ZIndex = 0 };                
                mapa.MapElements.Add(myPOI);

                mapa.Center = lok;
                mapa.ZoomLevel = 10;
            }
            if (l.Equals("Vienna"))
            {
                Geopoint lok = new Geopoint(new BasicGeoposition() { Latitude = 48.20, Longitude = 16.37 });
                MapIcon myPOI = new MapIcon { Location = lok, NormalizedAnchorPoint = new Point(5.0, 1.5), Title = "Destination", ZIndex = 0 };
                mapa.MapElements.Add(myPOI);
                mapa.Center = lok;
                mapa.ZoomLevel = 10;
            }
            if (l.Equals("Moscow"))
            {
                Geopoint lok = new Geopoint(new BasicGeoposition() { Latitude =55.75, Longitude = 37.61 });
                MapIcon myPOI = new MapIcon { Location = lok, NormalizedAnchorPoint = new Point(2.7 , 3.3), Title = "Destination", ZIndex = 0 };
                mapa.MapElements.Add(myPOI);
                mapa.Center = lok;
                mapa.ZoomLevel = 10;
            }
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
