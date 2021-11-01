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

namespace Admin.Views
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public int Id { get; set; }

        Client client = new();
        Account account = new();
        Sql sql = new();

        public EditWindow()
        {
            InitializeComponent();
            btnCancel.Click += BtnCancel_Click;
            btnErase.Click += BtnErase_Click;
            btnSubmit.Click += BtnSubmit_Click1;
        }

        private void BtnSubmit_Click1(object sender, RoutedEventArgs e)
        {
            string email = txbEmail.Text;
            string surname = txbSurname.Text;
            string lastName = txbLastName.Text;
            string phone = txbPhone.Text;

            client.Create(surname, lastName, email, phone);
            string SQL = String.Format("SELECT ID FROM `client` WHERE `surname` = '{0}' AND `last_name` = '{1}' AND `e-mail` = '{2}' AND `telephone` AND '{3}'", surname, lastName, email, phone);
            DataTable dtb = sql.getDataTable(SQL);
            this.Id = (int)dtb.Rows[0]["ID"];

            Random rnd = new Random();
            string rand = rnd.Next(99).ToString();

            string sqlR = String.Format("SELECT ID FROM `account` WHERE `bank_number` = '{0}'", rand);
            if (sql.getDataTable(sqlR) != null)
            {
                rand = rnd.Next(99).ToString();
            }

            account.Create(rand, 0);
            string SQL2 = String.Format("SELECT ID FROM `account` WHERE `bank_number` = '{0}'", rand);
            DataTable dtb2 = sql.getDataTable(SQL2);
            int id = (int)dtb2.Rows[0]["ID"];
            account.LinkClient(id, this.Id);

            SearchWindow win = new();
            win.Show();
            this.Close();
        }

        private void BtnErase_Click(object sender, RoutedEventArgs e)
        {
            txbEmail.Text = "";
            txbLastName.Text = "";
            txbPhone.Text = "";
            txbSurname.Text = "";
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow win = new();
            win.Show();
            this.Close();
        }

        public EditWindow(int Id)
        {
            InitializeComponent();
            this.Id = Id;
            client.Read(Id);
            txbEmail.Text = client.Email;
            txbSurname.Text = client.Surname;
            txbLastName.Text = client.LastName;
            txbPhone.Text = client.Telephone;
            btnCancel.Click += BtnCancel_Click;
            btnErase.Click += BtnErase_Click;
            btnSubmit.Click += BtnSubmit_Click;
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string email = txbEmail.Text;
            string surname = txbSurname.Text;
            string lastName = txbLastName.Text;
            string phone = txbPhone.Text;

            client.Update(this.Id, surname, lastName, email, phone);
            SearchWindow win = new();
            win.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBlock_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
