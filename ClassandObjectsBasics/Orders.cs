using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObjectsBasics
{
    public class Orders
    {
        private int qty=1;
        public int orderId { get; set; }
        public DateTime orderDate { get; set; }
        public string orderItem { get; set; }
        public double price { get; set; }
        public int quantity
        {
            get
            {
                return qty;
            }
            set
            {
                if(value<1)
                {
                    value = 1;
                }
                else
                {
                    quantity = value;
                }
                
            }
        }

            
            

        private int discount = 10;

        public Orders()
        {
            Console.WriteLine("Constructor is invoked");
        }


        //Dependency Injection 

        public Orders(int orderId, DateTime orderDate,int qunatity,double price)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.quantity = qunatity;
            this.price = price;

        }

        public void GetOrderDetails()
        {
            Console.WriteLine($"Order Details are {orderId} and {orderDate}");
            var totalCost = (price * quantity) - discount;
        }
    }
}
