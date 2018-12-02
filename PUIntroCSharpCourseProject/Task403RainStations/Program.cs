using System;
using System.Collections.Generic;

namespace Task403RainStations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int days = 5;

            double[] station1 = new double[days];
            EnterRainPerDay(station1);
            GetMaxRain(station1);

            double[] station2 = new double[days];
            EnterRainPerDay(station2);
            GetMaxRain(station2);

            double[] station3 = new double[days];
            EnterRainPerDay(station3);
            GetMaxRain(station3);
        }
        static void EnterRainPerDay(double[] station)
        {
            bool isDouble = false;
            Console.WriteLine("Hello. This program will be working with the daily rain values for this current station.");
            for (int i = 0; i < station.Length; i++)
            {
                do
                {
                    Console.WriteLine("Enter daily rain income for day: " + (i + 1) + " (in l/m²)");
                    isDouble = double.TryParse(Console.ReadLine(), out station[i]);
                } while (!isDouble);
            }
        }
        static void GetMaxRain(double[] station)
        {
            List<double> list = new List<double>();
            double max = 0;
            for (int i = 0; i < station.Length; i++)
            {
                if (station[i] > max) max = station[i];
            }
            for (int i = 0; i < station.Length; i++)
            {
                if (station[i] == max) list.Add(i + 1);
            }
            Console.WriteLine("------------------------------------------");
            Console.Write("The maximum daily rain income is: " + max + " l/m² --------> on day(s): ");
            foreach (double item in list)
            {
                Console.Write("|" + item + "|");
            }
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------");
        }
    }
}
