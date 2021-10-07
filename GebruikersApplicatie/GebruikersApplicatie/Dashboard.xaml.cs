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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public int Id;
        Account account = new();
        public Dashboard(int Id)
        {
            InitializeComponent();
            this.Id = Id;

            account.Read(Id);
            btnLogout.Click += Logout;
            btnDeposit.Click += BtnDeposit_Click;
            btnTransactions.Click += BtnTransactions_Click;
            btnWithdraw.Click += BtnWithdraw_Click;
        }

        private void BtnWithdraw_Click(object sender, RoutedEventArgs e)
        {
            WithdrawWindow win = new(Id);
            win.Show();
            Close();
        }

        private void BtnTransactions_Click(object sender, RoutedEventArgs e)
        {
            TransactionsWindow win = new(Id);
            win.Show();
            Close();
        }

        private void BtnDeposit_Click(object sender, RoutedEventArgs e)
        {
            DepositWindow win = new(Id);
            win.Show();
            Close();
        }

        public void Logout(object sender, RoutedEventArgs e)
        {
            MainWindow win = new();
            win.Show();
            Close();
        }
    }
}
