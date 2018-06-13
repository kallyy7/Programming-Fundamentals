using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceAndQuantity = new Dictionary<string, int>();
            int curr = 0;
            while (true)
            {
                string resourse = Console.ReadLine();
                if (resourse == "stop")
                {
                    break;
                }
                int quantity =int.Parse(Console.ReadLine());

                if (resourceAndQuantity.ContainsKey(resourse))
                {
                    curr = resourceAndQuantity[resourse];
                    curr = curr + quantity;
                    resourceAndQuantity[resourse] = curr;
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
}
