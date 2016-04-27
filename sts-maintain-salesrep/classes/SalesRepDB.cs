using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace sts_maintain_salesrep
{
    public class SalesRepDB : MySQLSuper
    {
        // constructor
        public SalesRepDB()
        {
            Initialize();
        }

        // initialize values
        private void Initialize()
        {
            host = "kclarke.co";
            user = "csci467";
            pass = "huskies";
            db_name = "Sales";
            table_name = "SalesRep";

            superInitialize();
        }

        public DataTable getSalesRepList()
        {
            execute("SELECT id,username FROM SalesRep");
            return getData();
        }

        public SalesRep getSalesRep(int id)
        {
            execute("SELECT * FROM SalesRep WHERE id='" + id + "'");
            MySqlDataReader reader = getRow();
            SalesRep salesrep = new SalesRep(reader);
            reader.Close();
            return salesrep;
        }

        public void updateSalesRep(SalesRep updateRep, String newPassword)
        {
            // hash password
            if (newPassword != "")
            {
                var password = Encoding.UTF8.GetBytes(newPassword + updateRep.salt);
                SHA256Managed hashPass = new SHA256Managed();
                string hex = "";

                var hashValue = hashPass.ComputeHash(password);
                foreach (byte x in hashValue)
                {
                    hex += String.Format("{0:x2}", x);
                }
                updateRep.password = hex;
            }
            executeUpdate("UPDATE SalesRep SET username='" + updateRep.username + "', first='" + updateRep.firstName + "', last='" + updateRep.lastName + "', password='" + updateRep.password + "' WHERE id='" + updateRep.id + "'");
        }
    }

    public class SalesRep
    {
        public int id;
        public string username;
        public string firstName;
        public string lastName;
        public string salt;
        public string password;

    // populate salesrep
        public SalesRep (MySqlDataReader reader)
        {
            id = (int)reader["id"];
            username = (string)reader["username"];
            salt = (string)reader["salt"];
            password = (string)reader["password"];
            firstName = (string)reader["first"];
            lastName = (string)reader["last"];
        }

    // empty salesrep
        public SalesRep ()
        {
            id = -1;
            username = "";
            firstName = "";
            lastName = "";
            salt = "";
            password = "";
        }
    }
}
