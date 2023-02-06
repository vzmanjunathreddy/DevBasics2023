using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQueringData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruits fruitObj= new Fruits();

            var listOfFruits = fruitObj.GetListOfFruits(); // Datalayer --> Raw data from different datasource 

            //IEnumerable<Fruits> listOfFruits= fruitObj.GetListOfFruits();

            //foreach(Fruits fruit in listOfFruits)
            //{
            //}

            // Get list of all the fruits whose quantity is >10

            // Lambda expressions

            // Business layer

            var fruits = listOfFruits.Where(x => x.Quantity >= 10);

            var fruitsQuantitygreater10 = listOfFruits.Where(x => x.Quantity >= 10).Select(i=> new{i.Quantity,i.Name}).ToList();

            // Get all fruits of Category Seasonal 

            var seasonFruits = listOfFruits.Where(x => x.Category.ToLower() == "seasonal" && x.Quantity>10);

            foreach (var fruit in listOfFruits)
            {
                Console.WriteLine(fruit.Name);
            }

            Console.ReadKey();

        }
    }
}
