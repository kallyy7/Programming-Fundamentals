using System;
using System.Collections.Generic;
using System.Linq;

public class DragonArmy
{
    public static void Main()
    {
        var army = new SortedDictionary<string, List<Dragon>>();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();
            string[] data = input.Split();

            string type = data[0];
            string name = data[1];
            int damage = int.Parse(data[2]);
            int health = int.Parse(data[3]);
            int armor = int.Parse(data[4]);

            Dragon dragon = new Dragon()
            {
                Name = name,
                Damage = damage,
                Armor = armor,
                Health = health
            };

            if (army.ContainsKey(type) == false)
            {
                army.Add(type, new List<Dragon>());
            }

            army[type].Add(dragon);

            foreach (var t in army)
            {
                var damageAv = t
                    .Value
                    .Select(d => d.Damage)
                    .Average();
                var healthAv = t
                    .Value
                    .Select(d => d.Health)
                    .Average();
                var armorAv = t
                    .Value
                    .Select(d => d.Armor)
                    .Average();

                Console.WriteLine($"{t.Key}:: ({damageAv:f2}, {healthAv:f2}, {armorAv:f2})");

                foreach (var d in t.Value.OrderBy(d => d.Name))
                {
                    Console.WriteLine($"={d.Name}  -> damage: {d.Damage} ,health: {d.Health},armor: {d.Armor}");
                }
            }
        }
    }
}

public class Dragon
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Armor { get; set; }
    public int Health { get; set; }
}