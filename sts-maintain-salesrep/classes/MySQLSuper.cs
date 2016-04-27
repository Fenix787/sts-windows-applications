using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sts_maintain_salesrep
{
    public class MySQLSuper
    {
        protected MySqlConnection db;
        protected MySqlCommand cmd;
        protected MySqlDataAdapter adapter;
        protected string host;
        protected string user;
        protected string pass;
        protected string db_name;
        protected string table_name;
        protected string error;
        protected string query;

        // Constructor
        public MySQLSuper()
        {
            // this constructor should be empty, this is a super-class.
        }

        // super init handles connecting to the database for derrived classes
        protected void superInitialize()
        {
            db = new MySqlConnection("datasource=" + host + ";port=3306;database=" + db_name + ";uid=" + user + ";pwd=" + pass + ";");
            if (connect() == true)
            {
                Console.Write("Connection successfull.");
            }
            else
            {
                Console.Write("error connecting");
            }
        }

        // open connection to database
        protected bool connect()
        {
            try
            {
                db.Open();
                return true;
            }
            catch (MySqlException e)
            {
                // print errors to console
                if (e.Number == 0)
                {
                    Console.Write("Error connecting to server.");
                }
                else if (e.Number == 1045)
                {
                    Console.Write("Incorrect username or pasword.");
                }
                return false;
            }
        }

        // close connection
        protected bool disconnect()
        {
            try
            {
                db.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
                return false;
            }
        }

        // execute the query and store in cmd
        public void execute(string inputQuery)
        {
            query = inputQuery;
            cmd = new MySqlCommand(query, db);
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
        }

        public void executeUpdate(string inputQuery)
        {
            query = inputQuery;
            cmd = new MySqlCommand(query, db);
            cmd.ExecuteNonQuery();
        }

        // return all objects in query as datatable
        public DataTable getData()
        {
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public MySqlDataReader getRow()
        {
            MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
            reader.Read();
            return reader;
        }
    }
}
