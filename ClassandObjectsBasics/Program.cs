using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObjectsBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orders orderObj1 = new Orders(1,DateTime.Now,0,10);
            
            var updatedQuantity = orderObj1.quantity;
            
            Console.WriteLine(updatedQuantity);

            orderObj1.GetOrderDetails();
                  
        }
    }
}
