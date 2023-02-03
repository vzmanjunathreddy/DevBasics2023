using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionandEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OnRollEmployee onRollEmployee = new OnRollEmployee("Virat", 100);
             var onRollSalary= onRollEmployee.ProcessEmployeeSalary();

            Console.WriteLine($"Computed Salaray after tax is {onRollSalary}");

            ContractEmployee cemp = new ContractEmployee("Yuvraj", 10, 130);
              var cSalry= cemp.ProcessEmployeeSalary();

            Console.WriteLine($"Computed Salaray is {cSalry}");

            onRollEmployee.GetUserDetails();
            cemp.GetUserDetails();

        }
    }
}
