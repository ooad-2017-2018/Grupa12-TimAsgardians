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
using System.Text.RegularExpressions;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TuristickaAgencijaAsgardians.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DodavanjeClanaAdmin : Page
    {
        TuristickaAgencija tours;
        Regex imeRegex = new Regex("^([^0-9]*)$");
        Regex brojRegex = new Regex("^[0-9]*$");
        public DodavanjeClanaAdmin()
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
        }

        public DodavanjeClanaAdmin(ref TuristickaAgencija refTours)
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
            tours = refTours;
        }



        private void addclik(object sender, RoutedEventArgs e)
        {

            if (!Validated())
            {
                contentProvider.Content += "Please correct your mistakes!";
            }
            else
            {
                if (Convert.ToBoolean(vodic.IsChecked))
                    tours.Osobe.Add(new Vodic(name.Text, surname.Text, username.Text, password.Text, email.Text, number.Text, adress.Text));
                else
                    tours.Osobe.Add(new Uposlenik(name.Text, surname.Text, username.Text, password.Text, email.Text, number.Text, adress.Text));
                Page adm = new PregledAdminView(ref tours);
                this.Content = adm;
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Page adm = new PregledAdminView(ref tours);
            this.Content = adm;
        }

        private bool Validated()
        {
            if (!imeRegex.IsMatch(name.Text))
            {
                contentProvider.Content = "A name cannot have numbers in it!\n";
                return false;
            }
            if (!imeRegex.IsMatch(surname.Text))
            {
                contentProvider.Content = "A surname cannot have numbers in it!\n";
                return false;
            }
            if (name.Text == "" || surname.Text == "" || adress.Text == "" || number.Text == "" || email.Text == "" || username.Text == "" || password.Text == "" || confpass.Text == "")
            {
                contentProvider.Content = "Fields cannot be empty!\n";
                return false;
            }
            if (!brojRegex.IsMatch(number.Text))
            {
                contentProvider.Content = "Invalid phone number!\n";
                return false;
            }
            if (password.Text != confpass.Text)
            {
                contentProvider.Content = "Passwords do not match!\n";
                return false;
            }
            if (!Convert.ToBoolean(vodic.IsChecked) && !Convert.ToBoolean(uposlenik.IsChecked))
            {
                contentProvider.Content = "Please select what the person is!\n";
                return false;
            }
            return true;
        }
    }
}
