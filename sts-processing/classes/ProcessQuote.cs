﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sts_processing
{
    public class ProcessQuote
    {
        public QuoteDB qdb;

        public DataTable getCustomerList()
        {
            if (qdb == null) { qdb = new QuoteDB(); }
            return qdb.getCustomerList();
        }

        public DataTable getQuoteList(string cust)
        {
            if (qdb == null) { qdb = new QuoteDB(); }
            return qdb.getQuoteList(cust);
        }

        public DataSet getItems(int quote)
        {
            if (qdb == null) { qdb = new QuoteDB(); }
            return qdb.getItems(quote);
        }

        public void updateItems(DataTable changes)
        {
            if (qdb == null) { qdb = new QuoteDB(); }
            qdb.updateItems(changes);
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
