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
        MySqlDataAdapter itemsAdapter,notesAdapter;

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

        public DataTable getCustomerList(int status)
        {
            execute("SELECT cust FROM Quote WHERE status ='" + status + "' GROUP BY cust;");
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

        public DataTable getQuoteList(int instatus, string incust)
        {
            cmd = new MySqlCommand("SELECT id FROM Quote WHERE cust=@CUST AND status=@STATUS;", db);

            cmd.Parameters.AddWithValue("@CUST",incust);
            cmd.Parameters.AddWithValue("@STATUS", instatus);

            Console.WriteLine(cmd.CommandText);

            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            return getData();
        }

        public double getQuoteTotal(int quote)
        {
            Console.WriteLine(quote);
            // get item totals
            cmd = new MySqlCommand("SELECT SUM(price*qty) FROM Item WHERE quote='" + quote + "';", db);
            double total = Convert.ToDouble(cmd.ExecuteScalar());
            cmd = new MySqlCommand("SELECT discount FROM Quote WHERE id='" + quote + "';", db);
            total -= Convert.ToDouble(cmd.ExecuteScalar());
            return total;
        }

        public void convertQuote(int quote, int confirm, double comission)
        {
            executeUpdate("UPDATE Quote SET status='3',comission='" + comission + "',confirmation='" + confirm + "',converted=NOW() WHERE id='" + quote + "';");
        }

        public double getDiscount(int quote)
        {
            cmd = new MySqlCommand("SELECT discount FROM Quote WHERE id='" + quote + "';", db);
            return Convert.ToDouble(cmd.ExecuteScalar());
        }

        public void updateDiscount(int quote, double discount)
        {
            executeUpdate("UPDATE Quote SET discount='" + discount + "' WHERE id='" + quote + "';");
        }

        public DataSet getItems(int quote)
        {
            itemsAdapter = new MySqlDataAdapter("SELECT id, quote, title AS Title, qty as Quantity, price as Price from Item where quote='" + quote + "'", db);
            DataSet DS = new DataSet();
            itemsAdapter.Fill(DS);
            return DS;
        }

        public DataSet getNotes(int quote)
        {
            notesAdapter = new MySqlDataAdapter("SELECT id, quote, subject AS Subject, message as Message from Note WHERE quote='" + quote + "'", db);
            DataSet DS = new DataSet();
            notesAdapter.Fill(DS);
            return DS;
        }

        public void updateItems(DataTable changes)
        {
            MySqlCommandBuilder mcb = new MySqlCommandBuilder(itemsAdapter);
            itemsAdapter.UpdateCommand = mcb.GetUpdateCommand();
            itemsAdapter.Update(changes);
        }

        public void updateNotes(DataTable changes)
        {
            MySqlCommandBuilder mcb = new MySqlCommandBuilder(notesAdapter);
            notesAdapter.UpdateCommand = mcb.GetUpdateCommand();
            notesAdapter.Update(changes);
        }

        public void finalizeQuote(int quote)
        {
            executeUpdate("UPDATE Quote SET status='2' WHERE id='" + quote + "';");
        }

    }
}
