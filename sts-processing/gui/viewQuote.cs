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

        public viewQuote(ProcessQuote inpqc, selectQuote inslq, int inquote)
        {
            InitializeComponent();
            pqc = inpqc;
            slq = inslq;
            quote = inquote;

            noteGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            discountTextBox.Text = pqc.getDiscount(quote).ToString();

            populateItems();
            populateNotes();
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
                pqc.updateItems(changes);
                ((DataTable)itemGridView.DataSource).AcceptChanges();
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
            MessageBox.Show("Discount updated");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            slq.Show();
            Close();
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            pqc.finalizeQuote(quote);
            slq.populateCustomers();
            slq.Show();
            Close();
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

            if (col.Name.ToLower() == "price" || col.Name.ToLower() == "quantity")
            {
                DataGridViewTextBoxCell cell = itemGridView[e.ColumnIndex, e.RowIndex] as DataGridViewTextBoxCell;
                if (cell != null)
                {
                    char[] chars = e.FormattedValue.ToString().ToCharArray();
                    foreach (char c in chars)
                    {
                        if (char.IsDigit(c) == false)
                        {
                            cell.Value = "0";
                            itemGridView.RefreshEdit();
                            e.Cancel = true;
                            MessageBox.Show("You must enter digits only");
                        }
                    }
                }
            }
        }
    }
}
