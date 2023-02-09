using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach
{
    class Program
    {
        static void Main(string[] args)
         {
            try
            {
                FoodDbConextCodeFirst dbContextCodeFirst = new FoodDbConextCodeFirst();

                // logged in user is Employee then show only few data fields 
                // logged in user is Manager then show only few data fields  + extra fields
                /// Logged in use is an admin show everythinhg 
                /// 
                
               // you have data loaded(xyz) then we can apply rules 

                var customers = dbContextCodeFirst.Customers.Where(x=>x.CustomerId==1).Include(a=>a.Orders).Include(i=>i.Orgnization).ToList();

                foreach (var customer in customers)
                {

                    Console.WriteLine($"Customer Name is {customer.FirstName}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }

    }
}
