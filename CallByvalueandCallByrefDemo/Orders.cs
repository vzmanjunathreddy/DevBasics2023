using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByvalueandCallByrefDemo
{
    internal class Orders
    {
        public void GetUpdatedOrders(int ordersCount)
        {
            ordersCount = ordersCount * ordersCount;
            Console.WriteLine($"Count of Orders is {ordersCount}");
            
        }

        public void GetUpdatedOrdersbyrefernce(ref int ordersCount)
        {
            ordersCount = ordersCount * ordersCount;
            Console.WriteLine($"Count of Orders is {ordersCount}");

        }

        public void GetUpdatedOrdersbyoout(out int ordersCount)
        {
            ordersCount = 10;
            ordersCount = ordersCount * ordersCount;
            Console.WriteLine($"Count of Orders is {ordersCount}");

        }
    }
}
