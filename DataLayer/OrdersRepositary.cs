using DataLayer.Intefaces;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class OrdersRepositary : IOrderRepository
    {
        public bool AddCustomer(Orders customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(Orders customer)
        {
            throw new NotImplementedException();
        }

        public Orders GetCustomer(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Orders> GetCustomersList()
        {
            throw new NotImplementedException();
        }
    }
}
