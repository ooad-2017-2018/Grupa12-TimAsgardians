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
    public sealed partial class SignUpView : Page
    {
        TuristickaAgencija tours;
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

        private void Button_Click_SignUp(object sender, RoutedEventArgs e)
        {           
            if (password.Text==confpassowrd.Text)
                tours.Osobe.Add(new Putnik(name.Text, surname.Text, username.Text, password.Text, email.Text, phnumber.Text, adress.Text));

            //Treba promijeniti u novu formu
            Page novi = new PregledAdminView(ref tours);
            this.Content = novi;
        }
    }
}
