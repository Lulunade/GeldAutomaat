using ClassLibrary;
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

namespace GebruikersApplicatie.Views
{
    /// <summary>
    /// Interaction logic for CustomWithdrawWindow.xaml
    /// </summary>
    public partial class CustomWithdrawWindow : Window
    {
        Sql Sql = new();
        Transaction transaction = new();
        Account account = new();

        public int Id { get; set; }
        public double TransactionAmount { get; set; }

        public CustomWithdrawWindow(int id, double transactionAmount)
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

        private void BtnNumber_Click(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            string n = btnThis.Content.ToString();
            txbAmount.Text += n;
        }


        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            if (txbAmount.Text.Length >= 1)
            {
                txbAmount.Text = txbAmount.Text.Substring(0, txbAmount.Text.Length - 1);
            }
        }

        private void BtnEvaluate_Click(object sender, RoutedEventArgs e)
        {
            if (txbAmount.Text == "")
            {
                transaction.Create(this.TransactionAmount, "-", this.Id);
                Endscreen end = new(this.Id, this.TransactionAmount, "-");
                end.Show();
                this.Close();
            }
            else
            {
                string SQL = "SELECT COUNT(ID) FROM `transaction` WHERE(`date` > { fn CURRENT_DATE() }) AND " + string.Format("`account_ID` = {0} AND `deposit` = '-' ORDER BY `date` DESC", this.Id); 
                DataTable dtb = Sql.getDataTable(SQL);
                string countString = dtb.Rows[0]["COUNT(ID)"].ToString();
                int count = Convert.ToInt32(countString);

                if (count >= 3)
                {
                    MessageBox.Show("Je mag niet meer dan drie keer per dag geld pinnen");
                } else
                {
                    double amount = Convert.ToDouble(txbAmount.Text);
                    txbAmount.Clear();
                    if (this.TransactionAmount + amount > 500)
                    {
                        MessageBox.Show("Je kunt niet meer dan €500 per keer pinnen");
                    } 
                    else if (account.Balance - amount < 0)
                    {
                        MessageBox.Show("Je hebt niet genoeg geld op je rekening");
                    }
                        else
                    {
                        account.Update(this.Id, account.BankNumber, (account.Balance - amount));
                        this.TransactionAmount += amount;
                        transaction.Create(this.TransactionAmount, "-", this.Id);
                        Endscreen end = new(this.Id, this.TransactionAmount, "-");
                        end.Show();
                        this.Close();
                    }
                }
            }
        }

    }
}
