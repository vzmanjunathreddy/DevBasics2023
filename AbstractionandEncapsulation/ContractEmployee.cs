using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionandEncapsulation
{
    internal class ContractEmployee:Employee
    {
        int hours;
        int salary;
        public ContractEmployee(string name, int hours,int salary):base(name) 
        {
            this.hours = hours;
            this.salary = salary;

            Console.WriteLine($"Name is {name} and hours logged is {hours} and salary is {salary}");
        }

        public override int ProcessEmployeeSalary()
        {
            var computedSalary = hours * salary;
            return computedSalary;
        }

    }
}
