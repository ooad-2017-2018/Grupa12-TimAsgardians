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
    public sealed partial class UposlenikView : Page
    {
        TuristickaAgencija tours;
        public UposlenikView()
        {
            this.InitializeComponent();
        }

        private async void clkpassdet(object sender, RoutedEventArgs e)
        {
            
            var dialog = new MessageDialog(putnikL.SelectedValue.ToString()); //mozda de se prepravi na pojedinacni string
            await dialog.ShowAsync();
        }

        private void clkaddlokacija(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SignUpView));//dodat formu za dodavanje lokacija
            this.Frame.Visibility = 0;
        }

        private void clkobrisilokaciju(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < tours.Lokacije.Count; i++)
            {
                if (tours.Lokacije[i].Ime.Equals(lokacije.SelectedItem)) 
                tours.Lokacije.Remove(tours.Lokacije[i]);
            }
        }

        private void pregledputnikanalokaciji(object sender, RoutedEventArgs e)
        {
            
            for (int i = 0; i < tours.Lokacije.Count; i++)
            {
                if(tours.Lokacije[i].Ime==lokacije.SelectedValue.ToString())
                    for(int j = 0; j < tours.Lokacije[i].ListaPutnika.Count; j++)
                    {
                        putnikL.Items.Add(tours.Lokacije[i].ListaPutnika[j].Ime+" "+ tours.Lokacije[i].ListaPutnika[j].Prezime);
                    }
            }
               
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
