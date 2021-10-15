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

namespace Admin
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        Sql Sql = new();
        public SearchWindow()
        {
            InitializeComponent();
            dgAccount.DataContext = Sql.getDataSet("SELECT * FROM account");

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            object item = dgAccount.SelectedItem;
            int userId = int.Parse((dgAccount.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
        }

        private void btnBlock_Click(object sender, RoutedEventArgs e)
        {
            object item = dgAccount.SelectedItem;
            int userId = int.Parse((dgAccount.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
        }
    }
}
