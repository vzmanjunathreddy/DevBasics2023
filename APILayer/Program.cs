using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;
using ServiceLayer;

namespace APILayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerOrderProcessingService customerOrderProcessing= new CustomerOrderProcessingService();

            //Customers customers = new Customers
            //{
            //    Email = "DevCutomer4@Devapi.com",
            //    FirstName = "DevAPI",
            //    LastName = "ABCBBC",
            //    OrgId = 3,
            //    Phone = "56548"
            //};

            //var isCustomerAdded = customerOrderProcessing.AddCustomer(customers);

            var customersCollection = customerOrderProcessing.GetCustomers().Result;

            //foreach (var customer in customersCollection)
            //{
            //    Console.WriteLine($"{customer.FirstName},{customer.LastName} and Email is {customer.Email}");
            //}
            //Press F11 Key to get inside the method
            // Press F10 to execute

            //var isCusterDeleted = customerOrderProcessing.RemoveCustomer(1017);

            //Console.WriteLine($"Has the Customer been Deleted is {isCusterDeleted}");

        }
    }
}
