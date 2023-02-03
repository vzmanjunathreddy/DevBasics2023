using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionandEncapsulation
{
    // Abstract class are always base classes 
    // Abstract classes can't be Sealed
    public abstract class Employee // Class prefixed with Abstract and has abstract methods is called Abstract class
    {
        public int EmployeeId { get; set; }
        public Employee(string name) // ctor double tab will construc the constructor 
        {
            Console.WriteLine($"Name is {name}");
        }
        public abstract int ProcessEmployeeSalary(); // Abstract method

        public string GetUserDetails() // non abstract method
        {
            return "Welcome  User";
        }
        
       
    }
}
