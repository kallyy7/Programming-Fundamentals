namespace _03.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> demonData = new Dictionary<string, double[]>();
            List<string> demons = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < demons.Capacity; i++)
            {
                string demonName = demons[i];
                int demonHealth = DemonHealth(demonName);
                double demonDamage = DemonDamage(demonName);

                demonData[demonName] = new double[2];
                demonData[demonName][0] = demonHealth;
                demonData[demonName][1] = demonDamage;

            }

            foreach (var demon in demonData.OrderBy(d => d.Key))
            {
                Console.WriteLine($"{demon.Key} - {(int)demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }

        }

        static int DemonHealth(string demonName)
        {
            int totalHealth = 0;
            string patternHealth = @"[^0-9+\-*\/.]";        

            foreach (Match match in Regex.Matches(demonName, patternHealth))
            {
                totalHealth += match.Value[0];
            }

            return totalHealth;
        }

        static double DemonDamage(string demonName)
        {
            string patternDamage = @"(-)?\d+(\.\d+)*";
            string patternMultiply = @"\*";
            string patternDivide = @"\/";
            double totalDamage = 0;

            // damage -------------------
            foreach (Match numbers in Regex.Matches(demonName, patternDamage))
            {
                totalDamage += double.Parse(numbers.Value);
            }

            // star (Multiply) counter --------------
            int multiplyCounter = 0;
            foreach (Match star in Regex.Matches(demonName, patternMultiply))
            {
                multiplyCounter++;
            }

            // Divide counter --------------------
            int divideCounter = 0;
            foreach (Match div in Regex.Matches(demonName, patternDivide))
            {
                divideCounter++;
            }
            // TOTAL DAMAGE ----------------
            if (multiplyCounter > 0)
            {
                totalDamage *= Math.Pow(2, multiplyCounter);
            }
            if (divideCounter > 0)
            {
                totalDamage /= Math.Pow(2, divideCounter);
            }

            return totalDamage;
        }
    }
}
