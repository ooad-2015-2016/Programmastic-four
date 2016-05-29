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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatE_CinemaStar.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Pocetnaa : Page
    {
        public Pocetnaa()
        {
            this.InitializeComponent();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginKorisnika));
        }

        private void buttonSignup_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SignupKorisnika));
        }

        private void buttonRepertoar_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(OdabirFilma));
        }

    }
}
