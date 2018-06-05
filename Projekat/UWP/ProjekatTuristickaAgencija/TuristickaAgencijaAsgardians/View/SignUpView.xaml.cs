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
using Microsoft.WindowsAzure.MobileServices;
using TuristickaAgencijaAsgardians.Klase;
using TuristickaAgencijaAsgardians.Klase.Osobe;
using System.Text.RegularExpressions;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TuristickaAgencijaAsgardians.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SignUpView : Page
    {
        TuristickaAgencija tours;
        Regex imeRegex = new Regex("^([^0-9]*)$");
        Regex brojRegex = new Regex("^[0-9]*$");
        public SignUpView()
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
        }

        public SignUpView(ref TuristickaAgencija refTours)
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
            tours = refTours;
        }


        private void Button_ClickLogIn(object sender, RoutedEventArgs e)
        {
            Page login = new LogInView(ref tours);
            this.Content = login;
        }
        IMobileServiceTable<Putnik> putniciTable = App.mobileService.GetTable<Putnik>();
        private void Button_Click_SignUp(object sender, RoutedEventArgs e)
        {
            if (!Validated())
            {
                contentProvider.Content += "Please correct your mistakes!";
            }
            else
            {
                Putnik tempPut = new Putnik(name.Text, surname.Text, username.Text, password.Text, email.Text, phnumber.Text, adress.Text);
                tours.Osobe.Add(tempPut);
                tours.Putnici.Add(tempPut);
                tempPut.PutnikId = tours.Putnici.Count;
                putniciTable.InsertAsync(tempPut);

                Page page = new HomePage(ref tours);
                this.Content = page;
            }
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

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
            if (name.Text == "" || surname.Text == "" || adress.Text == "" || phnumber.Text == "" || email.Text == "" || username.Text == "" || password.Text == "" || confpassowrd.Text == "")
            {
                contentProvider.Content = "Fields cannot be empty!\n";
                return false;
            }
            if (!brojRegex.IsMatch(phnumber.Text))
            {
                contentProvider.Content = "Invalid phone number!\n";
                return false;
            }
            if (password.Text != confpassowrd.Text)
            {
                contentProvider.Content = "Passwords do not match!\n";
                return false;
            }
            return true;
        }
    }
}
