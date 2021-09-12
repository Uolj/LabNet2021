using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities;
using UI;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
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
            try
            {
                Logic.ThrowCustomException("something");
            }
            catch (CustomException customException)
            {
                //assert
                Assert.AreEqual(expectedMessage, customException.Message);
            }
        }
    }
}
