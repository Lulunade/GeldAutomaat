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
        
        public SearchWindow()
        {
            InitializeComponent();
            dgClient.DataContext = account.getData();
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
