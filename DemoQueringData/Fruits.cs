using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQueringData
{
    internal class Fruits
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public string Category { get; set; }

        public IEnumerable<Fruits> GetListOfFruits()
        {
            List<Fruits> fruitsCollection = null;

            try
            {
                fruitsCollection = new List<Fruits>();
                Fruits fruits = new Fruits()
                {
                    Id = 1,
                    Name = "Mango",
                    Price = 100,
                    Quantity = 1,
                    Category = "Seasonal"
                };

                Fruits fruits2 = new Fruits()
                {
                    Id = 2,
                    Name = "Banana",
                    Price = 10,
                    Quantity = 10,
                    Category = "UnSeasonal"
                };
                fruitsCollection.Add(fruits);
                fruitsCollection.Add(fruits2);

                fruitsCollection.Add(new Fruits()
                {
                    Id = 3,
                    Name = "Apple",
                    Price = 500,
                    Quantity = 20,
                    Category = "Seasonal"
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Occured is {ex.ToString()}");
            }

            return fruitsCollection;
        }


        public Fruits GetFruitById(int id)
        {
            Fruits fruit = null;

            try
            {
                fruit = GetListOfFruits().Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
            return fruit;
        }

        public Fruits GetFruitByName(string name)
        {
            Fruits fruit = null;

            try
            {
                fruit = GetListOfFruits().Where(x => x.Name == name).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
            return fruit;
        }

        //Solid Priniciples 
         // Single Responsi
    }
}
