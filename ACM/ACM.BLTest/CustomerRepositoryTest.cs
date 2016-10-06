using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void CustomerRetrieveExisting ()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "wimh0206@yahoo.com.vn",
                Firstname = "Nhu",
                LastName = "Nguyen"
	        };
            // Act
            var actual = customerRepository.Retrieve(1);
            bool a = (actual == expected) ? true : false;
            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.Firstname, actual.Firstname);
            Assert.AreEqual(expected.LastName, actual.LastName);
            
        }
        [TestMethod]
        public void CustomerRetrieveExistingAddress()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "wimh0206@yahoo.com.vn",
                Firstname = "Nhu",
                LastName = "Nguyen",
                AddressList = new List<Address>() 
                { 
                    new Address(1)
                    {
                        AddressType = 1,
                        City = "HCM",
                        Country = "Vietnam",
                        PostCode = "221",
                        State = "HCM",
                        StreetLine1 = "Line1",
                        StreetLine2 = "Line2"
                    },
                    new Address(1)
                    {
                        AddressType = 2,
                        City = "Heilbronn",
                        Country = "Germany",
                        PostCode = "74074",
                        State = "Baden",
                        StreetLine1 = "Line3",
                        StreetLine2 = "Line4"
                    }   
               }
            };
            // Act
            var actual = customerRepository.Retrieve(1);
            bool a = (actual == expected) ? true : false;
            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.Firstname, actual.Firstname);
            Assert.AreEqual(expected.LastName, actual.LastName);
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostCode, actual.AddressList[i].PostCode);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
            }
        }
    }
}
