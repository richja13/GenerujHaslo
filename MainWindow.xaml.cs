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


namespace Egzamin
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

        private void CopyPassword(object sender, RoutedEventArgs e)
        {
            if (wynik.Text is null) return;
            System.Windows.Clipboard.SetText(wynik.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String litery;
            int lenght = int.Parse(Dlugosc.Text);

            if(duze.IsChecked.Value && cyfry.IsChecked.Value && znaki.IsChecked.Value)
            {
                litery = "abcdefghijklmnoprstuwxyzABCDEFGHIJKLMNOPRSTUWXYZ@#$%&!1234567890";
            }
            else if(duze.IsChecked.Value && cyfry.IsChecked.Value)
            {
                litery = "abcdefghijklmnoprstuwxyzABCDEFGHIJKLMNOPRSTUWXYZ1234567890";
            }
            else if(duze.IsChecked.Value)
            {
                litery = "abcdefghijklmnoprstuwxyzABCDEFGHIJKLMNOPRSTUWXYZ";
            }
            else if(cyfry.IsChecked.Value)
            {
                litery = "abcdefghijklmnoprstuwxyz1234567890";
            }
            else if(znaki.IsChecked.Value)
            {
                litery = "abcdefghijklmnoprstuwxyz@#$%&!";
            }
            else if(cyfry.IsChecked.Value && znaki.IsChecked.Value)
            {
                litery = "abcdefghijklmnoprstuwxyz@#$%&!1234567890";
            }
            else if(duze.IsChecked.Value && znaki.IsChecked.Value)
            {
                litery = "abcdefghijklmnoprstuwxyzABCDEFGHIJKLMNOPRSTUWXYZ@#$%&!";
            }
            else
            {
                litery = "abcdefghijklmnoprstuwxyz";
            }

            wynik.Text = CreatePassword(lenght, litery);
         
        }

        public String CreatePassword(int lenght, String litery)
        {
            StringBuilder sb = new StringBuilder();
            Random rn = new Random();
            while (0 < lenght--)
            {
                sb.Append(litery[rn.Next(litery.Length)]);
            }

            return sb.ToString();
        }
    }

    
}
