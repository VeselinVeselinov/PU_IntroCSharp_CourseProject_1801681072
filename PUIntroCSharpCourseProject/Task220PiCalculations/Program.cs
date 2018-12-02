using System;

namespace Task220PiCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            double calculated1 = CalculatePi(3, 15) / CalculatePi(1, 15);
            Console.WriteLine(calculated1);
            double calculated2 = CalculatePi(3, 15) / CalculatePi(1, 20);
            Console.WriteLine("----------------");
            Console.WriteLine(calculated2);
            Console.WriteLine("----------------");
        }
        static double CalculatePi(int exponent, int LenghtOfPi)
        {
            double calculated = 1.0;
            for (int i = 1; i < LenghtOfPi; i++)
            {
                calculated *= 1 / (Math.Pow(i, exponent) + 1.0);
            }
            return calculated;
        }
    }
}
