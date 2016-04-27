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

            // hash password with salt and populate if it has changed
            if(passwordTextBox.Text != "")
            {
                msrc.editSalesRep.password = passwordTextBox.Text;
                msrc.editSalesRep.password = hashToString(msrc.editSalesRep.password + msrc.editSalesRep.salt);
            }
            msrc.updateSalesRep();
            Close();
            ssr.populateSalesReps();
            ssr.Show();
        }

        // this function should be moved out of the gui
        public static string hashToString(string strData)
        {
            var message = Encoding.UTF8.GetBytes(strData);
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";

            var hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }

    }
}
