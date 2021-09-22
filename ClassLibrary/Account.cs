using GebruikersApplicatie;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Account
    {
        Sql Sql = new();
        /*Client Client = new();*/

        private int _id = 0;
        private string _banknumber;
        private double _balance;
        private int _client_id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Banknumber
        {
            get { return _banknumber; }
            set { _banknumber = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public int ClientId
        {
            get { return _client_id; }
            set { _client_id = value; }
        }
        
        public Account()
        {
            
        }

        public void LinkClient(int ClientId)
        {
            _client_id = ClientId;
        }

        public void Create(string BankNumber, double Balance)
        {
            string SQL = string.Format("INSERT INTO betaalautomaat.account (bank_number, balance) VALUES ('{0}','{1}')",
                BankNumber, Balance);

            Sql.ExecuteNonQuery(SQL);
        }

        public void Update(int Id, string BankNumber = "", double Balance = 0, int ClientId = 0)
        {
            if (BankNumber == "")
            {
                BankNumber = _banknumber;
            }
            if (Balance == 0)
            {
                Balance = _balance;
            } 
            if (ClientId == 0)
            {
                ClientId = _client_id;
            }

            string SQL = string.Format("UPDATE betaalautomaat.account (bank_number, balance, client_ID) VALUES ('{0}','{1}','{2}') WHERE ID = {3}",
                BankNumber, Balance, ClientId, Id);

            Sql.ExecuteNonQuery(SQL);
        }
        
        public void Read(int Id)
        {
            string SQL = string.Format("SELECT * FROM betaalautomaat.account WHERE id = {0}", Id);

            DataTable datatabel = Sql.getDataTable(SQL);
            _id = (int) datatabel.Rows[0]["ID"];
            _banknumber = datatabel.Rows[0]["bank_number"].toString();
            _balance = datatabel.Rows[0]["balance"].toString();
            _client_id = (int) datatabel.Rows[0]["client_ID"].toString();
        }
    }
}
