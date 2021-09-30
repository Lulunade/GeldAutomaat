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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public int Id;
        Account account = new();
        public Dashboard(int Id)
        {
            InitializeComponent();
            this.Id = Id;

            account.Read(1);
            MessageBox.Show($"Uw saldo is: € {account.Balance}");
        }
    }
}
