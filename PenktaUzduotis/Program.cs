using System;

namespace PenktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu: ");
            double pirmasSkaicius = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu: ");
            double antrasSkaicius = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite trecia skaiciu: ");
            double treciasSkaicius = double.Parse(Console.ReadLine());

            double vidurkis = (pirmasSkaicius + antrasSkaicius + treciasSkaicius) / 3;
            Console.WriteLine($"Skaiciu vidurkis: {vidurkis}");
        }
    }
}