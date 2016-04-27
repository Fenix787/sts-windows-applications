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
            host = "kclarke.co";
            user = "csci467";
            pass = "huskies";
            db_name = "Sales";
            table_name = "Quote";

            superInitialize();
        }

        public DataTable getCustomerList()
        {
            execute("SELECT cust FROM Quote GROUP BY cust");
            return getData();
        }

        public DataTable getQuoteList(string cust)
        {
            Console.WriteLine(cust);
            execute("SELECT id FROM Quote WHERE cust='" + cust + "'");
            return getData();
        }

    }
}
