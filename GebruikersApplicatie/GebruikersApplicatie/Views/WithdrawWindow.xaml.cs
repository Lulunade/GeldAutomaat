using ClassLibrary;
using GebruikersApplicatie.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for WithdrawWindow.xaml
    /// </summary>
    public partial class WithdrawWindow : Window
    {
        public int Id;

        double transactionAmount = 0;
        bool withdrawn = false;

        Account account = new();
        Transaction transaction = new();

        public WithdrawWindow(int Id)
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
        }

        private void BtnPCustom_Click(object sender, RoutedEventArgs e)
        {
            CustomWithdrawWindow custom = new CustomWithdrawWindow(this.Id);
            if (withdrawn)
            {
                MessageBox.Show("Je moet eerst uitloggen");
            }
            if (transactionAmount == 0)
            {
                MessageBox.Show("Er is nog niks ingevuld");
            } else
            {
                transaction.Create(transactionAmount, "-", this.Id);
                withdrawn = true;
                Dashboard win = new(this.Id);
                win.Show();
                this.Close();
            }
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
            if (transactionAmount + amount > 500)
            {
                MessageBox.Show("Je kunt niet meer dan €500 per keer pinnen");
            } else
            {
                transactionAmount += amount;
                account.Update(this.Id, account.BankNumber, (account.Balance - amount));
                account.Balance = account.Balance - amount;
                lblBalance.Text = $"€ {account.Balance}";
            }
        }

        private void BtnP_Click(object sender, RoutedEventArgs e)
        {
            Deposit(100);
        }
    }
}
