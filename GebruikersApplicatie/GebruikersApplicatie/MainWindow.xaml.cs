using ClassLibrary;
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

namespace GebruikersApplicatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sql SQL = new();
        int count = 0;

        public MainWindow()
        {
            InitializeComponent();
            Client user1 = new();
            user1.Create("Layla", "Haarbosch", "noreply@github.com", "0123456789");
        }

        private void BtnNumber_Click(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            string n = btnThis.Content.ToString();
            txbLogin.Text += n;
        }


        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            if (txbLogin.Text.Length >= 1)
            {
                txbLogin.Text = txbLogin.Text.Substring(0,txbLogin.Text.Length - 1);
            }
        }

        private void BtnEvaluate_Click(object sender, RoutedEventArgs e)
        {
            string userBankNumber;
            string userPin;

            if (count == 0)
            {
                userBankNumber = txbLogin.Text;


                txbLogin.Clear();

                count++;

                lblLogin.Content = "Voer uw pincode in:";

            } else if (count == 1)
            {
                userPin = txbLogin.Text;
                txbLogin.Clear();

                count++;
            } else if (count == 2)
            {
                MessageBox.Show("Je bent al ingelogd");
            }
        }
    }
}
