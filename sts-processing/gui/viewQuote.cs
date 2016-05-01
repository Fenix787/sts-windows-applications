﻿using System;
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

            discountTextBox.Text = pqc.getDiscount(quote).ToString();

            populateItems();
        }

        private void populateItems()
        {
            itemGridView.DataSource = pqc.getItems(quote).Tables[0];
            // hide id and quote id
            itemGridView.Columns[0].Visible = false;
            itemGridView.Columns[1].Visible = false;

            itemGridView.Update();
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

        private void discountButton_Click(object sender, EventArgs e)
        {
            pqc.updateDiscount(quote, Convert.ToDouble(discountTextBox.Text));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            slq.Show();
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
