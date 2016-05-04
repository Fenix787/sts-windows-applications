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
            DataRowView drv = quoteList.SelectedItem as DataRowView;
            pop.updateDiscount((int)drv.Row["id"],Convert.ToDouble(discountTextBox.Text));
            MessageBox.Show("Discount updated","Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string confirm = pop.convertQuote((int)quoteList.SelectedValue, quoteList.SelectedItem.ToString());
            if (confirm == "-1")
            {
                MessageBox.Show("Purcahse Order already exists, no comission or confirmation number will be saved, please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                populateQuoteList();
            }
            else
            {
                MessageBox.Show("Confirmation number : " + confirm, "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                populateQuoteList();
            }
        }

        private void quoteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = quoteList.SelectedItem as DataRowView;
            discountTextBox.Text = pop.getDiscount((int)drv.Row["id"]).ToString();
        }

        // only numeric inpuit
        private void discountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
