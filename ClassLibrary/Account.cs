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

        public string BankNumber { get; set; }
        public double Balance { get; set; }
        private int ClientId { get; set; }
        public int Id { get; set; }

        public string Pin { get; set; }
        public bool Blocked { get; set; }

        public void LinkClient(int ClientId)
        {
            this.ClientId = ClientId;
        }

        public void Create(string BankNumber, double Balance)
        {
            string SQL = string.Format("INSERT INTO betaalautomaat.account (bank_number, balance) VALUES ('{0}','{1}')",
                BankNumber, Balance);

            Sql.ExecuteNonQuery(SQL);
        }

        public void Update(int Id, string BankNumber = "", double Balance = 0, int ClientId = 0)
        {
            Read(Id);

            if (string.IsNullOrEmpty(BankNumber))
            {
                BankNumber = this.BankNumber;
            }
            if (Balance == 0)
            {
                Balance = this.Balance;
            } 
            if (ClientId == 0)
            {
                ClientId = this.ClientId;
            }

            string SQL = string.Format("Update question_answer " +
                                       "Set bank_number            = '{0}', " +
                                           "balance                = '{1}', " +
                                           "client_id              = '{2}'" +
                                            "WHERE ID =  {3}", BankNumber, Balance, ClientId, Id);

            this.BankNumber = BankNumber;
            this.Balance = Balance;
            this.ClientId = ClientId;

            Sql.ExecuteNonQuery(SQL);
        }
        
        public void Read(int Id)
        {
            string SQL = string.Format("SELECT * FROM betaalautomaat.account WHERE id = {0}", Id);

            DataTable datatable = Sql.getDataTable(SQL);
            this.Id = (int)datatable.Rows[0]["ID"];
            BankNumber = datatable.Rows[0]["bank_number"].ToString();
            Balance = (double)datatable.Rows[0]["balance"];
            ClientId = (int)datatable.Rows[0]["client_ID"];
            Blocked = (bool)datatable.Rows[0]["blocked"];
            Pin = datatable.Rows[0]["pin"].ToString();
        }
    }
}
