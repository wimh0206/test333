using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void ProductRetrieveMethod()
        {
            //arrange
            var product = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "soft1",
                ProductDescription = "Nhu",
                CurrentPrice = 200
            };
            var actual = product.Retrieve(1);
            //compare
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
