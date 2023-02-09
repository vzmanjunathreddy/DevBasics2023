using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Intefaces
{
    internal interface IOrderRepository
    {
        //Generic 

        bool AddCustomer(Orders customer);
        bool DeleteCustomer(Orders customer);
        IEnumerable<Orders> GetCustomersList();
        Orders GetCustomer(int Id);
    }
}
