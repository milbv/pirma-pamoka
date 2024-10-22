using System;

namespace DvyliktaUzduotis
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            double skaicius = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite procenta: ");
            double procentas = double.Parse(Console.ReadLine());

            Console.WriteLine($"skaiciaus {skaicius} {procentas}% yra {skaicius / 100 * procentas}");
        }
    }
}