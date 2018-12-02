using System;

namespace Task1NumberSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2072;
            string numberToBinary = Convert.ToString(number, 2);
            Console.WriteLine("My number -----> "+number);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("The number in binary system -----------> " + numberToBinary);
            string numberToOct = Convert.ToString(number, 8);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("The number in octal system (oct) ------------> " + numberToOct);
            string numberToHex = Convert.ToString(number, 16);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("The number in hexadecimal system (hex) ------> " + numberToHex);
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
