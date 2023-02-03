using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoloymorphismDemo
{
    internal class Calculator
    {
        //Static Poloymorphism
        // Overloading methods

        public void calculate(int firstNumber,int secondNumber)
        {
            Console.WriteLine($"Sum is {firstNumber + secondNumber}");
        }
        public void calculate(int firstNumber, int secondNumber,int thirdNumber)
        {
            Console.WriteLine($"Sum is {firstNumber + secondNumber + thirdNumber}");
        }

        public void calculate(double firstNumber, double secondNumber, double thirdNumber)
        {
            Console.WriteLine($"Sum is {firstNumber + secondNumber + thirdNumber}");
        }
    }
}
