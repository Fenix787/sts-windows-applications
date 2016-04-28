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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sections = pop.processsComission(1234, "Bell South", 2567863.28);
            foreach (string section in sections )
            {
                Console.WriteLine(section);
            }
        }
    }
}
