using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoloymorphismDemo
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public virtual void GetComputedSalary()
        {
            Console.WriteLine("Computed Salary in Base Class is... ");
        }
    }

    internal class OnRollEmployee:Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public override void GetComputedSalary()
        {
            base.GetComputedSalary();
            Console.WriteLine("Overriden  Salary in derived Class is... ");
        }
    }
}
