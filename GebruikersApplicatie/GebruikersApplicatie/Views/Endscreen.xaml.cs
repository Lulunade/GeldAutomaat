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

namespace GebruikersApplicatie.Views
{
    /// <summary>
    /// Interaction logic for Endscreen.xaml
    /// </summary>
    public partial class Endscreen : Window
    {
        Account account = new();

        public int Id { get; set; }
        public double TransactionAmount { get; set; }
        public string Mode { get; set; }

        public Endscreen(int id, double transactionAmount, string mode)
        {
            string addition = "";
            InitializeComponent();
            this.Id = id;
            this.TransactionAmount = transactionAmount;
            this.Mode = mode;

            btnBack.Click += BtnBack_Click;

            account.Read(this.Id);
            switch (this.Mode)
            {
                case "+":
                    addition = "gestort";
                    break;
                case "-":
                    addition = "gepint";
                    break;
            }
            bool deposited = false;
            lblWarning.Content = $"Uw heeft € {this.TransactionAmount} {addition}, Tot Ziens!";

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new(this.Id);
            dashboard.Show();
            this.Close();
        }
    }
}
