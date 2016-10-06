using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertspaceValid()
        {
            //Arrange
            var source = "SonicScrewder";
            var expect = "Sonic Screwder";
            //Act
            var actual = source.InsertSpace();
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void InsertspaceWithExistingSpace()
        {
            //Arrange
            var source = "Sonic Screwder";
            var expect = "Sonic Screwder";
            //Act
            var actual = source.InsertSpace(); 
            //assert
            Assert.AreEqual(expect, actual);
        }
    }
}
