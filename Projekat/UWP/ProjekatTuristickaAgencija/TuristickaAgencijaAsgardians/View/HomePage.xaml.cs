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
    public sealed partial class HomePage : Page
    {
        TuristickaAgencija tours;
        public HomePage()
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
           
        }

        public HomePage(ref TuristickaAgencija refTours)
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
            tours = refTours;
            lok.Items.Add("London");
            lok.Items.Add("Sarajevo");
            lok.Items.Add("Vienna");
            lok.Items.Add("Moscow");
            foreach (Lokacija l in tours.Lokacije)
            {
                lok.Items.Add(l.Ime);
            }
        }

        private void Detalji_Click(object sender, RoutedEventArgs e)
        {
            string s = lok.SelectedItem.ToString();
            Page page = new DetaljiDestinacije(ref tours,ref s);
            this.Content = page;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Page page = new LogInView(ref tours);
            this.Content = page;
        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            Page page = new SignUpView(ref tours);
            this.Content = page;
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
