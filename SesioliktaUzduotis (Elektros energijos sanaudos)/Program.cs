using System;
namespace SesioliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite elektros energijos suvartojima per menesi (kilovatvalandemis - kWh");
            double elektrosEnergija = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite Elektros energijos tarifa uz kilovatvalande (eurais)");
            double elektrosTarifas = double.Parse(Console.ReadLine());
            Console.WriteLine("Jei taikomas, iveskite papildomus mokescius (pvz, abonentinis mokesti ar kitus fiksuotus mokescius");
            double tarifas = double.Parse(Console.ReadLine());

            Console.WriteLine($"Elektros energijos sanaudos: {elektrosEnergija * elektrosTarifas} eur");
            Console.WriteLine($"Bendra suma: {elektrosEnergija * elektrosTarifas + tarifas} eur");
        }
    }
}