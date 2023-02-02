using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DepartmentEnums dept = new DepartmentEnums();

            // dept.ProcessDepartmentData();

            dept.ProcessBasedOnInPut();
        }
    }
}
