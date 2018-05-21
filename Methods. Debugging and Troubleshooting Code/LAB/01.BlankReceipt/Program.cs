using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BlankReceipt
{
    class Program
    {
        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintReceiptFooter()
        {
            char a = '©';
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{a} SoftUni");
        }
        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }
        static void Main(string[] args)
        {
            PrintReceipt();
        }
    }
}
