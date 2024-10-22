using System;

namespace VienuoliktaUzduotis
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite apskritimo spinduli: ");
            double spindulys = double.Parse(Console.ReadLine());

            double plotas = Math.PI * Math.Pow(spindulys, 2);
            Console.WriteLine($"Apskritimo spindulys: {plotas}");
        }
    }
}