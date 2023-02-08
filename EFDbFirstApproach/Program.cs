using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodDbConext foodDbConext = new FoodDbConext();

            var customersCollection = foodDbConext.Customers.ToList();

            Console.WriteLine($"Count of Customers is {customersCollection.Count()}");


            var customers = foodDbConext.Customers.Where(x=>x.CustomerId==1).FirstOrDefault();

            foodDbConext.Customers.Add(new Customer()
            {
                Email = "EF@Efmail.com",
                FirstName = "DbFristApproach",
                LastName = "DB",
                OrgId = 3,
                Phone = "123-234-567"
            });
            foodDbConext.SaveChanges();

            Console.WriteLine($"Count of Customers After addding  {customersCollection.Count()}");

            Console.WriteLine(customers.FirstName);

            //foreach(var customer in customers)
            //{
            //    Console.WriteLine($"Customer Name is {customer.FirstName}");
            //}
        }
    }
}
