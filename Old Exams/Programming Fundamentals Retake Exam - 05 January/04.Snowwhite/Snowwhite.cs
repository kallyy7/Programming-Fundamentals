using System;
using System.Collections.Generic;
using System.Linq;

public class Snowwhite
{
    public static void Main()
    {
        var dwarfData = new Dictionary<string, int>();

        string input = Console.ReadLine();

        while (!input.Equals("Once upon a time"))
        {
            string[] data = input
                .Split("<:>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string hatColor = data[1];
            string name = data[0];
            int physics = int.Parse(data[2]);

            string dwarf = "(" + hatColor.Trim() + ")" + " " + name;

            if (!dwarfData.ContainsKey(dwarf))
            {
                dwarfData.Add(dwarf, physics);
            }
            else
            {
                dwarfData[dwarf] = Math.Max(dwarfData[dwarf], physics);
            }

            input = Console.ReadLine();
        }

        foreach (var dwarff in dwarfData.OrderByDescending(dwarf => dwarf.Value))
        {
            Console.WriteLine(dwarff.Key + "<-> " + dwarff.Value);
        }
    }
}