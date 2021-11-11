using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Account
    {
        Sql Sql = new();

        public string BankNumber { get; set; }
        public double Balance { get; set; }
        private int ClientId { get; set; }
        public int Id { get; set; }
        public string Pin { get; set; }
        public bool Blocked { get; set; }

        public void LinkClient(int Id, int ClientId)
        {
            this.ClientId = ClientId;
            string sql = string.Format("UPDATE account SET client_id = '{0}' WHERE ID = {1}", ClientId, Id);

            Sql.ExecuteNonQuery(sql);
        }

        public void Create(string BankNumber, double Balance = 0)
        {
            Random random = new();
            this.Pin = SecurePasswordHasher.Hash($"{random.Next(0,9)}{random.Next(0,9)}{random.Next(0, 9)}{random.Next(0, 9)}");
            Debug.WriteLine(this.Pin);
            string sql = string.Format("INSERT INTO betaalautomaat.account (bank_number, balance, pin) VALUES ('{0}','{1}','{2}')",
                BankNumber, Balance, this.Pin);

            Sql.ExecuteNonQuery(sql);
        }

        public void Update(int Id, string BankNumber = "", double Balance = 0, int ClientId = 0)
        {
            if (string.IsNullOrEmpty(BankNumber))
            {
                BankNumber = this.BankNumber;
            }
            if (ClientId == 0)
            {
                ClientId = this.ClientId;
            }

            string sql = string.Format("Update account " +
                                       "Set bank_number            = '{0}', " +
                                           "balance                = '{1}', " +
                                           "client_id              = '{2}' " +
                                            "WHERE ID =  {3}", BankNumber, Balance, ClientId, Id);

            this.BankNumber = BankNumber;
            this.Balance = Balance;
            this.ClientId = ClientId;

            Sql.ExecuteNonQuery(sql);
        }

        public void UpdateBalance(int Id, double Balance = 0)
        {
            string sql = string.Format("UPDATE account SET balance = '{0}' WHERE ID = {1}", Balance, Id);
            Sql.ExecuteNonQuery(sql);
        }

        public void Block(int id, bool status)
        {

            string sql = string.Format("UPDATE account SET blocked = {0} WHERE ID = {1}", status, id);

            this.Blocked = status;

            Sql.ExecuteNonQuery(sql);
        }
        
        public void Read(int Id)
        {
            string SQL = string.Format("SELECT * FROM betaalautomaat.account WHERE ID = {0}", Id);

            DataTable datatable = Sql.getDataTable(SQL);
            this.Id = (int)datatable.Rows[0]["ID"];
            BankNumber = datatable.Rows[0]["bank_number"].ToString();
            Balance = (double)datatable.Rows[0]["balance"];
            ClientId = (int)datatable.Rows[0]["client_ID"];
            Blocked = (bool)datatable.Rows[0]["blocked"];
            Pin = datatable.Rows[0]["pin"].ToString();
        }

        public DataSet getData()
        {
            string sql = "SELECT * FROM account INNER JOIN client ON account.client_ID = client.ID";

            return Sql.getDataSet(sql);
        }
    }
}
