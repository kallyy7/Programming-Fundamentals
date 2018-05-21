using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
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
        static int MaxIntNumber(int number, int secondNumber)
        {
            return Math.Max(number, secondNumber);
        }
        static char MaxCharNumber(char ch, char secondCh)
        {
            return (char)Math.Max(ch, secondCh);
        }
        static string MaxTextNumber(string text, string secondText)
        {
            return (text.Length > secondText.Length) ? text : secondText;
        }
    }
}
