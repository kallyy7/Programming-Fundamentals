using System;
using System.Linq;

public class ReverseAString
{
    public static void Main()
    { 
        char[] reverse = Console.ReadLine().ToCharArray();
        
        Console.WriteLine(string.Join("",reverse.Reverse()));
    }
}