using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sts_purchasing
{
    public partial class selectQuote : Form
    {
        public PurchaseOrderProcessing pop = new PurchaseOrderProcessing();

        public selectQuote()
        {
            InitializeComponent();
            populateQuoteList();
        }

        private void populateQuoteList()
        {
            quoteList.DataSource = pop.getQuoteList();
            quoteList.DisplayMember = "cust";
            quoteList.ValueMember = "id";
            quoteList.Update();
        }

        private void discountButton_Click(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string confirm = pop.convertQuote((int)quoteList.SelectedValue, quoteList.SelectedItem.ToString());
            if (confirm == "-1")
            {
                MessageBox.Show("Purcahse Order Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Confirmation number : " + confirm, "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                populateQuoteList();
            }
        }
    }
}
