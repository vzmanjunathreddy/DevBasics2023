using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Orders
    {
        public string GetOrderDetails(string orderId)
        {

            if(!string.IsNullOrEmpty(orderId))
            {
                Console.WriteLine($"Order found and its details are {orderId}");
                return "OrderFound";
            }
            else
            {
                throw new OrderNotFoundException("Either OrderId is invalid or Order is not found");
            }
            
        }
    }
}
