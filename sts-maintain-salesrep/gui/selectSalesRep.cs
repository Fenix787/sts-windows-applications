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

        // create updateSalesRep
        public updateSalesRep updateForm;

        public selectSalesRep()
        {
            InitializeComponent();
            populateSalesReps();

            updateForm = new updateSalesRep(msrc,this);
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
            DataRowView drv = salesRepList.SelectedItem as DataRowView;
            if (updateForm.IsDisposed) { updateForm = new updateSalesRep(msrc, this); }


            updateForm.populateSalesRep((int)drv.Row["id"], drv.Row["username"].ToString());
            updateForm.Update();
            updateForm.Show();
        }
    }
}
