using System;

namespace AstuntaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite valandas, kurias norite matyti minutemis bei sekundemis");
            double valandos = double.Parse(Console.ReadLine());

            double minutes = valandos * 60;
            double sekundes = minutes * 60;
            Console.WriteLine($"{valandos} valanda(s) sudaro {minutes} minutes arba {sekundes} sekundes");
        }
    }
}