using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using ACM.BL;
using System.Collections.Generic;

namespace Acme.CommonTest
{
    [TestClass]
    public class LogingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changeItems = new List<ILogable>();
            var customer = new Customer(1)
            {
                EmailAddress = "wimh0206@yahoo.com.vn",
                Firstname = "Nhu",
                LastName = "Nguyen",
                AddressList = null
            };
            changeItems.Add(customer as ILogable);
            var product = new Product(1)
            {
                ProductName = "Laptop",
                ProductDescription = "Laptop with pin",
                CurrentPrice = 5M
            };
            changeItems.Add(product as ILogable);
            //act
            LogingService.WriteToFile(changeItems);

        }
    }
}
