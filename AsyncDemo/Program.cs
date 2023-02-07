using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDemo
{
    internal class Program
    {
        static  void Main(string[] args)
        {

            // Sync and Asycn.

            // Connect to db and get data  1 sec
            // Send an email request is recieved 2 sec
            // Update customerId in third party system 3 sec


            //6 seconds 

            Fruits fruitsObj= new Fruits();

            var ordersNames=  fruitsObj.GetOrdersAsync();

            foreach (var order in ordersNames.Result)
            {
                Console.WriteLine(order);
            }
        }
    }
}
