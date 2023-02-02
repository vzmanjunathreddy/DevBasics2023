using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    public class DepartmentEnums
    {
        public enum Departments
        {
            HR=1,Sales,Marketing,IT,Admin
        };

        public void ProcessDepartmentData()
        {

           foreach(var dept in Enum.GetNames(typeof(Departments)))
            {
                Console.WriteLine($"Department name is {dept}");
            }
           Console.ReadKey();
        }
  
        public void ProcessBasedOnInPut()
        {
            Console.WriteLine("Enter the Department to process");
            var dept =Enum.Parse(typeof(Departments), Console.ReadLine());

            switch(dept)
            {

                case Departments.HR:
                    Console.WriteLine("Department is HR");
                    break;

                case Departments.Admin:
                    Console.WriteLine("Department is Admin");
                    break;

                case Departments.IT:
                    Console.WriteLine("Department is IT");
                    break;

                case Departments.Marketing:
                    Console.WriteLine("Department is HR");
                    break;

                 default:
                    Console.WriteLine("Department is HR");
                    break;
            }
        }
    }
}
