using ADODemoOrganised.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemoOrganised.Interfaces
{
    internal interface ICustomerOrders
    {
        IEnumerable<CustomersOrderDTO> GetCustomersOrdes(int CustomerId);
    }
}
