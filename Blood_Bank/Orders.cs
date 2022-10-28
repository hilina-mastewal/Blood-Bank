using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank
{
   public class Orders
    {
        public int id,fk_hospital, fk_bank;
        public string bloodType, dateOfOrder;
        public decimal qty;

        public DataTable getOrders(string text)
        {
            var db1 = new DbOrdor();
            DataTable dt = db1.getOrder(text);
            return dt;
        }
        public int updateOrders()
        {
            DbOrdor dbo= new DbOrdor();
            return dbo.updateOrder(this);

        }
        public int deleteOrders()
        {
            DbOrdor dbo= new DbOrdor();
            return dbo.deleteOrder(this.id);

        }

        


    }
}
