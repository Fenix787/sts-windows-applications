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
            quote = inquote;
            Text = title;
            discountTextBox.Text = pqc.getDiscount(quote).ToString();

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

            noteGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            noteGridView.Update();
        }

        private void itemGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)itemGridView.DataSource).GetChanges();

            if (changes != null)
            {
                // commit changes to database
                pqc.updateItems(changes);
                ((DataTable)itemGridView.DataSource).AcceptChanges();

                // update quote total incase items qty or price has been modified
                populateTotal();
            }
        }

        private void itemGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["quote"].Value = quote;
        }

        private void noteGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
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
            e.Row.Cells["quote"].Value = quote;
        }

        private void discountButton_Click(object sender, EventArgs e)
        {
            pqc.updateDiscount(quote, Convert.ToDouble(discountTextBox.Text));
            populateTotal();
            MessageBox.Show("Discount updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            pqc.finalizeQuote(quote);
            slq.populateCustomers();
            slq.Update();
            Hide();
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

        private void itemGridView_CellValidating(object sender,
        DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewColumn col = itemGridView.Columns[e.ColumnIndex] as DataGridViewColumn;

            if (col.Name== "Price" || col.Name == "Quantity")
            {
                DataGridViewTextBoxCell cell = itemGridView[e.ColumnIndex, e.RowIndex] as DataGridViewTextBoxCell;
                if (cell != null)
                {
                    char[] chars = e.FormattedValue.ToString().ToCharArray();
                    bool decimalFlag = false;
                    foreach (char c in chars)
                    {
                        if ((char.IsDigit(c) == false && (c != '.' || col.Name == "Quantity")) || (c == '.' && (decimalFlag == true || chars.Count() == 1)))
                        {
                            cell.Value = "0";
                            itemGridView.RefreshEdit();
                            e.Cancel = true;
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
