using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal interface ICustomersRepository
    {
        Task<bool> AddCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        Task<IEnumerable<Customers>> GetCustomersList();
        Customers GetCustomer(int Id);
    }
}
