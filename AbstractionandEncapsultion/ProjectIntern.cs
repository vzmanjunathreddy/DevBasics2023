using InheritanceDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionandEncapsultion
{
    public class ProjectIntern :Employee, ICourses, ILanguages
    {
        Courses courseObj= new Courses();
        Languages languagesObj= new Languages();

        public IEnumerable<string> GetCourseDetails()
        {
           return courseObj.GetCourseDetails();
        }

        public IEnumerable<string> GetLanguageDetails()
        {
            return languagesObj.GetLanguageDetails();
        }
    }
}
