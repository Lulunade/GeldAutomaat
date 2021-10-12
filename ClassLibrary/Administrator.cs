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

        public void Read(int Id)
        {
            string SQL = string.Format("SELECT * FROM betaalautomaat.administrator WHERE ID = {0}", Id);

            DataTable datatable = Sql.getDataTable(SQL);
            this.Id = (int)datatable.Rows[0]["ID"];
            Username = datatable.Rows[0]["username"].ToString();
            Password = datatable.Rows[0]["password"].ToString();
        }
    }
}
