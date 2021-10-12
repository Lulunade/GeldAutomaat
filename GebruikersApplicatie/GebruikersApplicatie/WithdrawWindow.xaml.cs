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
    /// Interaction logic for WithdrawWindow.xaml
    /// </summary>
    public partial class WithdrawWindow : Window
    {
        public int Id;

        Account account = new();

        public WithdrawWindow(int Id)
        {
            InitializeComponent();
            this.Id = Id;

            MessageBox.Show("snap je hem");
            account.Read(Id);
            lblBalance.Text = $"€ {account.Balance}";
        }

        private void BtnWithdraw(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            account.Update(Id, "", account.Balance + 100);
            lblBalance.Text = $"€ {account.Balance}";
        }
    }
}
