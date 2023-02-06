using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByvalueandCallByrefDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region //  Pass by value

            //Orders ordersObj = new Orders();
            ////int ordersCount = 10;

            ////Console.WriteLine($"Initial Orders Count is {ordersCount}");

            ////ordersObj.GetUpdatedOrders(ordersCount);

            ////Console.WriteLine($"Updated Orders Count is {ordersCount}");
            ////Console.ReadKey();
            #endregion


            #region pass by reference  

            // In ref method we need to initialize the value before calling the method

            //Orders ordersObj = new Orders();
            //int ordersCount = 10;

            //Console.WriteLine($"Initial Orders Count is {ordersCount}");

            //ordersObj.GetUpdatedOrdersbyrefernce(ref ordersCount);

            //Console.WriteLine($"Updated Orders Count is {ordersCount}");
            //Console.ReadKey();

            #endregion


            #region call by Out type

            Orders ordersObj = new Orders();
            int ordersCount;

           // Console.WriteLine($"Initial Orders Count is {ordersCount}");

            ordersObj.GetUpdatedOrdersbyoout(out ordersCount);

            Console.WriteLine($"Updated Orders Count is {ordersCount}");
            Console.ReadKey();

            #endregion

        }
    }
}
