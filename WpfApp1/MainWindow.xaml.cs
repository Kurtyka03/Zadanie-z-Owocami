using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Zi;
        bool Zu;
        bool N;
        bool C;
        public MainWindow()
        {
            InitializeComponent();
        }

        // Zaznaczanie wszystkich
        private void zaznaczZielone(object sender, RoutedEventArgs e)
        {
            if (WszystkieZielone.IsChecked == true){
                Zielony1.IsChecked = true;
                Zielony2.IsChecked = true;
                Zielony3.IsChecked = true;
                Zielony4.IsChecked = true;
            }else if(WszystkieZielone.IsChecked == false)
            {
                Zielony1.IsChecked = false;
                Zielony2.IsChecked = false;
                Zielony3.IsChecked = false;
                Zielony4.IsChecked = false;
            }
        }

        private void zaznaczzolte(object sender, RoutedEventArgs e)
        {
            if (WszystkieZolte.IsChecked == true)
            {
                Zolty1.IsChecked = true;
                Zolty2.IsChecked = true;
                Zolty3.IsChecked = true;
                Zolty4.IsChecked = true;
            }
            else if (WszystkieZolte.IsChecked == false)
            {
                Zolty1.IsChecked = false;
                Zolty2.IsChecked = false;
                Zolty3.IsChecked = false;
                Zolty4.IsChecked = false;
            }
        }

        private void zaznaczNiebieskie(object sender, RoutedEventArgs e)
        {
            if (WszystkieNiebieskie.IsChecked == true)
            {
                Niebieski1.IsChecked = true;
                Niebieski2.IsChecked = true;
                Niebieski3.IsChecked = true;
                Niebieski4.IsChecked = true;
            }
            else if (WszystkieNiebieskie.IsChecked == false)
            {
                Niebieski1.IsChecked = false;
                Niebieski2.IsChecked = false;
                Niebieski3.IsChecked = false;
                Niebieski4.IsChecked = false;
            }
        }

        private void zaznaczCzerwone(object sender, RoutedEventArgs e)
        {
            if (Wszystkieczerwone.IsChecked == true)
            {
                Czerwony1.IsChecked = true;
                Czerwony2.IsChecked = true;
                Czerwony3.IsChecked = true;
                Czerwony4.IsChecked = true;
            }
            else if (Wszystkieczerwone.IsChecked == false)
            {
                Czerwony1.IsChecked = false;
                Czerwony2.IsChecked = false;
                Czerwony3.IsChecked = false;
                Czerwony4.IsChecked = false;
            }
        }

        // ----->

        // Blokaza zaznaczania

        private void OnlyGreen_Checked(object sender, RoutedEventArgs e)
        {
            if( OnlyGreen.IsChecked == true )
            {
                Zu = false;
                N = false;
                C = false;
                BlokujNiebieskie(N);
                BlokujCzerwone(C);
                BlokujZolte(Zu);
            }
            else if( OnlyGreen.IsChecked == false)
            {
                Zu = true;
                N = true;
                C = true;
                BlokujNiebieskie(N);
                BlokujCzerwone(C);
                BlokujZolte(Zu);
            }
        }

        private void OnlyYelow_Checked(object sender, RoutedEventArgs e)
        {
            if( OnlyYelow.IsChecked == true)
            {
                Zi = true;
                N = true;
                C = true;
                BlokujCzerwone(C);
                BlokujZielone(Zi);
                BlokujNiebieskie(N);
            }
            else if()
        }

        private void OnlyBlue_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void OnlyRed_Checked(object sender, RoutedEventArgs e)
        {

        }

        // Funkcje blokujace

        private void BlokujNiebieskie(bool N)
        {
            if(OnlyGreen.IsChecked == true)
            {
                OnlyRed.IsEnabled = N;
                OnlyYelow.IsEnabled = N;
                OnlyBlue.IsEnabled = N;
            }
            else if(OnlyRed.IsChecked == true)
            {
                OnlyGreen.IsEnabled = N;
                OnlyYelow.IsEnabled = N;
                OnlyBlue.IsEnabled = N;
            }
            else if (OnlyYelow.IsChecked == true)
            {
                OnlyGreen.IsEnabled = N;
                OnlyRed.IsEnabled = N;
                OnlyBlue.IsEnabled = N;
            }
            else
            {
                OnlyBlue.IsEnabled = N;
                OnlyGreen.IsEnabled = N;
                OnlyRed.IsEnabled = N;
                OnlyBlue.IsEnabled = N;
            }
            WszystkieNiebieskie.IsEnabled = N;
            Niebieski1.IsEnabled = N;
            Niebieski2.IsEnabled = N;
            Niebieski3.IsEnabled = N;
            Niebieski4.IsEnabled = N;
        }
        private void BlokujZolte(bool Zu)
        {
            if (OnlyGreen.IsChecked == true)
            {
                OnlyYelow.IsEnabled = Zu;
                OnlyRed.IsEnabled = Zu;
                OnlyBlue.IsEnabled = Zu;
            }
            else if (OnlyRed.IsChecked == true)
            {
                OnlyGreen.IsEnabled = Zu;
                OnlyYelow.IsEnabled = Zu;
                OnlyBlue.IsEnabled = Zu;
            }
            else if (OnlyBlue.IsChecked == true)
            {
                OnlyGreen.IsEnabled = Zu;
                OnlyRed.IsEnabled = Zu;
                OnlyYelow.IsEnabled = Zu;
            }
            else
            {
                OnlyGreen.IsEnabled = Zu;
                OnlyRed.IsEnabled = Zu;
                OnlyBlue.IsEnabled = Zu;
                OnlyYelow.IsEnabled = Zu;
            }
            WszystkieZolte.IsEnabled = Zu;
            Zolty1.IsEnabled = Zu;
            Zolty2.IsEnabled = Zu;
            Zolty3.IsEnabled = Zu;
            Zolty4.IsEnabled = Zu;
        }
        private void BlokujZielone(bool Zi)
        {
            if (OnlyBlue.IsChecked == true)
            {
                OnlyGreen.IsEnabled = Zi;
                OnlyRed.IsEnabled = Zi;
                OnlyYelow.IsEnabled = Zi;
            }
            else if (OnlyRed.IsChecked == true)
            {
                OnlyBlue.IsEnabled = Zi;
                OnlyGreen.IsEnabled = Zi;
                OnlyYelow.IsEnabled = Zi;
            }
            else if (OnlyYelow.IsChecked == true)
            {
                OnlyBlue.IsEnabled = Zi;
                OnlyRed.IsEnabled = Zi;
                OnlyGreen.IsEnabled = Zi;
            }
            else
            {
                OnlyBlue.IsEnabled = Zi;
                OnlyRed.IsEnabled = Zi;
                OnlyYelow.IsEnabled = Zi;
                OnlyGreen.IsEnabled = Zi;
            }
            WszystkieZielone.IsEnabled = Zi;
            Zielony1.IsEnabled = Zi;
            Zielony2.IsEnabled = Zi;
            Zielony3.IsEnabled = Zi;
            Zielony4.IsEnabled = Zi;
        }
        private void BlokujCzerwone(bool C)
        {
            if (OnlyGreen.IsChecked == true)
            {
                OnlyRed.IsEnabled = C;
                OnlyBlue.IsEnabled = C;
                OnlyYelow.IsEnabled = C;
            }
            else if (OnlyBlue.IsChecked == true)
            {
                OnlyRed.IsEnabled = C;
                OnlyGreen.IsEnabled = C;
                OnlyYelow.IsEnabled = C;
            }
            else if (OnlyYelow.IsChecked == true)
            {
                OnlyRed.IsEnabled = C;
                OnlyBlue.IsEnabled = C;
                OnlyGreen.IsEnabled = C;
            }
            else
            {
                OnlyRed.IsEnabled = C;
                OnlyBlue.IsEnabled = C;
                OnlyYelow.IsEnabled = C;
                OnlyGreen.IsEnabled = C;
            }
            Wszystkieczerwone.IsEnabled = C;
            Czerwony1.IsEnabled = C;
            Czerwony2.IsEnabled = C;
            Czerwony3.IsEnabled = C;
            Czerwony4.IsEnabled = C;
        }

        // ----->
    }
}
