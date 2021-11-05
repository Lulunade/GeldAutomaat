using ClassLibrary;
using GebruikersApplicatie.Views;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for DepositWindow.xaml
    /// </summary>
    public partial class DepositWindow : Window
    {

        public int Id;
        double transactionAmount = 0;

        Sql Sql = new();
        Transaction transaction = new();
        Account account = new();

        public DepositWindow(int Id)
        {
            InitializeComponent();
            this.Id = Id;

            account.Read(Id);
            lblBalance.Text = $"€ {account.Balance}";
            btnP.Click += BtnP_Click;
            btnP2.Click += BtnP2_Click;
            btnP3.Click += BtnP3_Click;
            btnP4.Click += BtnP4_Click;
            btnP5.Click += BtnP5_Click;
            btnPCustom.Click += BtnPCustom_Click;
            btnBack.Click += BtnBack_Click;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new(this.Id);
            dashboard.Show();
            this.Close();
        }

        private void BtnPCustom_Click(object sender, RoutedEventArgs e)
        {
            CustomDeposit win = new(this.Id, transactionAmount);
            win.Show();
            this.Close();

        }

        private void BtnP5_Click(object sender, RoutedEventArgs e)
        {
            Deposit(500);
        }

        private void BtnP4_Click(object sender, RoutedEventArgs e)
        {
            Deposit(400);
        }

        private void BtnP3_Click(object sender, RoutedEventArgs e)
        {
            Deposit(300);
        }

        private void BtnP2_Click(object sender, RoutedEventArgs e)
        {
            Deposit(200);
        }

        private void Deposit(double amount)
        {

            account.Update(this.Id, account.BankNumber, (account.Balance + amount));
            lblBalance.Text = $"€ {account.Balance}";
            transactionAmount += amount;
        }

        private void BtnP_Click(object sender, RoutedEventArgs e)
        {
            Deposit(100);
        }
    }
}
