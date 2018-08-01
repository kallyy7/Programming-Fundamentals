using System;
using System.Collections.Generic;
using System.Linq;

public class LegendaryFarming
{
    public static void Main()
    {
        var possibelItems = new Dictionary<string, int>
        {
            { "shards", 0 },
            { "fragments", 0 },
            { "motes", 0 }
        };

        var junk = new SortedDictionary<string, int>();
        bool isOk = true;

        while (true)
        {
            var curentRow = Console.ReadLine()
                .ToLower()
                .Split()
                .ToList();

            for (int i = 0; i < curentRow.Count; i += 2)
            {
                int quantity = int.Parse(curentRow[i]);
                string material = curentRow[i + 1];

                if (material == "shards" || material == "fragments" || material == "motes")
                {
                    possibelItems[material] += quantity;
                }
                else
                {
                    if (!junk.ContainsKey(material))
                    {
                        junk[material] = quantity;
                    }
                    else
                    {
                        junk[material] += quantity;
                    }
                }

                foreach (KeyValuePair<string, int> item in possibelItems)
                {
                    if (item.Value >= 250)
                    {
                        isOk = false;
                        break;
                    }
                }

                if (isOk == false)
                {
                    break;
                }
            }

            if (isOk == false)
            {
                break;
            }
        }

        foreach (var item in possibelItems.OrderByDescending(x => x.Value))
        {
            if (item.Key == "fragments" && item.Value >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                possibelItems[item.Key] = item.Value - 250;

            }
            else if (item.Key == "shards" && item.Value >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                possibelItems[item.Key] = item.Value - 250;
            }
            else if (item.Key == "motes" && item.Value >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                possibelItems[item.Key] = item.Value - 250;
            }
        }

        foreach (var item in possibelItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine("{0}: {1}", item.Key, item.Value);
        }

        foreach (var mat in junk)
        {
            Console.WriteLine("{0}: {1}", mat.Key, mat.Value);
        }
    }
}