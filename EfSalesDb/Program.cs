using System;
using System.Linq;

namespace EfSalesDb
{
    class Program
    {

        static void Main(string[] args)
        {
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

        }
        
    }
}
