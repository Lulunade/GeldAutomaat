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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GebruikersApplicatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        Sql Sql = new();

        public MainWindow()
        {
            InitializeComponent();
            txbLogin.Focus();
        }

        private void BtnNumber_Click(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            string n = btnThis.Content.ToString();
            txbLogin.Text += n;
        }


        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            if (txbLogin.Text.Length >= 1)
            {
                txbLogin.Text = txbLogin.Text.Substring(0,txbLogin.Text.Length - 1);
            }
        }

        private void BtnEvaluate_Click(object sender, RoutedEventArgs e)
        {
            string userBankNumber = txbLogin.Text;
            txbLogin.Clear();
            string SQL = $"SELECT * FROM betaalautomaat.account WHERE bank_number = \"{userBankNumber}\"";
            DataTable datatable = Sql.getDataTable(SQL);

            if (datatable.Rows.Count > 0)
            {
                int id = (int)datatable.Rows[0]["ID"];
                PinWindow pinWindow = new PinWindow(id);
                pinWindow.Show();
                Close();
            } else
            {
                MessageBox.Show("Bankrekening bestaat niet!");
            }
        }
    }
}
