﻿using System;
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
    public sealed partial class DodavanjeClanaAdmin : Page
    {
        TuristickaAgencija tours;
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
            if (password.Text == confpass.Text)
            {
                if (Convert.ToBoolean(vodic.IsChecked))
                    tours.Osobe.Add(new Vodic(name.Text, surname.Text, username.Text, password.Text, email.Text, number.Text, adress.Text));
                else
                    tours.Osobe.Add(new Uposlenik(name.Text, surname.Text, username.Text, password.Text, email.Text, number.Text, adress.Text));
            }
            Page adm = new PregledAdminView(ref tours);
            this.Content = adm;
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Page adm = new PregledAdminView(ref tours);
            this.Content = adm;
        }
    }
}