using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionandEncapsultion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectIntern projectIntern = new ProjectIntern();

            var langs = projectIntern.GetLanguageDetails();

            foreach (var lan in langs)
            {
                Console.WriteLine($"Language is {lan}");
            }


            var courses = projectIntern.GetCourseDetails();

            foreach (var course in courses)
            {
                Console.WriteLine($"Courses is {course}");
            }
        }
    }
}
