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
    public sealed partial class LogInView : Page
    {
        TuristickaAgencija tours;
        public LogInView()
        {
            this.InitializeComponent();
        }

        public LogInView(ref TuristickaAgencija refTours)
        {
            tours = refTours;
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myView.Navigate(typeof(SignUpView));
            this.Frame.Visibility = 0;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxUser.Text == "admin" && textBoxPass.Text == "admin") myView.Navigate(typeof(PregledAdminView));
        }

        private void textBoxPass_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (textBoxUser.Text == "admin" && textBoxPass.Text == "admin" && e.Key.Equals('\n')) myView.Navigate(typeof(PregledAdminView));
        }

        private void textBoxPass_PreviewKeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (textBoxUser.Text == "admin" && textBoxPass.Text == "admin" && e.Key.Equals('\n')) myView.Navigate(typeof(PregledAdminView));
        }
    }
}
