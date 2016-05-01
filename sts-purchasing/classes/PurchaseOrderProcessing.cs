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

        public string convertQuote(int poid, string customer)
        {
            if (eps == null) { eps = new ExternalProcessingSystem(); }
            double quoteTotal = getQuoteTotal(poid);
            string[] converted = eps.processsComission(poid, customer, quoteTotal);

            // extract confirmation number
            string confirm = converted[1];

            // compute comission
            double comission = quoteTotal * (Convert.ToDouble(converted[2]) / 100);

            // now update quote with comission and confirmation number
            qdb.convertQuote(poid,confirm,comission);

            // return confirmation number for display
            return confirm;
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

        public double getQuoteTotal(int quote)
        {
            if (qdb == null) { qdb = new sts_processing.QuoteDB(); }
            return qdb.getQuoteTotal(quote);
        }
    }
}