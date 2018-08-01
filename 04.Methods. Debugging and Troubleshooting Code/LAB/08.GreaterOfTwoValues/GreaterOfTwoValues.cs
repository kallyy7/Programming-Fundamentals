using System;

public class GreaterOfTwoValues
{
    public static void Main()
    {
        string type = Console.ReadLine();
        if (type == "int")
        {
            int number = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(MaxIntNumber(number, secondNumber));
        }
        else if (type == "char")
        {
            char ch = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());

            Console.WriteLine(MaxCharNumber(ch, secondCh));
        }
        else if (type == "string")
        {
            string text = Console.ReadLine();
            string secondText = Console.ReadLine();

            Console.WriteLine(MaxTextNumber(text, secondText));
        }
    }
    private static int MaxIntNumber(int number, int secondNumber)
    {
        return Math.Max(number, secondNumber);
    }
    private static char MaxCharNumber(char ch, char secondCh)
    {
        return (char)Math.Max(ch, secondCh);
    }
    private static string MaxTextNumber(string text, string secondText)
    {
        return (text.Length > secondText.Length) ? text : secondText;
    }
}