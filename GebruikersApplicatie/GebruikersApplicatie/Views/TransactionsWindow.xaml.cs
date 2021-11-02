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
    /// Interaction logic for TransactionsWindow.xaml
    /// </summary>
    public partial class TransactionsWindow : Window
    {
        public int Id;

        Account account = new();
        Sql Sql = new();

        public TransactionsWindow(int Id)
        {
            InitializeComponent();
            this.Id = Id;

            account.Read(Id);
            lblBalance.Text = $"€ {account.Balance}";
            string sql = string.Format("SELECT * from `transaction` WHERE `account_ID` = {0} LIMIT 3", this.Id);
            dgClient.DataContext = Sql.getDataSet(sql);

            btnBack.Click += BtnBack_Click;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard(this.Id);
            dashboard.Show();
            this.Close();
        }
    }
}
