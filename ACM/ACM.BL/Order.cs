using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase, ILogable
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            this.OrderID = orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; private set; }
        public List<OrderItem> orderItems { get; set; }
        public int CustomerID { get; set; }
        public int ShippingAddressId { get; set; }
        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate==null) isValid = false;
            return isValid;
        }

        public string Log()
        {
            var logstring = this.OrderID + ": " +
                           "date: " + this.OrderDate + " " +
                           "Status: " + this.EntityState.ToString();
            return logstring;
        }
    }
}
