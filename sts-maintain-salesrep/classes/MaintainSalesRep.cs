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
        public SalesRep editSalesRep = new SalesRep();

        public SalesRepDB srdb = new SalesRepDB();

        public DataTable getSalesRepList()
        {
            return srdb.getSalesRepList();
        }

        public SalesRep getSalesRep(int id)
        {
            editSalesRep = srdb.getSalesRep(id);
            editSalesRep.total = srdb.getCommissionTotal(id);
            return editSalesRep;
        }

        public void updateSalesRep (string newPassword)
        {
            srdb.updateSalesRep(editSalesRep,newPassword);
        }
    }
}
