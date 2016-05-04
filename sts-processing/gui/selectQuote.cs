using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sts_processing
{
    public partial class selectQuote : Form
    {
        // create controller
        public ProcessQuote pqc = new ProcessQuote();

        // create viewQuote form
        public viewQuote quoteForm;

        public selectQuote()
        {
            InitializeComponent();
            populateQuotes();

            // create viewQuote form
            quoteForm = new viewQuote(pqc, this);
    }

        public void populateQuotes()
        {
            quoteList.DataSource = pqc.getQuoteList();
            quoteList.DisplayMember = "cust";
            quoteList.ValueMember = "id";
            quoteList.Update();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            DataRowView drv = quoteList.SelectedItem as DataRowView;
            if (quoteForm.IsDisposed) { quoteForm = new viewQuote(pqc, this); }
            Console.WriteLine("quote : " + drv.Row["id"]);
            quoteForm.populateQuote((int) drv.Row["id"], drv.Row["cust"].ToString());
            quoteForm.Update();
            quoteForm.Show();
        }

    }
}
