using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> population = new Dictionary<string, Dictionary<string, int>>();
            var cityAndPopulation = new Dictionary<string, int>();
            List<string> input = Console.ReadLine().Split("|").ToList();

            while (!input[0].Equals("report"))
            {
                string country = input[1];
                string city = input[0];
                int populationn = int.Parse(input[2]);


                if (!population.ContainsKey(country))
                {
                    cityAndPopulation = new Dictionary<string, int>();
                    cityAndPopulation[city] = populationn;
                    population[country] = cityAndPopulation;
                    
                }
                else
                {
                    cityAndPopulation[city] = populationn;
                    population[country] = cityAndPopulation;
                }

                input = Console.ReadLine().Split("|").ToList();
            }

            foreach (var item in population)
            {
                int totalPopulation = 0;
                foreach (var i in item.Value)
                {
                    totalPopulation += i.Value;                    
                }
         
                Console.Write(item.Key);
                Console.WriteLine($" (totalpopulation: {totalPopulation})");
                foreach (var i in item.Value)
                {
                    Console.WriteLine("=>" + string.Join(" ", i.Key) + ":" + i.Value);
                }
            }
        }
    }
    
}
