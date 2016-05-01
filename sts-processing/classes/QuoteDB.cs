using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace sts_processing
{
    public class QuoteDB : sts_maintain_salesrep.MySQLSuper
    {
        // constructor
        public QuoteDB()
        {
            Initialize();
        }

        // initialize values
        private void Initialize()
        {
            host = "blitz.cs.niu.edu";
            user = "db4user";
            pass = "db4password";
            db_name = "dbfour";
            table_name = "Quote";

            superInitialize();
        }

        public DataTable getCustomerList()
        {
            execute("SELECT cust FROM Quote GROUP BY cust;");
            return getData();
        }

        public DataTable getQuoteList()
        {
            execute("SELECT id,cust FROM Quote ORDER BY id DESC, cust ASC;");
            return getData();
        }

        public DataTable getQuoteList(int status)
        {
            execute("SELECT id,cust FROM Quote WHERE status ='" + status + "' ORDER BY id DESC, cust ASC;");
            return getData();
        }

        public DataTable getQuoteList(string cust)
        {
            Console.WriteLine(cust);
            execute("SELECT id FROM Quote WHERE cust='" + cust + "';");
            return getData();
        }

        public double getQuoteTotal(int quote)
        {
            cmd = new MySqlCommand("SELECT SUM(price*qty) FROM Item WHERE quote='" + quote + "';", db);
            return (double)cmd.ExecuteScalar();
        }

        public void convertQuote(int quote, string confirm, double comission)
        {
            executeUpdate("UPDATE Quote SET status='3',comission='" + comission + "',confirmation='" + confirm + "',converted=NOW() WHERE id='" + quote + "';");
        }

    }
}
