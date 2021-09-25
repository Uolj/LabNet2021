using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Logic
{
    public class CustomersExercisesLogic : LinqExercisesLogic
    {
        //1
        public Customers ReturnCustomer()
        {
            //method syntax
            //return context.Customers.FirstOrDefault();

            //query syntax
            var query = from customers in context.Customers
                        select customers;
            return query.First();
        }
        //----------------------------------------------------------------
        //4
        public List<Customers> ReturnWACustomers()
        {
            //method syntax
            return context.Customers.Where(c => c.Region == "WA").ToList();

            //query syntax
            //var query = from customers in context.Customers
            //            where customers.City == "WA"
            //            select customers;
            //return query.ToList();
        }
        //-----------------------------------------------------------------
        //6
        public List<string> ReturnUpperAndLowerCase()
        {
            //method syntax
            //var stringQuery = context.Customers.Select(x => x.ContactName).ToList();
            //var query = stringQuery
            //    .ConvertAll(c => c.ToUpper())
            //    .Union(stringQuery
            //    .ConvertAll(c => c.ToLower()));
            //return query.ToList();

            //query syntax
            var query = from customers in context.Customers
                        select customers.ContactName;

            var upperLowerCaseCustomers = new List<string>();
            foreach (var item in query)
            {
                upperLowerCaseCustomers.Add(item.ToUpper());
                upperLowerCaseCustomers.Add(item.ToLower());
            }
            return upperLowerCaseCustomers;
        }


        //-----------------------------------------------------------------
        //7
        public List<CustomerOrders> ReturnJoin()
        {
            //query syntax
            //var query = from orders in context.Orders
            //            join customers in context.Customers
            //            on orders.CustomerID equals customers.CustomerID
            //            where orders.OrderDate > new DateTime(1997, 1, 1) && customers.Region == "WA"
            //            select new CustomerOrders()
            //            {
            //                CustomerName = customers.ContactName,
            //                CustomerRegion = customers.Region,
            //                OrderId = orders.OrderID,
            //                OrderDate = orders.OrderDate
            //            };
            //return query.ToList();

            //method syntax
            var query = context.Orders
                .Join(context.Customers
                  , o => o.CustomerID
                  , c => c.CustomerID
                  , (o, c) => new CustomerOrders()
                  {
                      CustomerName = c.ContactName,
                      CustomerRegion = c.Region,
                      OrderId = o.OrderID,
                      OrderDate = o.OrderDate
                  })
                .Where(customerOrder => customerOrder.CustomerRegion == "WA" && customerOrder.OrderDate > new DateTime(1997, 1, 1));
            return query.ToList();
        }
        //-----------------------------------------------------------------
        //8 Query para devolver los primeros 3 Customers de la  Región WA
        public List<Customers> ReturnThreeCustomersFromWA()
        {
            //query syntax
            var query = from customers in context.Customers
                        where customers.Region == "WA"
                        orderby customers.CustomerID
                        select customers;


            //method syntax
            //var query = context.Customers.Where(c => c.Region == "WA").OrderBy(c => c.CustomerID);
            return query.Take(3).ToList();

        }
        //-------------------------------------------------------------------
        //13
        public IEnumerable<dynamic> ReturnOrdersAndCustomers()
        {
            //query syntax
            var query = from customers in context.Customers
                        join orders in context.Orders
                        on customers.CustomerID
                            equals orders.CustomerID
                        into count
                        select new
                        {
                            ID = customers.CustomerID,
                            ContactName = customers.ContactName,
                            OrdersCuantity = count.Count()
                        };
            return query.ToList();
        }

    }
}