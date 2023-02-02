using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
             KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>();

            Dictionary<string, string> dictonioaryKeyvalue = new Dictionary<string, string>();

            dictonioaryKeyvalue.Add("Name", "Pathan");
            dictonioaryKeyvalue.Add("Versionn", "English");
            dictonioaryKeyvalue.Add("Qaulity", "FULL HD");

            dictonioaryKeyvalue.Add("Name1", "PathanKannada");
            dictonioaryKeyvalue.Add("Versionn2", "Kannada");
            dictonioaryKeyvalue.Add("Qaulity2", "FULL HD");

            if(dictonioaryKeyvalue.ContainsKey("Name"))
            {
                foreach (var data in dictonioaryKeyvalue)
                {
                    if (data.Value != null && data.Key == "Name")
                    {
                        Console.WriteLine(data.Value);
                    }

                }

            }


            // Movie Search Filter
            // 1.Name="Pathan",
            // Versionn="English"
            // Qaulity=FULL HD


            //Inheritance
            //Abstraction
            //encapsulation


        }
    }
}
