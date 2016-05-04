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

        private string selectedCustomer;

        public selectQuote()
        {
            InitializeComponent();
            populateCustomers();

            // create viewQuote form
            quoteForm = new viewQuote(pqc, this);
    }

        public void populateCustomers()
        {
            customerList.DataSource = pqc.getCustomerList();
            customerList.DisplayMember = "cust";
            customerList.ValueMember = "cust";
            customerList.Update();
        }

        public void populateQuotes(string cust)
        {
            selectedCustomer = cust;
            quoteList.DataSource = pqc.getQuoteList(cust);
            quoteList.DisplayMember = "id";
            quoteList.ValueMember = "id";
            quoteList.Update();
        }

        private void customerList_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView drv = customerList.SelectedItem as DataRowView;
            populateQuotes(drv.Row["cust"] as string);
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            DataRowView drv = quoteList.SelectedItem as DataRowView;
            if (quoteForm.IsDisposed) { quoteForm = new viewQuote(pqc, this); }
            quoteForm.populateQuote((int) drv.Row["id"], (drv.Row["id"].ToString() + " | " + selectedCustomer));
            quoteForm.Update();
            quoteForm.Show();
        }

    }
}
