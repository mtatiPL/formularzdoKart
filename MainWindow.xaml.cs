using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace kartkowka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string wytnij(string str)
        {
            //str.ToString();
            str = str.ToLower();
            str = str.Substring(0, 3);
            return str;
        }

        private void Generuj(object sender, RoutedEventArgs e)
        {
            string imie = im.Text;
            string nazwisko = naz.Text;
            int liczba = RandomNumberGenerator.GetInt32(10);
            string haslo1 = haslo.Text;
            string haslo2 = powHaslo.Text;
            if (haslo1 == haslo2 && haslo1.Length > 0 && haslo2.Length > 0)
            {
                MessageBox.Show("Login: " + wytnij(imie) + wytnij(nazwisko) + liczba + " Haslo: " + haslo1, "Twoje konto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Niepoprawne hasło, spróbuj jeszcze raz :((", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
