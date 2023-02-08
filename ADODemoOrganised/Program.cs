using ADODemoOrganised.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemoOrganised
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Old Code
            //CustomersDTO customersDTO = new CustomersDTO();

            //var customers = customersDTO.GetCustomers();

            //foreach (var customer in customers)
            //{
            //    Console.WriteLine($"Customer Name {customer.FirstName} ");
            //    Console.WriteLine($"Customer Email {customer.Email} ");
            //}
            #endregion

            string connectionString = ConfigurationManager.ConnectionStrings["sqlConnectionString"].ToString();
            CustomerOrderDetails customerOrderDetails = new CustomerOrderDetails(connectionString);

            Console.WriteLine("Enter the Customer Id to get the List of Orders places");

            int customerId=Convert.ToInt32(Console.ReadLine());

            var customerOrders = customerOrderDetails.GetCustomersOrdes(customerId);

            foreach(var customerOrder in customerOrders)
            {
                Console.WriteLine($"Customer OrderDate is {customerOrder.OrderDate} |  {customerOrder.FirstName} | {customerOrder.LastName} ");
            }
            Console.ReadKey();

        }
    }
}
