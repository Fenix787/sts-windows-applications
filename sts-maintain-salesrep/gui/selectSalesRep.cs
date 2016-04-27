using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sts_maintain_salesrep
{
    public partial class selectSalesRep : Form
    {
        // create controller
        public MaintainSalesRep msrc = new MaintainSalesRep();

        public selectSalesRep()
        {
            InitializeComponent();
            populateSalesReps();
        }

        public void populateSalesReps()
        {
            salesRepList.DataSource = msrc.getSalesRepList();
            salesRepList.DisplayMember = "username";
            salesRepList.ValueMember = "id";
            salesRepList.Update();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            msrc.getSalesRep((int)salesRepList.SelectedValue);
            updateSalesRep updateForm = new updateSalesRep(msrc,this);
            updateForm.Update();
            updateForm.Show();
        }
    }
}
