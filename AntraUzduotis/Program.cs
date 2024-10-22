using System;

namespace AntraUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite nuvaziuota atstuma kilometrais: ");
            double atstumas = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite sunaudoto kuro kieki litrais: ");
            double sunaudotasKuras  = double.Parse(Console.ReadLine());

            double kuroSanaudos = sunaudotasKuras / atstumas * 100;
            Console.WriteLine($"Kuro sanaudos: {kuroSanaudos} l/100km");
        }
    }
}