using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatements
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region  Datatypes in C#
            int firstNumber = 10;
            float price = 120;
            double quantity = 20.8;
            DateTime todaysDate = DateTime.Now;
            bool hasValue = false;

            if (args.Length > 0)
            {
                hasValue = true;
                Console.WriteLine($"Boolean value is set to true and value is {args[0]}");
            }

            Console.WriteLine("FirstNumber is {0}", +firstNumber);

            Console.WriteLine($"FirstNumber is {firstNumber}");

            Console.WriteLine($"price is {price}");

            Console.WriteLine($"quantity is {quantity}");
            Console.WriteLine($"Todays date is {todaysDate}");


            Console.WriteLine("$Enter the Second Number");

            var secondNumber = Convert.ToInt32(Console.ReadLine());

            var thirdNumber = 20;

            Console.WriteLine($"SecondNumber Entered is {secondNumber}");


            Console.WriteLine($"Sum of two numbers is {firstNumber + secondNumber} ");


            Console.ReadKey();

            //Conditions, Switch , While

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Firstnumber is greater than second number");
            }
            if (firstNumber == secondNumber)
            {
                Console.WriteLine($"Numbers are equest");

            }
            if (!hasValue)
            {
                Console.WriteLine("No Args passed in commandline");
            }
            else
            {
                Console.WriteLine($"Second is greater than First number");
            }


        }
        #endregion

        //array : Collection of elements of same type

        //type[]name = new type [size];

        int[] myarray = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        string[] sarray = new string[] { "Mango", "Apple", "abc" };

        ArrayList myarrayList = new ArrayList();

        #region While Loop

        #endregion




    }

    
}
