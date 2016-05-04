using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace sts_processing
{
    public class ProcessQuote
    {
        public QuoteDB qdb;

        public DataTable getCustomerList()
        {
            if (qdb == null) { qdb = new QuoteDB(); }
            return qdb.getCustomerList(1);
        }

        public double getQuoteTotal(int quote)
        {
            if (qdb == null) { qdb = new QuoteDB(); }
            return qdb.getQuoteTotal(quote);
        }

        public DataTable getQuoteList()
        {
            if (qdb == null) { qdb = new QuoteDB(); }

            // get only quotes that have been closed
            DataTable quotes = qdb.getQuoteList(1);

            // add id to cust field
            foreach (DataRow row in quotes.Rows)
            {
                row["cust"] = row["id"] + " | " + row["cust"];
            }
            return quotes;
        }

        public DataSet getItems(int quote)
        {
            if (qdb == null) { qdb = new QuoteDB(); }
            return qdb.getItems(quote);
        }

        public DataSet getNotes(int quote)
        {
            if (qdb == null) { qdb = new QuoteDB(); }
            return qdb.getNotes(quote);
        }

        public void updateItems(DataTable changes)
        {
            if (qdb == null) { qdb = new QuoteDB(); }
            qdb.updateItems(changes);
        }

        public void updateNotes(DataTable changes)
        {
            if (qdb == null) { qdb = new QuoteDB(); }
            qdb.updateNotes(changes);
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

        public void finalizeQuote(int quote)
        {
            if (qdb == null) { qdb = new sts_processing.QuoteDB(); }
            qdb.finalizeQuote(quote);
        }

        public string getQuoteEmail(int quote)
        {
            if (qdb == null) { qdb = new sts_processing.QuoteDB(); }
            return qdb.getQuoteEmail(quote);
        }

        public void updateQuoteEmail(int quote, string email)
        {
            if (qdb == null) { qdb = new sts_processing.QuoteDB(); }
            qdb.updateQuoteEmail(quote,email);
        }

        public void sendEmail(string quoteEmail, int quote)
        {
            MailMessage message;
            SmtpClient smtp;
            message = new MailMessage();
            message.From = new MailAddress("ug4csci467@gmail.com");
            message.To.Add(quoteEmail);
            message.Subject = "Quote Processed";
            message.Body = "Your quote " + quote + " has been processed and is ready to be converted to a purcahse order. Please contat cusotmer service.";

            smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential("ug4csci467@gmail.com", "huskies467");

            smtp.SendAsync(message, message.Subject);

        }
    }
}
