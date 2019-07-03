using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daysofweek
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\batuhan.celebi\source\repos\daysofweek\daysofweek\PopByLarge.csv";

            CsvReadr reader = new CsvReadr(filePath);


            List<Country> countries = reader.ReadAllCountries();
            Country deneme = new Country("deneme", "DEN", "Somewhere", 2_000_000);
            int denemeIndex = countries.FindIndex(x=>x.Population < 2_000_000);
            countries.Insert(denemeIndex, deneme);
            countries.RemoveAt(denemeIndex);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            Console.WriteLine($"{countries.Count} countries ");

        }
    }
}
