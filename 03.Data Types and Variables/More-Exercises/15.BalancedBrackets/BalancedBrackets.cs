using System;

public class BalancedBrackets
{
    public static void Main()
    {
        int counter = int.Parse(Console.ReadLine());

        string lastBracket = null;
        string print = "BALANCED";

        for (int i = 1; i <= counter; i++)
        {
            string curRow = Console.ReadLine();

            if (curRow == "(")
            {
                if (lastBracket == "(")
                {
                    print = "UNBALANCED";
                    break;
                }
                lastBracket = "(";
            }
            else if (curRow == ")")
            {
                if (lastBracket != "(")
                {
                    print = "UNBALANCED";
                    break;
                }
                lastBracket = ")";
            }
        }

        if (lastBracket == "(")
        {
            print = "UNBALANCED";
        }

        Console.WriteLine(print);
    }
}