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
using ClassLibrary;

namespace Admin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sql Sql = new();
        Administrator Administrator = new();

        public MainWindow()
        {
            InitializeComponent();
            txbMail.Focus();
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string user = txbMail.Text;
            string password = txbPassword.Text;
            txbMail.Clear();
            string SQL = $"SELECT * FROM betaalautomaat.administrator WHERE username = \"{user}\"";
            DataTable datatable = Sql.getDataTable(SQL);

            if (datatable.Rows.Count > 0)
            {
                int id = (int)datatable.Rows[0]["ID"];
                Administrator.Read(id);
                MessageBox.Show($"Gebruiker gevonden: {id}");
                if (password == Administrator.Password)
                {
                    MessageBox.Show("wachtwoord klopt");
                    SearchWindow searchWindow = new();
                    searchWindow.Show();
                    Close();

                }
                else
                {
                    MessageBox.Show("Pincode is ONJUIST!");
                }
            }
            else
            {
                MessageBox.Show("Gebruiker bestaat niet!");
                txbMail.Focus();
            }
        }
    }
}
