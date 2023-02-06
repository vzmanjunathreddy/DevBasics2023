using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDemo
{
    internal class Fruits
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public string Category { get; set; }

        public async Task<IEnumerable<Fruits>> GetListOfFruits()
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
                    Category="Seasonal"
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
            catch(Exception ex)
            {
                Console.WriteLine($"Exception Occured is {ex.ToString()}");
            }

            return fruitsCollection;
        }

        public async Task<IEnumerable<string>> GetOrdersAsync()
        {
            List<string> orderNames = null;
            try
            {
                orderNames = new List<string>();

                var task = Task.Run(() =>
                    {
                        //Oder come from database
                        orderNames.Add("Order1");
                    });

                var task2 = Task.Run(() =>
                {
                    // order come cloud database
                    orderNames.Add("Order2");

                });


                var task3 = Task.Run(() =>
                {
                    orderNames.Add("Order2");
                    // order database3
                });

               await Task.WhenAll(task, task2, task3); // 3 seconds 

            }
            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
                    }

            return orderNames;
        }


        public async Task<IEnumerable<string>> GetOrdersAsyn2()
        {
           var result=  await GetOrdersAsync();
            return result;
        }

    }
}
