using System;

namespace DesimtaUzduotis
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite valandini darbo uzmokesti: ");
            double valandinisUzmokestis = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite darbo valandu skaiciu per savaite: ");
            double valanduSkaicius  = double.Parse(Console.ReadLine());

            double savaitinis = valandinisUzmokestis * valanduSkaicius;
            double menesinis = savaitinis * 4;
            double metinis = menesinis * 12;
            Console.WriteLine($"Darbo uzmokestis:\n savaitinis: {savaitinis} eur\n menesinis: {menesinis} eur\n metinis: {metinis} eur");
        }
    }
}