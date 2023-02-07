using ADODemoOrganised.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemoOrganised
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomersDTO customersDTO = new CustomersDTO();

            var customers = customersDTO.GetCustomers();

            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer Name {customer.FirstName} ");
                Console.WriteLine($"Customer Email {customer.Email} ");
            }

        }
    }
}
