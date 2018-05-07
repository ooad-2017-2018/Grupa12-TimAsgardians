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
            tours = new TuristickaAgencija();
            
        }

        public LogInView(ref TuristickaAgencija refTours)
        {
            this.InitializeComponent();
            tours = new TuristickaAgencija();
            tours = refTours;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page signup = new SignUpView(ref tours);
            this.Content = signup;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxUser.Text == "admin" && textBoxPass.Text == "admin") myView.Navigate(typeof(PregledAdminView));
            for(int i = 0; i < tours.Osobe.Count; i++)
            {
                if(textBoxUser.Text == tours.Osobe[i].Username && textBoxPass.Text == tours.Osobe[i].Password)
                {
                    if (tours.Osobe[i].GetType() == typeof(Admin))
                    {
                        Page admPage = new PregledAdminView(ref tours);
                        this.Content = admPage;
                    }
                    if (tours.Osobe[i].GetType()==typeof(Vodic))
                    {
                        Page admPage = new Pregled_Vodic_(ref tours);
                        this.Content = admPage;
                    }//promjenit
                    if (tours.Osobe[i].GetType() == typeof(Putnik))
                    {
                        Page admPage = new HomePage(ref tours);
                        this.Content = admPage;
                    }//promjenit
                    if (tours.Osobe[i].GetType() == typeof(Uposlenik))
                    {
                        Page uposPage = new UposlenikView(ref tours);
                        this.Content = uposPage;
                    }

                }
            }
        }

        private void textBoxPass_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (textBoxUser.Text == "admin" && textBoxPass.Text == "admin" && e.Key.Equals('\n')) myView.Navigate(typeof(PregledAdminView));
        }

        private void textBoxPass_PreviewKeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (textBoxUser.Text == "admin" && textBoxPass.Text == "admin" && e.Key.Equals('\n')) myView.Navigate(typeof(PregledAdminView));
        }

        private void myView_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void myView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
