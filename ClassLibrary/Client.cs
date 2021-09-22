using GebruikersApplicatie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Client
    {
        Sql Sql = new();

        private int _id = 0;
        private string _surname = "";
        private string _last_name = "";
        private string _email = "";
        private string _telephone = "";

        public int Id 
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set {_surname = value; }
        }

        public string LastName
        {
            get { return _last_name; }
            set { _last_name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public Client()
        {

        }

        public void Create(string Surname, string LastName, string Email, string Telephone)
        {
            string SQL = string.Format("INSERT INTO betaalautomaat.client (surname, last_name, e-mail, telephone) VALUES ('{0}','{1}','{2}','{3}')",
                Surname, LastName, Email, Telephone);
            
            Sql.ExecuteNonQuery(SQL);
        }

        public void Update(int Id, string Surname = "", string LastName, string Email, string Telephone)
        {
            string SQL = string.Format("UPDATE betaalautomaat.client (surname, last_name, e-mail, telephone) VALUES ('{0}','{1}','{2}','{3}')",
                Surname, LastName, Email, Telephone, Id);
            
            Sql.ExecuteNonQuery(SQL);
        }

        public void Read(int Id)
        {
            string SQL = string.Format("SELECT * FROM betaalautomaat.client WHERE id = {0}", Id);

            DataTabel datatabel = Sql.getDataTable(SQL);
            _id = (int) datatabel.Rows[0]["ID"].ToString();
            _surname = datatabel.Rows[0]["surname"].toString();
            _last_name = datatabel.Rows[0]["last_name"].toString();
            _email = datatabel.Rows[0]["e-mail"].toString();
            _telephone = datatabel.Rows[0]["telephone"].toString();
        }
    }
}
