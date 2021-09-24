using GebruikersApplicatie;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Client
    {
        Sql Sql = new();

        public int Id { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public void Create(string Surname, string LastName, string Email, string Telephone)
        {
            this.Surname = Surname;
            this.LastName = LastName;
            this.Email = Email;
            this.Telephone = Telephone;

            string SQL = string.Format("INSERT INTO betaalautomaat.client (surname, last_name, e-mail, telephone) VALUES ('{0}','{1}','{2}','{3}')",
                Surname, LastName, Email, Telephone);

            string SQL2 = string.Format("SELECT * FROM betaalautomaat.account ORDER BY ID DESC LIMIT 1");

            DataTable datatable = Sql.getDataTable(SQL);

            /*_id = (int)datatable.Rows[0]["ID"];*/

            Sql.ExecuteNonQuery(SQL);
        }

        public void Update(int Id, string Surname = "", string LastName = "", string Email = "", string Telephone = "")
        {
            if (string.IsNullOrEmpty(Surname))
            {
                Surname = this.Surname;
            }
            if (string.IsNullOrEmpty(LastName))
            {
                LastName = this.LastName;
            }
            if (string.IsNullOrEmpty(Email))
            {
                Email = this.Email;
            }
            if (string.IsNullOrEmpty(Telephone))
            {
                Telephone = this.Telephone;
            }

            string SQL = string.Format("Update question_answer " +
                                       "Set surname               = '{0}', " +
                                           "last_name             = '{1}', " +
                                           "e-mail                = '{2}', " +
                                           "telephone             = '{3}'" +
                                       "WHERE ID =  {2}", Surname, LastName, Email, Telephone, Id);

            Sql.ExecuteNonQuery(SQL);
        }

        public void Read(int Id)
        {
            string SQL = string.Format("SELECT * FROM betaalautomaat.client WHERE id = {0}", Id);

            DataTable datatable = Sql.getDataTable(SQL);
            this.Id = (int)datatable.Rows[0]["ID"];
            this.Surname = datatable.Rows[0]["surname"].ToString();
            this.LastName = datatable.Rows[0]["last_name"].ToString();
            this.Email = datatable.Rows[0]["e-mail"].ToString();
            this.Telephone = datatable.Rows[0]["telephone"].ToString();

        }
    }
}
