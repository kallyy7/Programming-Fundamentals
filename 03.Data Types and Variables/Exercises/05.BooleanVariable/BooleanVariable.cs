using System;

public class BooleanVariable
{
    public static void Main()
    {
        string convertToBool = Console.ReadLine();

        if (Convert.ToBoolean(convertToBool))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}