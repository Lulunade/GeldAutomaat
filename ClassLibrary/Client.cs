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

            DataTable datatable = Sql.getDataTable(SQL);

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
            string SQL = $"SELECT * FROM betaalautomaat.client WHERE id = {Id}";

            DataTable datatable = Sql.getDataTable(SQL);
            this.Id = (int)datatable.Rows[0]["ID"];
            Surname = datatable.Rows[0]["surname"].ToString();
            LastName = datatable.Rows[0]["last_name"].ToString();
            Email = datatable.Rows[0]["e-mail"].ToString();
            Telephone = datatable.Rows[0]["telephone"].ToString();

        }
    }
}
