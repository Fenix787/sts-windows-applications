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
    public partial class viewQuote : Form
    {
        // create instance variables
        ProcessQuote pqc;
        selectQuote slq;
        int quote;

        public viewQuote(ProcessQuote inpqc, selectQuote inslq)
        {
            InitializeComponent();
            pqc = inpqc;
            slq = inslq;

            // setup note grid view
            noteGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            noteGridView.RowTemplate.Height = 50;

        }

        public void populateQuote(int inquote,string title)
        {
            // set form title
            Text = title;

            // populate discount
            discountTextBox.Text = pqc.getDiscount(inquote).ToString();

            // populate rest of quote data
            populateItems();
            populateNotes();
            populateTotal();
        }

        private void populateTotal()
        {
            totalLabel.Text = "$" + pqc.getQuoteTotal(quote).ToString("#,###.##");
        }

        private void populateItems()
        {
            itemGridView.DataSource = pqc.getItems(quote).Tables[0];

            // hide id and quote id
            itemGridView.Columns[0].Visible = false;
            itemGridView.Columns[1].Visible = false;

            itemGridView.Update();
        }

        private void populateNotes()
        {
            noteGridView.DataSource = pqc.getNotes(quote).Tables[0];

            // hide id and quote id
            noteGridView.Columns[0].Visible = false;
            noteGridView.Columns[1].Visible = false;

            // make message field extend to end of datagridview
            noteGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            noteGridView.Update();
        }

        private void itemGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            // get changes from datagridview
            DataTable changes = ((DataTable)itemGridView.DataSource).GetChanges();

            if (changes != null)
            {
                // commit changes to database
                pqc.updateItems(changes);
                ((DataTable)itemGridView.DataSource).AcceptChanges();

                // update quote total
                populateTotal();
            }
        }

        private void itemGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // set the quote id
            e.Row.Cells["quote"].Value = quote;
        }

        private void noteGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            // get changes from datagridview
            DataTable changes = ((DataTable)noteGridView.DataSource).GetChanges();

            if (changes != null)
            {
                // commit changes to database
                pqc.updateNotes(changes);
                ((DataTable)noteGridView.DataSource).AcceptChanges();
            }
        }

        private void noteGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // set the quote id
            e.Row.Cells["quote"].Value = quote;
        }

        private void discountButton_Click(object sender, EventArgs e)
        {
            // store discount
            pqc.updateDiscount(quote, Convert.ToDouble(discountTextBox.Text));

            // update quote total
            populateTotal();

            // display confirmation message
            MessageBox.Show("Discount updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // hide form
            Hide();
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            // change status of quote
            pqc.finalizeQuote(quote);

            // reload quote list on slq
            slq.populateCustomers();
            slq.populateQuotes("");
            slq.Update();

            // hide form
            Hide();
        }

        // only numeric input in discounttextbox
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

        private void itemGridView_CellValidating(object sender,
        DataGridViewCellValidatingEventArgs e)
        {
            // get current column
            DataGridViewColumn col = itemGridView.Columns[e.ColumnIndex] as DataGridViewColumn;

            // only verify input on price and qty
            if (col.Name== "Price" || col.Name == "Quantity")
            {
                DataGridViewTextBoxCell cell = itemGridView[e.ColumnIndex, e.RowIndex] as DataGridViewTextBoxCell;
                if (cell != null)
                {
                    // convert string input to char array
                    char[] chars = e.FormattedValue.ToString().ToCharArray();
                    bool decimalFlag = false;
                    foreach (char c in chars)
                    {
                        // only allow numeric and on e decimal as input
                        if ((char.IsDigit(c) == false && (c != '.' || col.Name == "Quantity")) || (c == '.' && (decimalFlag == true || chars.Count() == 1)))
                        {
                            // zero out cell
                            cell.Value = "0";
                            itemGridView.RefreshEdit();
                            e.Cancel = true;

                            // display error message
                            MessageBox.Show("This field only accepts numeric input","Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        if (c == '.') { decimalFlag = true; }
                    }
                }
            }
        }
    }
}
