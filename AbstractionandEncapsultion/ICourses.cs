using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionandEncapsultion
{
    internal interface ICourses
    {
        IEnumerable<string> GetCourseDetails();        
    }
}
