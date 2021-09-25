using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Logic
{
    public class ProductsExercisesLogic : LinqExercisesLogic
    {
        //2
        public List<Products> ReturnProductsWithoutStock()
        {
            //method syntax
            return context.Products.Where(p => p.UnitsInStock == 0).ToList();

            //query syntax
            //var query = from products in context.Products
            //            where products.UnitsInStock == 0
            //            select products;
            //return query.ToList();
        }

        //----------------------------------------------------
        //3
        public List<Products> ReturnExpensiveProductsInStock()
        {
            //method syntax
            return context.Products.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3).ToList();

            //query syntax
            //var query = from products in context.Products
            //            where products.UnitsInStock != 0 && products.UnitsInStock > 3
            //            select products;
            //return query.ToList();
        }
        //----------------------------------------------------
        //5
        public Products ReturnFirstOrNull()
        {
            //method syntax
            return context.Products.FirstOrDefault(x => x.ProductID == 789);

            //query syntax
            //var query = from products in context.Products
            //            where products.ProductID == 789
            //            select products;
            //return query.FirstOrDefault();
        }

        //----------------------------------------------------
        //9
        public List<Products> OrderProductsByName()
        {
            //method syntax

            //return context.Products.OrderBy(x => x.ProductName).ToList();

            //query syntax

            var query = from products in context.Products
                        orderby products.ProductName
                        select products;

            return query.ToList();
        }

        //----------------------------------------------------
        //10
        public List<Products> OrderProductsByUnitStock()
        {
            //method syntax

            //return context.Products.OrderByDescending(x => x.UnitsInStock).ToList();

            //query syntax

            var query = from products in context.Products
                        orderby products descending
                        select products;

            return query.ToList();
        }

        //----------------------------------------------------
        //11
        public List<int?> ReturnCategories()
        {
            //method syntax
            var query = context.Products.Select(x => x.CategoryID);

            return query.ToList();
        }

        //-----------------------------------------------------
        //12
        public List<Products> ReturnTheFirstProduct()
        {
            //method syntax

            //return context.Products.Take(1).ToList();

            //query syntax

            var query = from products in context.Products
                        select products;

            return query.Take(1).ToList();
        }

    }

}
