using Admin.Views;
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

namespace Admin
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        Account account = new();
        Sql Sql = new();
        
        public SearchWindow()
        {
            InitializeComponent();
            dgClient.DataContext = account.getData();
            btnAdd.Click += BtnAdd_Click;
            btnSearch.Click += BtnSearch_Click;
            btnSearch2.Click += BtnSearch2_Click;
            btnClear.Click += BtnClear_Click;
            btnClear2.Click += BtnClear2_Click;
        }

        private void BtnClear2_Click(object sender, RoutedEventArgs e)
        {
            txbLastName.Text = "";
            dgClient.DataContext = account.getData();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txbBankNr.Text = "";
            dgClient.DataContext = account.getData();
        }

        private void BtnSearch2_Click(object sender, RoutedEventArgs e)
        {
            string sql = string.Format("SELECT * FROM account INNER JOIN client ON account.client_ID = client.ID AND `last_name` LIKE '{0}'", txbLastName.Text);
            dgClient.DataContext = Sql.getDataSet(sql);
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            string sql = string.Format("SELECT * FROM account INNER JOIN client ON account.client_ID = client.ID AND `bank_number` LIKE '{0}'", txbBankNr.Text);
            dgClient.DataContext = Sql.getDataSet(sql);
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            EditWindow window = new();
            window.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            object item = dgClient.SelectedItem;
            int userId = int.Parse((dgClient.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
            
            EditWindow window = new EditWindow(userId);
            window.Show();
            this.Close();
        }

        private void btnBlock_Click(object sender, RoutedEventArgs e)
        {
            Account account = new();
            object item = dgClient.SelectedItem;
            int accId = int.Parse((dgClient.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text);


            account.Read(accId);

            if (!account.Blocked)
            {
                account.Block(accId, true);
            } else
            {
                account.Block(accId, false);
            }

            dgClient.DataContext = account.getData();
        }
    }
}
