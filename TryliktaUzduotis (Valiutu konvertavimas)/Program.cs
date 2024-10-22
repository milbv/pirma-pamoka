using System;

namespace TryliktaUzduotis
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite suma litais: ");
            double litai = double.Parse(Console.ReadLine());
            double eurai = Math.Round(litai * 3.4528, 2);
            double doleriai = Math.Round(eurai * 0.93, 2);
            double svarai = Math.Round(doleriai * 1.31, 2);

            Console.WriteLine($"{litai} litai yra tas pats kaip:\n{eurai} eurai\n{doleriai} doleriai\n{svarai} svarai");
        }
    }
}