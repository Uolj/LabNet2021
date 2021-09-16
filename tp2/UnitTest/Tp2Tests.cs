using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;
using UI;

namespace UnitTest
{
    [TestClass]
    public class Tp2Tests
    {
        [DataRow(5, 0)]
        [DataRow(98, 0)]
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Should_ThrowDivideByZeroException(int dividend, int divisor)
        {
            //act
            dividend.Divide(divisor);
        }


        [TestMethod]
        public void Should_ShowCustomMessage_When_CustomExceptionIsThrown()
        {
            //arrange
            string expectedMessage = "Now this is my exception B¬| --> something";
            //act
            var newException = new CustomException("something");
            //Assert
            Assert.AreEqual(expectedMessage, newException.Message);
        }
    }
}
