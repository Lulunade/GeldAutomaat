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
    /// Interaction logic for DepositWindow.xaml
    /// </summary>
    public partial class DepositWindow : Window
    {
        public int Id;

        Account account = new();

        public DepositWindow(int Id)
        {
            InitializeComponent();
            this.Id = Id;

            account.Read(Id);
            lblBalance.Text = $"€ {account.Balance}";
            btnOne.Click += BtnOne_Click;
            btnTwo.Click += BtnTwo_Click;
            btnThree.Click += BtnThree_Click;
            p.Click += P_Click;
            p2.Click += P2_Click;
            p3.Click += P3_Click;
        }


        private void Deposit(int amount)
        {
            account.UpdateBalance(this.Id, (account.Balance + amount));
            account.Balance = account.Balance + amount;
            lblBalance.Text = $"€ {account.Balance}";
        }

        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            Deposit(100);
        }

        private void BtnTwo_Click(object sender, RoutedEventArgs e)
        {
            Deposit(200);
        }

        private void BtnThree_Click(object sender, RoutedEventArgs e)
        {
            Deposit(300);
        }

        private void P3_Click(object sender, RoutedEventArgs e)
        {
            Deposit(400);
        }

        private void P2_Click(object sender, RoutedEventArgs e)
        {
            Deposit(500);
        }

        private void P_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
