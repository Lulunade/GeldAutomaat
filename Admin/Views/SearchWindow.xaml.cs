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
        public SearchWindow()
        {
            Sql Sql = new Sql();

            InitializeComponent();
            dgClient.DataContext = Sql.getDataSet("SELECT * FROM account INNER JOIN client ON account.client_ID = client.ID");
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            object item = dgClient.SelectedItem;
            int userId = int.Parse((dgClient.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
            
            EditWindow window = new EditWindow(userId);
            window.Show();
        }

        private void btnBlock_Click(object sender, RoutedEventArgs e)
        {
            object item = dgClient.SelectedItem;
            int userId = int.Parse((dgClient.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
        }
    }
}
