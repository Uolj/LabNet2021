using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Data;
using Logic;
using PracticaEFUI;
using Entities;

namespace UnitTest
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        [ExpectedException (typeof(FormatException))]
        public void Should_ThrowException_When_StringIsEmpty()
        {
            Categories testCategory = new Categories("", "example description");
            var categoriesLogic = new CategoriesLogic();
            categoriesLogic.DataCheck<Categories>(testCategory);
        }

        [TestMethod]
        [ExpectedException(typeof(CharacterLimitExceededException))]
        public void Should_ThrowException_When_CharacterLimitIsExceeded()
        {
            Categories testCategory = new Categories("1111111111111111", "example description");
            var categoriesLogic = new CategoriesLogic();
            categoriesLogic.DataCheck<Categories>(testCategory);
        }


    }
}
