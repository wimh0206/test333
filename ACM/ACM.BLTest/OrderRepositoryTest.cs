using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void OrderRetrieveMethod()
        {
            //arrange
            var order = new OrderRepository();
            var expected = new Order(1){
                OrderDate = new DateTimeOffset(2014, 5, 5, 1, 1, 1, TimeZoneInfo.Local.GetUtcOffset(new DateTime(2014, 5, 5, 1, 1, 1)))
            };
            var actual = order.Retrieve(1);
            //compare
            Assert.AreEqual(expected.OrderID, actual.OrderID);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
        [TestMethod]
        public void OrderRetrieveOrderDisplayMethod()
        {
            //arrange
            
            var order = new OrderRepository();
            var expected = new OrderDisplay()
            {
                OrderDate = new DateTimeOffset(2014, 5, 5, 1, 1, 1, TimeZoneInfo.Local.GetUtcOffset(new DateTime(2014, 5, 5, 1, 1, 1))),
                FirstName = "Nhu",
                LastName = "Nguyen",
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    City = "HCM",
                    Country = "Vietnam",
                    PostCode = "221",
                    State = "",
                    StreetLine1 = "Line1",
                    StreetLine2 = "Line2"
                },
                orderDisplayItemList = new List<OrderDisplayItem>() {
                    new OrderDisplayItem(){
                
                        OrderQuantity = 10,
                        ProductName = "Laptop",
                        PurchasePrice = 2500
                    },
                    new OrderDisplayItem(){
                
                         OrderQuantity = 20,
                        ProductName = "Pen",
                        PurchasePrice = 55.55m
                    },
                },
               
            };
            var actual = order.RetrieveOrderDisplay(10);
            //compare
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
            Assert.AreEqual(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.AreEqual(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
            Assert.AreEqual(expected.ShippingAddress.PostCode, actual.ShippingAddress.PostCode);
            Assert.AreEqual(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.AreEqual(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.AreEqual(expected.ShippingAddress.StreetLine2, actual.ShippingAddress.StreetLine2);
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.orderDisplayItemList[i].OrderQuantity, actual.orderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(expected.orderDisplayItemList[i].ProductName, actual.orderDisplayItemList[i].ProductName);
                Assert.AreEqual(expected.orderDisplayItemList[i].PurchasePrice, actual.orderDisplayItemList[i].PurchasePrice);
            }
        }

    }
}
