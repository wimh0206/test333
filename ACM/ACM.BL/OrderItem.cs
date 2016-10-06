using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }
        public int OrderItemId { get; set; }
        public int OrderQuantity { get; set; }
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }
        public override bool Validate()
        {
            var isValid = true;
            if (OrderQuantity<0) isValid = false;
            if (ProductID <= 0) isValid = false;
            if (PurchasePrice ==null) isValid = false;
            return isValid;
        }
        public bool Save()
        {
            return true;
        }
    }
}
