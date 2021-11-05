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

namespace GebruikersApplicatie.Views
{
    /// <summary>
    /// Interaction logic for CustomDepositWindow.xaml
    /// </summary>
    public partial class CustomDeposit : Window
    {
        Sql Sql = new Sql();
        Transaction transaction = new();
        Account account = new();

        public int Id { get; set; }
        public double TransactionAmount { get; set; }

        public CustomDeposit(int id, double transactionAmount)
        {
            InitializeComponent();
            this.Id = id;
            this.TransactionAmount = transactionAmount;
            account.Read(this.Id);
            btnBack.Click += BtnBack_Click;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new(this.Id);
            dashboard.Show();
            this.Close();

        }

        private void btnNumber_Click(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            string n = btnThis.Content.ToString();
            txbAmount.Text += n;
        }


        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            if (txbAmount.Text.Length >= 1)
            {
                txbAmount.Text = txbAmount.Text.Substring(0, txbAmount.Text.Length - 1);
            }
        }

        private void btnEvaluate_Click(object sender, RoutedEventArgs e)
        {
            if (txbAmount.Text == "")
            {
                transaction.Create(this.TransactionAmount, "+", this.Id);
                Endscreen end = new(this.Id, this.TransactionAmount, "+");
                end.Show();
                this.Close();
            }
            else
            {
                double amount = Convert.ToDouble(txbAmount.Text);
                txbAmount.Clear();
                account.Update(this.Id, account.BankNumber, (account.Balance + amount));


                this.TransactionAmount += amount;
                transaction.Create(this.TransactionAmount, "+", this.Id);

                Endscreen end = new(this.Id, this.TransactionAmount, "+");
                end.Show();
                this.Close();

            }
        }

    }
}
