using System;

namespace TreciaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite trikampio pagrindo ilgi (cm) ");
            double pagrindas = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite trikampio auksti (cm) ");
            double aukstis = double.Parse(Console.ReadLine());

            double plotas = 1.0 / 2.0 * pagrindas * aukstis;
            Console.WriteLine($"Trikampio plotas: {plotas} cm");
        }
    }
}