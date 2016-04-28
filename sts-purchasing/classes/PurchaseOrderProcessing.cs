using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sts_purchasing
{
    public class PurchaseOrderProcessing
    {
        ExternalProcessingSystem eps;
        sts_processing.QuoteDB qdb;

        public string[] processsComission(int poid, string customer, double total)
        {
            if (eps == null) { eps = new ExternalProcessingSystem(); }
            return eps.processsComission(poid, customer, total);
        }

        public DataTable getQuoteList()
        {
            if (qdb == null) { qdb = new sts_processing.QuoteDB(); }
            DataTable quotes = qdb.getQuoteList();
            // add id to cust field
            foreach(DataRow row in quotes.Rows)
            {
                row["cust"] = row["id"] + " | " + row["cust"];
            }
            return quotes;
        }
    }
}