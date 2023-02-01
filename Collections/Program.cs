using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {


            object obj = 10;
            object stringObj = "stringvalue";
            object decimalval= 10.20;

            var anonymoutypeEx = new
            {
                Name ="ABC",
                Age = 20

,
            };

            Console.WriteLine(anonymoutypeEx.Name);
            Console.WriteLine(anonymoutypeEx.Age);

            #region arrayList

            //Array List

            var products = new string[] { "Mango", "Apple", "abc" };
            var intnumbers = new int[] { 12, 34, 567 };

            ArrayList itemsCollections = new ArrayList();

            itemsCollections.Add("1");
            itemsCollections.Add("Mango");
            itemsCollections.Add(10);

            ArrayList arrayListProducts = new ArrayList();

            arrayListProducts.Add("Macbook");
            arrayListProducts.Add("Iphone");
            arrayListProducts.Add("Samsung");


            itemsCollections.AddRange(arrayListProducts);

            //Loops

            foreach(var item in itemsCollections)
            {
                Console.WriteLine($" Item is {item}");
            }
            
            for(int i=10;i<15;i++)
            {
                Console.WriteLine(i);
            }

            int number = 10;

            while(number<=10)
            {
                Console.WriteLine(number);
                number = number - 1;
                ++number;
                number++;
               
            }
            #endregion

            List<int> numbersCollection = new List<int>() { 1, 2, 3, 4 };

            List<string> fruitsCollection = new List<string> { "Abc", "bbc", "bbb" };



            fruitsCollection.Add(10002.ToString());

            List<string> fruitsCollection2 = new List<string> { "asdf","asdf", "mmm" };

            fruitsCollection.AddRange(new List<string>()
            {
                "asdf","hhh","hhhasdf"
            });

            fruitsCollection.AddRange(fruitsCollection2);

            List<string> stringCollection = new ; 


        }
    }
}
