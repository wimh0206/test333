using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class AddressRepositoryTest
    {
        [TestMethod]
        public void AddressRetrieveExisting()
        {
            //Arrange
            var addressRepository = new AddressRepository();
            var expected = new Address(1)
            {
                AddressType = 1,
                City = "HCM",
                Country = "Vietnam",
                PostCode = "221111",
                State = "",
                StreetLine1 = "Line1_rebase",
                StreetLine2 = "Line2"
            };
            // Act
            var actual = addressRepository.Retrieve(1);
            bool a = (actual == expected) ? true : false;
            //Assert
            Assert.AreEqual(expected.AddressType, actual.AddressType);
            Assert.AreEqual(expected.City, actual.City);
            Assert.AreEqual(expected.Country, actual.Country);
            Assert.AreEqual(expected.State, actual.State);
            Assert.AreEqual(expected.StreetLine1, actual.StreetLine1);
            Assert.AreEqual(expected.StreetLine2, actual.StreetLine2);

        }
    }
}
