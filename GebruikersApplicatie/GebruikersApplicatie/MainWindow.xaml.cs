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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GebruikersApplicatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sql SQL = new();
        public MainWindow()
        {
            InitializeComponent();
            Client user1 = new();
            user1.Create("Layla", "Haarbosch", "noreply@github.com", "0123456789");
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Button btnThis = sender as Button;
            string n = btnThis.Content.ToString();
            txbLogin.Text += n;
        }

        private void BtnEvaluate_Click(object sender, RoutedEventArgs e)
        {
            /* */
        }
    }
}
