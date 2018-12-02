using System;
using System.Collections.Generic;

namespace Task369NumberWithWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0; bool isNumber = false; string spelledNumber;
            while (!isNumber)
            {
                Console.WriteLine("Enter a number and the console will show you how it's written with words.");
                Console.WriteLine("The number must be in the interval - [0;999999999]");
                isNumber = int.TryParse(Console.ReadLine(), out number);
                while (number >= 999999999)
                {
                    Console.WriteLine("The number you have entered has more than 9 digits!");
                    Console.WriteLine("Enter a number in the set interval!!!");
                    isNumber = int.TryParse(Console.ReadLine(), out number);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            spelledNumber = SpellingNumber(number);
            Console.WriteLine(spelledNumber);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
        }
        static string SpellingNumber(int num)
        {
            string SpelledNumber = null;
            string[] units = { null, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "sventeen", "eightteen", "nineteen" };
            string[] uintsCaps = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eightteen", "Nineteen" };
            string[] tenths = { null, "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] tenthsCaps = { null, "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            int[] numberArray = new int[9];
            List<int> listOfInts = new List<int>();
            while (num > 0) { listOfInts.Add(num % 10); num = num / 10; }
            listOfInts.Reverse();
            numberArray = listOfInts.ToArray();
            if (num == 0) SpelledNumber = uintsCaps[num];
            switch (numberArray.Length)
            {
                case 1: { SpelledNumber = (uintsCaps[numberArray[0]]); break; }
                case 2:
                    {
                        if (numberArray[0] * 10 + numberArray[1] <= 19) SpelledNumber = (units[numberArray[0] * 10 + numberArray[1]]);
                        else SpelledNumber = (tenths[numberArray[0]] + " " + units[numberArray[1]]); break;
                    }
                case 3:
                    {
                        SpelledNumber = (uintsCaps[numberArray[0]] + " hundred ");
                        if (numberArray[1] * 10 + numberArray[2] <= 19) SpelledNumber += (units[numberArray[1] * 10 + numberArray[2]]);
                        else SpelledNumber += (tenths[numberArray[1]] + " " + units[numberArray[2]]); break;
                    }
                case 4:
                    {
                        SpelledNumber = (uintsCaps[numberArray[0]] + " thousand, ");
                        if (numberArray[1] >= 1) SpelledNumber += (units[numberArray[1]] + " hundred "); else SpelledNumber += null;
                        if (numberArray[2] * 10 + numberArray[3] <= 19) SpelledNumber += (units[numberArray[2] * 10 + numberArray[3]]);
                        else SpelledNumber += (tenths[numberArray[2]] + " " + units[numberArray[3]]); break;
                    }
                case 5:
                    {
                        if (numberArray[0] * 10 + numberArray[1] <= 19) SpelledNumber = (uintsCaps[numberArray[0] * 10 + numberArray[1]] + " thousand, ");
                        else SpelledNumber = (tenthsCaps[numberArray[0]] + " " + units[numberArray[1]] + " thousand, ");
                        if (numberArray[2] >= 1) SpelledNumber += (units[numberArray[2]] + " hundred "); else SpelledNumber += null;
                        if (numberArray[3] * 10 + numberArray[4] <= 19) SpelledNumber += (units[numberArray[3] * 10 + numberArray[4]]);
                        else SpelledNumber += (tenths[numberArray[3]] + " " + units[numberArray[4]]); break;
                    }
                case 6:
                    {
                        SpelledNumber = (uintsCaps[numberArray[0]] + " hundred ");
                        if (numberArray[1] * 10 + numberArray[2] <= 19) SpelledNumber += (units[numberArray[1] * 10 + numberArray[2]] + " thousand, ");
                        else SpelledNumber += (tenths[numberArray[1]] + " " + units[numberArray[2]] + " thousand, ");
                        if (numberArray[3] >= 1) SpelledNumber += (units[numberArray[3]] + " hundred "); else SpelledNumber += null;
                        if (numberArray[4] * 10 + numberArray[5] <= 19) SpelledNumber += (units[numberArray[4] * 10 + numberArray[5]]);
                        else SpelledNumber += (tenths[numberArray[4]] + " " + units[numberArray[5]]); break;
                    }
                case 7:
                    {
                        SpelledNumber = (uintsCaps[numberArray[0]] + " million, ");
                        if (numberArray[1] >= 1) SpelledNumber += (units[numberArray[1]] + " hundred "); else SpelledNumber += null;
                        if (numberArray[2] * 10 + numberArray[3] <= 19) SpelledNumber += (units[numberArray[2] * 10 + numberArray[3]] + " thousand, ");
                        else SpelledNumber += (tenths[numberArray[2]] + " " + units[numberArray[3]] + " thousand, ");
                        if (numberArray[4] >= 1) SpelledNumber += (units[numberArray[4]] + " hundred "); else SpelledNumber += null;
                        if (numberArray[5] * 10 + numberArray[6] <= 19) SpelledNumber += (units[numberArray[5] * 10 + numberArray[6]]);
                        else SpelledNumber += (tenths[numberArray[5]] + " " + units[numberArray[6]]); break;
                    }
                case 8:
                    {
                        if (numberArray[0] * 10 + numberArray[1] <= 19) SpelledNumber = (uintsCaps[numberArray[0] * 10 + numberArray[1]] + " million, ");
                        else SpelledNumber = (tenthsCaps[numberArray[0]] + " " + units[numberArray[1]] + " million, ");
                        if (numberArray[2] * 100 + numberArray[3] * 10 + numberArray[4] > 0)
                        {
                            if (numberArray[2] >= 1) SpelledNumber += (units[numberArray[2]] + " hundred "); else SpelledNumber += null;
                            if (numberArray[3] * 10 + numberArray[4] <= 19) SpelledNumber += (units[numberArray[3] * 10 + numberArray[4]] + " thousand, ");
                            else SpelledNumber += (tenths[numberArray[3]] + " " + units[numberArray[4]] + " thousand, ");
                        }
                        else SpelledNumber += null;
                        if (numberArray[5] >= 1) SpelledNumber += (units[numberArray[5]] + " hundred "); else SpelledNumber += null;
                        if (numberArray[6] * 10 + numberArray[7] <= 19) SpelledNumber += (units[numberArray[6] * 10 + numberArray[7]]);
                        else SpelledNumber += (tenths[numberArray[6]] + " " + units[numberArray[7]]); break;
                    }
                case 9:
                    {
                        SpelledNumber = (uintsCaps[numberArray[0]] + " hundred ");
                        if (numberArray[1] * 10 + numberArray[2] <= 19) SpelledNumber += (units[numberArray[1] * 10 + numberArray[2]] + " million, ");
                        else SpelledNumber += (tenths[numberArray[1]] + " " + units[numberArray[2]] + " million, ");
                        if (numberArray[3] * 100 + numberArray[4] * 10 + numberArray[5] > 0)
                        {
                            if (numberArray[3] >= 1) SpelledNumber += (units[numberArray[3]] + " hundred "); else SpelledNumber += null;
                            if (numberArray[4] * 10 + numberArray[5] <= 19) SpelledNumber += (units[numberArray[4] * 10 + numberArray[5]] + " thousand, ");
                            else SpelledNumber += (tenths[numberArray[4]] + " " + units[numberArray[5]] + " thousand, ");
                        }
                        else SpelledNumber += null;
                        if (numberArray[6] >= 1) SpelledNumber += (units[numberArray[6]] + " hundred "); else SpelledNumber += null;
                        if (numberArray[7] * 10 + numberArray[8] <= 19) SpelledNumber += (units[numberArray[7] * 10 + numberArray[8]]);
                        else SpelledNumber += (tenths[numberArray[7]] + " " + units[numberArray[8]]); break;
                    }
            }
            return SpelledNumber;
        }
    }
}
