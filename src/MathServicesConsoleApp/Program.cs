using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathServicesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            int a;

            if (int.TryParse(input1, out a))
            {
                Console.WriteLine("Enter the second number:");
                string input2 = Console.ReadLine();
                int b;

                if (int.TryParse(input2, out b))
                {
                    Console.WriteLine($"{a} + {b} = {MathLibrary.MathClass.Add(a, b)}");
                    Console.WriteLine($"{a} + {b} = {MathLibrary.MathClass.Subtract(a, b)}");
                    Console.WriteLine($"{a} + {b} = {MathLibrary.MathClass.Multiply(a, b)}");
                    Console.WriteLine($"{a} + {b} = {MathLibrary.MathClass.Divide(a, b)}");
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number.");
            }
            Console.ReadKey();
        }
    }
}
