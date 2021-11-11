using ClassLibrary;
using GebruikersApplicatie.Views;
using System;
using System.Collections.Generic;
using System.Data;
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

        Sql Sql = new();
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
            CustomWithdrawWindow win = new(this.Id, transactionAmount);
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
            string SQL = "SELECT COUNT(ID) FROM `transaction` WHERE(`date` > { fn CURRENT_DATE() }) AND " + string.Format("`account_ID` = {0} AND `deposit` = '-' ORDER BY `date` DESC", this.Id); 
            DataTable dtb = Sql.getDataTable(SQL);

            string countString = dtb.Rows[0]["COUNT(ID)"].ToString();
            int count = Convert.ToInt32(countString);

            if (transactionAmount + amount > 500)
            {
                MessageBox.Show("Je kunt niet meer dan €500 per keer pinnen");
            }
            if (account.Balance - amount < 0)
            {
                MessageBox.Show("Je hebt niet genoeg geld op je rekening");
            }
            else if (count >= 3)
            {
                MessageBox.Show("Je mag niet meer dan drie keer per dag geld pinnen");
            } else
            {
                account.Update(this.Id, account.BankNumber, account.Balance - amount);
                lblBalance.Text = $"€ {account.Balance}";
                Debug.WriteLine(account.Balance);
                transactionAmount += amount;
            }
        }

        private void BtnP_Click(object sender, RoutedEventArgs e)
        {
            Deposit(100);
        }
    }
}
