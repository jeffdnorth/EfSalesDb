using System;
using System.Linq;

namespace EfSalesDb
{
    class Program
    {
        private static int rowsAffected;

        static void Main(string[] args)
        {

            //entity framework is below
            //created an instance of our db context
            var context = new SalesdbContext();
            //all cust returned  does everthing that out get all statement does with less work
            var customers = context.Customers.ToList();
            //get PK for 1 in our data table customers
            var customer = context.Customers.Find(1);
            //bring back only cust in cinn using lambda  syntax
            var customersInCincinnati = context.Customers
                     .Where(c => c.City == "Cincinnati")
                     .ToList();
            
            //main methods ins, update delete
            //ins
            var newCustomer = new Customer()
            {
                Name = "tql", City = "Cincinnati", State = "OH", Sales = 400000, Active = true
            };
           // context.Customers.Add(newCustomer);
            //add var takes int and gets a string
            //var rowsAffected = context.SaveChanges();
            //update  -will not work as my table does not have  a 43
            var tql = context.Customers.Find(43);
           //tql.Name = "Total Quality Logistics";
            var rowsAffected = context.SaveChanges();


            //delete records
            
            tql = context.Customers.Find(43);
            context.Customers.Remove(tql);
            rowsAffected = context.SaveChanges();

            //read the order and bring back the cust for each order
            var orders = context.Orders.ToList();



        }
        
    }
}
