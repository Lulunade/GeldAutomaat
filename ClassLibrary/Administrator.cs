using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Administrator
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        Sql Sql = new();

        public void Create(string Username, string Password)
        {
            Password = SecurePasswordHasher.Hash(Password);

            string sql = string.Format("INSERT INTO betaalautomaat.administrator (username, password) VALUES ('{0}','{1}')",
                Username, Password);

            Sql.ExecuteNonQuery(sql);
        }

        public void Read(int Id)
        {
            string SQL = string.Format("SELECT * FROM betaalautomaat.administrator WHERE ID = {0}", Id);

            DataTable datatable = Sql.getDataTable(SQL);
            this.Id = (int)datatable.Rows[0]["ID"];
            this.Username = datatable.Rows[0]["username"].ToString();
            this.Password = datatable.Rows[0]["password"].ToString();
        }
    }
}
