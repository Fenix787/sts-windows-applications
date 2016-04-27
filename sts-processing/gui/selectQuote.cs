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

        public selectQuote()
        {
            InitializeComponent();
            populateCustomers();
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
    }
}
