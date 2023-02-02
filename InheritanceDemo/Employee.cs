using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Employee:Person
    {
        public int employeeId = 12;

        public int Salary = 100;

        public Employee()
        {
            Console.WriteLine($"I am derived Class Constructor");
        }
        public override void GetUserinfor()
        {
            base.GetUserinfor();
            Console.WriteLine($" Salary is {Salary}");
        }


    }
}
