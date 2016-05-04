using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace sts_maintain_salesrep
{
    public partial class updateSalesRep : Form
    {
        public selectSalesRep ssr;
        public MaintainSalesRep msrc;
        public SalesRep editSalesRep;

        public updateSalesRep(MaintainSalesRep inmsrc, selectSalesRep inssr)
        {
            InitializeComponent();
            ssr = inssr;
            msrc = inmsrc;
        }

        public void populateSalesRep(int inSalesRep, string title)
        {
            Text = title;

            // get all data about salesrep
            editSalesRep = msrc.getSalesRep(inSalesRep);

            // populate form data
            firstNameTextBox.Text = editSalesRep.firstName;
            lastNameTextBox.Text = editSalesRep.lastName;
            usernameTextBox.Text = editSalesRep.username;
            if (editSalesRep.total != 0)
            {
                totalValueLabel.Text = "$" + editSalesRep.total.ToString("#,###.##");
            }
            else
            {
                totalValueLabel.Text = "$0.00";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // populate cleartext data
            editSalesRep.firstName = firstNameTextBox.Text;
            editSalesRep.lastName = lastNameTextBox.Text;
            editSalesRep.username = usernameTextBox.Text;

            // update sales rep in database
            msrc.updateSalesRep(editSalesRep,passwordTextBox.Text);

            // transition back to selectSalesRep
            Hide();
            ssr.populateSalesReps();
            ssr.Show();
        }

    }
}
