using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sts_maintain_salesrep
{
    public class MaintainSalesRep
    {

        public SalesRepDB srdb;

        public DataTable getSalesRepList()
        {
            if (srdb == null) { srdb = new SalesRepDB(); }

            // get only quotes that have been processed
            DataTable salesreps = srdb.getSalesRepList();

            // format name field
            foreach (DataRow row in salesreps.Rows)
            {
                row["username"] = row["username"] + " | " + row["first"] + " " + row["last"];
            }
            return salesreps;
        }

        public SalesRep getSalesRep(int id)
        {
            if (srdb == null) { srdb = new SalesRepDB(); }
            SalesRep getSalesRep = srdb.getSalesRep(id);
            getSalesRep.total = srdb.getCommissionTotal(id);
            return getSalesRep;
        }

        public void updateSalesRep (SalesRep editSalesRep, string newPassword)
        {
            if (srdb == null) { srdb = new SalesRepDB(); }
            srdb.updateSalesRep(editSalesRep,newPassword);
        }
    }
}
