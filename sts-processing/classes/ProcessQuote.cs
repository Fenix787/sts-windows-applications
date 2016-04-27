using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sts_processing
{
    public class ProcessQuote
    {
        public QuoteDB qdb = new QuoteDB();

        public DataTable getCustomerList()
        {
            return qdb.getCustomerList();
        }

        public DataTable getQuoteList(string cust)
        {
            return qdb.getQuoteList(cust);
        }
    }
}
