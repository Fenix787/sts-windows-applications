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
            string confirm;
            double quoteTotal = getQuoteTotal(poid);
            string[] converted = eps.processsCommission(poid, customer, quoteTotal);

            // if external processing system returns valid confirmation number
            if(converted[1] != "-1")
            {
                // extract confirmation number
                confirm = converted[1];

                // compute comission
                double commission = quoteTotal * (Convert.ToDouble(converted[2]) / 100);

                // now update quote with comission and confirmation number
                qdb.convertQuote(poid, Convert.ToInt32(confirm), commission);
            }
            else
            {
                confirm = "-1";
                qdb.convertQuote(poid, 0, 0);
            }

            // return confirmation number for display
            return confirm;
        }

        public DataTable getQuoteList()
        {
            if (qdb == null) { qdb = new sts_processing.QuoteDB(); }

            // get only quotes that have been processed
            DataTable quotes = qdb.getQuoteList(2);

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

        public double getDiscount(int quote)
        {
            if (qdb == null) { qdb = new sts_processing.QuoteDB(); }
            return qdb.getDiscount(quote);
        }

        public void updateDiscount(int quote, double discount)
        {
            if (qdb == null) { qdb = new sts_processing.QuoteDB(); }
            qdb.updateDiscount(quote, discount);
        }
    }
}