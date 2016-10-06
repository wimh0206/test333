using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderID)
        {
            Order order = new Order(orderID);
            if (orderID == 1)
            {
                DateTime localTime = new DateTime(2014, 5, 5, 1, 1, 1); 
                order.OrderDate = new DateTimeOffset(2014, 5, 5, 1, 1, 1, TimeZoneInfo.Local.GetUtcOffset(localTime));
            }
            return order;
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
        public OrderDisplay RetrieveOrderDisplay(int orderID)
        {
            OrderDisplay orderDisplay = new OrderDisplay();
            //Temporary Hard Code
            if (orderID == 10)
            {
                orderDisplay.FirstName = "Nhu";
                orderDisplay.LastName = "Nguyen";
                DateTime localTime = new DateTime(2014, 5, 5, 1, 1, 1);
                orderDisplay.OrderDate = new DateTimeOffset(2014, 5, 5, 1, 1, 1, TimeZoneInfo.Local.GetUtcOffset(localTime));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    City = "HCM",
                    Country = "Vietnam",
                    PostCode = "221",
                    State = "",
                    StreetLine1 = "Line1",
                    StreetLine2 = "Line2"
                };
               
            }
            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();
            //Temporary Hard Code
            if (orderID == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    OrderQuantity = 10,
                    ProductName = "Laptop",
                    PurchasePrice = 2500
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
                orderDisplayItem = new OrderDisplayItem()
                {
                    OrderQuantity = 20,
                    ProductName = "Pen",
                    PurchasePrice = 55.55m
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
            }
            return orderDisplay;
        }
        public bool Save()
        {
            return true;
        }
    }
}
