using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.Firstname = "Bilbo";
            customer.LastName = "Baggins";
            string expected = "Baggins, Bilbo";
           //--Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.Firstname = "Bilbo";
            string expected = "Bilbo";
            //--Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            string expected = "Baggins";
            //--Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            Customer c1 = new Customer();
            c1.Firstname = "Nhu";
            Customer.InstanceCount += 1;

            Customer c2 = new Customer();
            c1.Firstname = "Nhuu1";
            Customer.InstanceCount += 1;

            Customer c3 = new Customer();
            c1.Firstname = "Nhu22";
            Customer.InstanceCount += 1;

            //asset
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValidTrue()
        {
            //--Arrange
            Customer c = new Customer();
            c.LastName = "Nhu";
            c.EmailAddress = "wimh0206@yahoo.com.vn";
            var actual = c.Validate();

            //asset
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidateValidEmailBlank()
        {
            //--Arrange
            Customer c = new Customer();
            c.Firstname = "Nhu";
            c.EmailAddress = " ";
            var actual = c.Validate();

            //asset
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ValidateValidEmailEmpty()
        {
            //--Arrange
            Customer c = new Customer();
            c.Firstname = "Nhu";
            var actual = c.Validate();

            //asset
            Assert.AreEqual(false, actual);
        }


        [TestMethod]
        public void ValidateValidFirstNameBlank()
        {
            //--Arrange
            Customer c = new Customer();
            c.Firstname = "";
            c.EmailAddress = "wimh0206@yahoo.com.vn";
            var actual = c.Validate();

            //asset
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ValidateValidFirstNameEmpty()
        {
            //--Arrange
            Customer c = new Customer();
            c.Firstname = "wimh0206@yahoo.com.vn";
            var actual = c.Validate();

            //asset
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ValidateValidFirstNameEmailEmpty()
        {
            //--Arrange
            Customer c = new Customer();
            var actual = c.Validate();

            //asset
            Assert.AreEqual(false, actual);
        }
    }
}
