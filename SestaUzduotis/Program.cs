using System;

namespace SestaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite temperatura Celcijaus laipsniais: ");
            double temperaturaC = double.Parse(Console.ReadLine());

            double temperaturaF = 9.0 / 5.0 * temperaturaC + 32;
            Console.WriteLine($"Temperatura Farenheito laipsniais: {temperaturaF}");
        }
    }
}