using System;

public class BlankReceipt
{
    public static void Main()
    {
        PrintReceipt();
    }
    private static void PrintReceiptHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("------------------------------");
    }
    private static void PrintReceiptBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }
    private static void PrintReceiptFooter()
    {
        char a = '©';
        Console.WriteLine("------------------------------");
        Console.WriteLine($"{a} SoftUni");
    }
    private static void PrintReceipt()
    {
        PrintReceiptHeader();
        PrintReceiptBody();
        PrintReceiptFooter();
    }
}