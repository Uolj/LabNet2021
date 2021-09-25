using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Data;
using Entities;
using Logic;

namespace UnitTest
{
    [TestClass]
    public class LinqTests
    {
        public readonly NorthwindContext context = new NorthwindContext();
        CustomersExercisesLogic customersExercises = new CustomersExercisesLogic();
        ProductsExercisesLogic productsExercises = new ProductsExercisesLogic();
        [TestMethod]
        public void Should_ReturnCustomerType()
        {
            //Assert
            Assert.IsInstanceOfType(customersExercises.ReturnCustomer(), typeof(Customers));
        }

        [TestMethod]
        public void Should_HaveZeroUnitsInStock()
        {
            //Arrange
            bool flag = true;

            //Act
            foreach (Products products in productsExercises.ReturnProductsWithoutStock())
            {
                if (products.UnitsInStock != 0)
                {
                    flag = false;
                    break;
                }
            }

            //Assert
            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void Should_ObtainNullValue_When_SearchForACheaperProduct()
        {
            //Arrange
            Products cheaperProduct;

            //Act
            cheaperProduct = productsExercises.ReturnExpensiveProductsInStock().Find(product => product.UnitPrice < 3);

            //Assert
            Assert.IsNull(cheaperProduct);
        }

        [TestMethod]
        public void Should_ObtainNullValue_When_SearchForAnInvalidRegion()
        {
            //Arrange
            var nullSearch = customersExercises.ReturnWACustomers().Find(c => c.Region == "**");
            //Assert
            Assert.IsNull(nullSearch);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Should_ReturnProductType()
        {
            //Assert
            Assert.AreEqual(productsExercises.ReturnFirstOrNull().ProductID, 789);
        }

        [TestMethod]
        public void Should_ContainUpperCaseNames()
        {
            //Arrange
            string testUpperCaseName = customersExercises.ReturnCustomer().ContactName.ToUpper() ;
            //Act
            bool result = customersExercises.ReturnUpperAndLowerCase().Contains(testUpperCaseName);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Should_ReturnCustomOrdersType()
        {
            //Assert
            Assert.IsInstanceOfType(customersExercises.ReturnJoin()[0], typeof(CustomerOrders));
        }
    }
}
