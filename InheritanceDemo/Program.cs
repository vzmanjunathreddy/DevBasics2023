using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee empObj = new Employee();

            //Base Class details
            Person person = new Person();
            person.GetUserinfor();

            //Base and Child class data 
            empObj.GetUserinfor();

            //ContactEmployee

            //OnRollEmployee
        }
    }
}
