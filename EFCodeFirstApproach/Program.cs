using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach
{
    class Program
    {
        static void Main(string[] args)
         {
            FoodDbConextCodeFirst dbContextCodeFirst = new FoodDbConextCodeFirst();

            var customers = dbContextCodeFirst.Customers.ToList();
            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer Name is {customer.FirstName}");
            }
        }

    }
}
