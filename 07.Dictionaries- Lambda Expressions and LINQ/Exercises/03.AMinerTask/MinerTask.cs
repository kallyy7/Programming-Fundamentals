using System;
using System.Collections.Generic;

public class MinerTask
{
    public static void Main()
    {
        var resourceAndQuantity = new Dictionary<string, int>();
        int current = 0;

        while (true)
        {
            string resourse = Console.ReadLine();

            if (resourse == "stop")
            {
                break;
            }
            int quantity = int.Parse(Console.ReadLine());

            if (resourceAndQuantity.ContainsKey(resourse))
            {
                current = resourceAndQuantity[resourse];
                current = current + quantity;
                resourceAndQuantity[resourse] = current;
            }
            else
            {
                resourceAndQuantity[resourse] = quantity;
            }
        }

        foreach (var item in resourceAndQuantity)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}