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
        selectSalesRep ssr;
        MaintainSalesRep msrc;

        public updateSalesRep(MaintainSalesRep inmsrc, selectSalesRep inssr)
        {
            InitializeComponent();
            ssr = inssr;
            msrc = inmsrc;

            // populate form data
            firstNameTextBox.Text = msrc.editSalesRep.firstName;
            lastNameTextBox.Text = msrc.editSalesRep.lastName;
            usernameTextBox.Text = msrc.editSalesRep.username;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            ssr.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // populate cleartext data
            msrc.editSalesRep.firstName = firstNameTextBox.Text;
            msrc.editSalesRep.lastName = lastNameTextBox.Text;
            msrc.editSalesRep.username = usernameTextBox.Text;

            // update sales rep in database
            msrc.updateSalesRep(passwordTextBox.Text);

            // transition back to selectSalesRep
            this.Hide();
            ssr.populateSalesReps();
            ssr.Show();
        }

    }
}
