using System;
using System.Collections.Generic;

namespace Task96CalculationsWithN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("You have to enter a number - [n] and the program will do some calculations with it.");
            double n = 0; bool isNumber = false;
            while (!isNumber)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Enter a value for [n]");
                isNumber = double.TryParse(Console.ReadLine(), out n);
            }
            double sum = 1.0;
            List<double> list = new List<double>();
            for (int i = 2; i <= n; i++)
            {
                double denominator = i * i - i + 1;
                double number = 1 / denominator;
                list.Add(number);
            }
            for (int i = 0; i < list.Count; i++)
            {
                sum *= list[i];
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("After the calculations - [n] is: " + sum);
        }
    }
}
