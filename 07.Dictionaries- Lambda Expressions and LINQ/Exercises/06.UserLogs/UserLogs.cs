using System;
using System.Collections.Generic;
using System.Linq;

public class UserLogs
{
    public static void Main()
    {
        var userLog = new SortedDictionary<string, List<string>>();
        var input = Console.ReadLine()
            .Split(" =".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        while (!input[0].Equals("end"))
        {
            string ip = input[1];
            string user = input[5];

            if (!userLog.ContainsKey(user))
            {
                userLog[user] = new List<string>();
                userLog[user].Add(ip);
            }
            else
            {
                userLog[user].Add(ip);
            }

            input = Console.ReadLine()
                .Split(" =".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();
        }

        foreach (var item in userLog)
        {
            Console.WriteLine("{0}: ", item.Key);
            var ips = new List<string>();

            for (int i = 0; i < item.Value.Count; i++)
            {
                int count = 0;

                for (int j = i; j < item.Value.Count; j++)
                {
                    if (item.Value[i].Equals(item.Value[j]))
                    {
                        count++;
                    }
                }
                if (!ips.Contains(item.Value[i]))
                {
                    if (i == item.Value.Count - 1)
                    {
                        Console.Write(string.Join("", item.Value[i]) + " => " + count + ".");
                    }
                    else
                    {
                        Console.Write(string.Join("", item.Value[i]) + " => " + count + ", ");
                    }
                }

                ips.Add(item.Value[i]);
            }

            Console.WriteLine();
        }
    }
}