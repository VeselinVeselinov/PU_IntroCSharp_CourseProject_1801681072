using System;

namespace Task14ArithmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("This program will calculate the sum - [S] of an arithmetic progression when you enter: ");
            Console.WriteLine("- the first member of the progression - [a1]");
            Console.WriteLine("- the distance - [d]");
            Console.WriteLine("- and the number of the members in the progression - [n]");
            double a1 = 0; bool isNumber = false;
            while (!isNumber)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Enter value for [a1]:");
                isNumber = double.TryParse(Console.ReadLine(), out a1);
            }
            double d = 0; isNumber = false;
            while (!isNumber)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Enter value for [d]:");
                isNumber = double.TryParse(Console.ReadLine(), out d);
            }
            int n = 0; isNumber = false;
            while (!isNumber)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Enter value for [n]:");
                isNumber = int.TryParse(Console.ReadLine(), out n);
            }
            Console.WriteLine("-------------------------------------");
            double sum = ((2 * a1 + (n - 1) * d) / 2) * n;
            Console.WriteLine("The sum [S] is: " + sum);
        }
    }
}
