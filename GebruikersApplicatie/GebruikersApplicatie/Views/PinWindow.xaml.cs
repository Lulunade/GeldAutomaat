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
using System.Windows.Shapes;

namespace GebruikersApplicatie
{
    /// <summary>
    /// Interaction logic for PinWindow.xaml
    /// </summary>
    public partial class PinWindow : Window
    {
        int Id;
        Account Account = new();

        public PinWindow(int Id)
        {
            InitializeComponent();
            this.Id = Id;
            txbLogin.Focus();
        }

        private void BtnNumber_Click(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            string n = btnThis.Content.ToString();
            txbLogin.Password += n;
        }


        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            if (txbLogin.Password.Length >= 1)
            {
                txbLogin.Password = txbLogin.Password[0..^1];
            }
        }

        private void BtnEvaluate_Click(object sender, RoutedEventArgs e)
        {
            int Id = this.Id;
            Account.Read(Id);
            string userBankNumber = Account.BankNumber;
            string userPin = txbLogin.Password;
            if (SecurePasswordHasher.Verify(userPin, Account.Pin))
            {
                if (!Account.Blocked)
                {
                    Dashboard dashboard = new(Id);
                    dashboard.Show();
                    Close();
                } else
                {
                    MessageBox.Show("Je kunt niet inloggen, jouw account is geblokkeerd!");
                }
            } else
            {
                MessageBox.Show("Pincode is ONJUIST!");
            }
            
            txbLogin.Clear();
        }
    }
}
