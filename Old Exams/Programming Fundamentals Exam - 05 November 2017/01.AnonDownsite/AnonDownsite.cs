using System;
using System.Linq;

public class AnonDownsite
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double securityKey = double.Parse(Console.ReadLine());

        string[] sites = new string[n];
        double securityToken = Math.Pow(securityKey, n);

        decimal totalLoss = 0;

        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine()
                .Split()
                .ToArray();
            string websiteName = data[0];
            long siteVisitors = long.Parse(data[1]);
            decimal siteLoss = decimal.Parse(data[2]);
            decimal currentLoss = siteLoss * siteVisitors;
            totalLoss += currentLoss;
            sites[i] = websiteName;
        }

        Console.WriteLine(string.Join(Environment.NewLine, sites));
        Console.WriteLine($"Total Loss: {totalLoss:F20}");
        Console.WriteLine($"Security Token: {securityToken}");
    }
}