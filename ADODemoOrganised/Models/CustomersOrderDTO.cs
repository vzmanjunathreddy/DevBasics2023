using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemoOrganised.Models
{
    internal class CustomersOrderDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerType { get; set; }

    }
}
