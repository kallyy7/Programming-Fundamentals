using System;

public class DebitCardNumber
{
    public static void Main()
    {
        int firstCard = int.Parse(Console.ReadLine());
        int secondCard = int.Parse(Console.ReadLine());
        int thirdCard = int.Parse(Console.ReadLine());
        int fourthCard = int.Parse(Console.ReadLine());

        Console.WriteLine($"{firstCard:D4} {secondCard:D4} {thirdCard:D4} {fourthCard:D4}");
    }
}