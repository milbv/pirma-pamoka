using System;

namespace PenkioliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kuro kaina uz litra (eurais)");
            double kuroKaina = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite automobilio vidutines kuro sanaudas (litrai per 100km)");
            double vidSanaudos = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite per metus nuvaziuojama atstuma (kilometrais)");
            double atstumasPerMetus = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite technines prieziuros, draudimo ir kitu eksploatacijos islaidu suma (eurais per metus)");
            double miscIslaidos = double.Parse(Console.ReadLine());

            double kuroSanaudos = vidSanaudos * atstumasPerMetus / 100;
            double bendrosIslaidos = kuroSanaudos * kuroKaina + miscIslaidos;

            Console.WriteLine($"Bendras kuro sanaudos per metus: {kuroSanaudos} litru");
            Console.WriteLine($"Technines prieziuros ir kitu islaidu suma: {miscIslaidos} eur");
            Console.WriteLine($"Bendra automobilio eksploatacijos kaina per metus: {bendrosIslaidos} eur");
        }
    }
}