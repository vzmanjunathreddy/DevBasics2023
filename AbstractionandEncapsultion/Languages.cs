using InheritanceDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionandEncapsultion
{
    public class Languages:ILanguages
    {
        public IEnumerable<string> GetLanguageDetails()
        {
            return new List<string> { "C#,Java,LAW" };
        }
    }
}
