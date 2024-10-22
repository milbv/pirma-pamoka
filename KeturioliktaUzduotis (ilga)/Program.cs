using System;
namespace KeturioliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite metines pajamas eurais: ");
            double pajamos = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite taikomo mokescio norma (5% arba 15%)");
            double mokestineNorma = double.Parse(Console.ReadLine());

            double pajamuMokestis = pajamos * (mokestineNorma / 100);
            double leidziamosIslaidos = pajamos * 0.3 - pajamuMokestis;
            double VSDimoka = (pajamos - leidziamosIslaidos) * 0.1383;
            double PSDimoka = (pajamos - leidziamosIslaidos) * 0.0698;

            Console.WriteLine($"Atlikus skaiciavimus gauti rezultatai:\n" +
                $"Bendros Pajamos: {pajamos}\n" +
                $"Leidziamos islaidos: {leidziamosIslaidos}\n" +
                $"Mokestines prievoles suma: {pajamuMokestis}\n" +
                $"VSD moketina suma: {VSDimoka}\n" +
                $"PSD moketina suma: {PSDimoka}\n" +
                $"Galutinis mokestis: {pajamuMokestis + VSDimoka + PSDimoka}");
        }
    }
}