using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionandEncapsulation
{
    public class OnRollEmployee : Employee
    {
        int salary;
        private int numberOfdays=20;

        public OnRollEmployee(string name,int salary):base(name) 
        {
            this.salary = salary;
            Console.WriteLine($"Name of the employee and Salary is {salary}");
        }
        public override int ProcessEmployeeSalary()
        {
            var tax = computeTax();
            var salaryComputatiion = numberOfdays * salary- tax;        
            return salaryComputatiion;
        }

        private int computeTax()
        {
            return 10;
        }
    }
}
