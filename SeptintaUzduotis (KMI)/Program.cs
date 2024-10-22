using System;

namespace SeptintaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kuno svori kilogramais");
            double svoris = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite ugi metrais");
            double ugis = double.Parse(Console.ReadLine());

            double kmi = (svoris / Math.Pow(ugis, 2));
            Console.WriteLine($"Jusu Kuno mases indeksas (KMI) yra: {kmi}");
        }
    }
}