using InheritanceDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionandEncapsultion
{
    public class Courses : ICourses
    {
        public IEnumerable<string> GetCourseDetails()
        {
            return new List<string> { "Database Administration", "LAW" };
        }

    }
}
