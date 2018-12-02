using System;

namespace Test2Task3Part2TheFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. The program will calculate the fucntion(number).");
            int number = 0; bool isNumber = false;
            do
            {
                Console.WriteLine("Enter a number:");
                isNumber = int.TryParse(Console.ReadLine(), out number);
            } while (!isNumber);

            if (number < -10)
            {
                double case1 = 0;
                case1 = (1 / Math.Tan(2 - Math.Pow(number, 2))) / -(number + 10);
                if (-(number + 10) == 0) Console.WriteLine("You cant divide by 0, therefore the calculation can't be done.");
                else Console.WriteLine("The calculated function - f(number) is: " + case1);

            }
            else if (number >= -10 && number < 0)
            {
                int case2 = 0;
                Console.WriteLine("The calculated function - f(number) is: " + case2);
            }
            else if (number >= 0)
            {
                double case3 = 0;
                double e = Math.E;
                case3 = (Math.Pow(e, Math.Sin(number) * Math.Cos(number))) / Math.Log(Math.Sqrt(number) + Math.Pow(4, number));
                if (Math.Log(Math.Sqrt(number) + Math.Pow(4, number)) == 0) Console.WriteLine("You cant divide by 0, therefore the calculation can't be done.");
                else Console.WriteLine("The calculated function - f(number) is: " + case3);
            }
        }
    }
}
