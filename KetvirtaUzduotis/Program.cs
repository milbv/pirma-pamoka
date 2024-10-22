using System;
namespace KetvirtaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma sveika skaiciu");
            int pirmasSkaicius = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite antra sveika skaiciu");
            int antrasSkaicius = int.Parse(Console.ReadLine());

            Console.Write("Skaiciu suma: ");
            Console.WriteLine(pirmasSkaicius + antrasSkaicius);

            Console.Write("Skaiciu skirtumas: ");
            Console.WriteLine(pirmasSkaicius - antrasSkaicius);

            Console.Write("Skaiciu sandauga: ");
            Console.WriteLine(pirmasSkaicius * antrasSkaicius);

            Console.Write("Skaiciu dalyba: ");
            Console.WriteLine((double) pirmasSkaicius / antrasSkaicius);

            Console.Write("Pirmo skaicio kvadratas: ");
            Console.WriteLine(pirmasSkaicius * pirmasSkaicius);

            Console.Write("Antro skaicio kvadratas: ");
            Console.WriteLine(antrasSkaicius * antrasSkaicius);
        }
    }
}