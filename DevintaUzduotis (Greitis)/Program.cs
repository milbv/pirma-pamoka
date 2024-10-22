using System;

namespace DevintaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite atstuma, nuvaziuota kilometrais: ");
            double atstumas = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite laika, nuvaziuota valandomis: ");
            double laikas = double.Parse(Console.ReadLine());

            Console.WriteLine($"Vidutinis greitis: {atstumas / laikas}");
        }
    }
}