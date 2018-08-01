using System;
using System.Linq;

public class UpgradeMatcher
{
    public static void Main()
    {
        var productNames = Console.ReadLine()
            .Split()
            .ToArray();
        var productQuantity = Console.ReadLine()
            .Split()
            .Select(long.Parse)
            .ToList();
        var productPrice = Console.ReadLine()
            .Split()
            .Select(decimal.Parse)
            .ToArray();

        int diff = productNames.Length - productQuantity.Count;

        for (int i = 0; i < diff; i++)
        {
            productQuantity.Add(0);
        }
        
        while (true)
        {
            var product = Console.ReadLine()
                .Split()
                .ToArray();

            if (product[0] == "done")
            {
                return;
            }

            long quantityNeeded = long.Parse(product[1]);

            for (int i = 0; i < productNames.Length; i++)
            {
                if (product[0].Equals(productNames[i]))
                {
                    productQuantity[i] -= quantityNeeded;

                    if (productQuantity[i] >= 0)
                    {
                        var totalPrice = quantityNeeded * productPrice[i];
                        Console.WriteLine($"{productNames[i]} x {quantityNeeded} costs {totalPrice:F2} ");
                    }
                    else
                    {
                        Console.WriteLine($"We do not have enough {productNames[i]}");
                        productQuantity[i] += quantityNeeded;
                    }
                }
            }
        }
    }
}