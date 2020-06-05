using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Project;

namespace Tests
{
    [TestClass]
    public class ServiceCodeUnitTests
    {
        [TestMethod]
        public void positiveServiceCode()
        {
            //Arrange
            var servCode = new ServiceCodes();
            servCode.ServiceCode = "VYO09675";
            servCode.Cost = 45.50;

            //Act     
            var actual = servCode.ServiceCode;
            var actual2 = servCode.Cost;


            //Assert
            Assert.AreEqual("VYO09675", actual);
            Assert.AreEqual(45.50, actual2);


        }

        [TestMethod]
        public void NullServiceCode()
        {
            //Arrange
            var sc1 = new ServiceCodes
            {
                ServiceCode = null
            };

            var expected = "Exception";

            //Act
            var actual = sc1.ServiceCode;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MethodTest()
        {
            var obj = new ServiceCodes(null);
        }
    }
}