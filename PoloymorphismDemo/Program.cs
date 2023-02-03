using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoloymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnRollEmployee onRollEmployee= new OnRollEmployee();
            onRollEmployee.GetComputedSalary();
        }
    }
}
