using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Person
    {
        protected string aadharNumber = "123-ANC-asdf";
        protected string name = "ABC";

        public Person()
        {
            Console.WriteLine("I am a BaseClass Constructor -- Person ");
        }
        public virtual void GetUserinfor()
        {
            Console.WriteLine($"aadharNumber is {aadharNumber} and Name is {name}");
        }

    }
}
