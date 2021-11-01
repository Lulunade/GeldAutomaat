using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Transaction
    {
        Sql Sql = new();

        public int Id { get; set; }
        public double Amount { get; set; }
        public string Deposit { get; set; }
        public int AccountId { get; set; }

        public void Create(double amount, string deposit, int accountId)
        {
            this.Amount = amount;
            this.Deposit = deposit;
            this.AccountId = accountId;

            string sql = string.Format("INSERT INTO `transaction` (amount, deposit, account_ID) VALUES ('{0}', '{1}', '{2}')", amount, deposit, accountId);
            Sql.ExecuteNonQuery(sql);
        }
    }
}
